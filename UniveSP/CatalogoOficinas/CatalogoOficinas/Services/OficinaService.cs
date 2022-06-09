using CatalogoOficinas.Entities;
using CatalogoOficinas.Exceptions;
using CatalogoOficinas.InputModel;
using CatalogoOficinas.Repositories;
using CatalogoOficinas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Services
{
    public class OficinaService : IOficinaService
    {
        private readonly IOficinaRepository _oficinaRepository;

        public OficinaService(IOficinaRepository oficinaRepository)
        {
            _oficinaRepository = oficinaRepository;
        }

        public async Task<List<OficinaViewModel>> Obter(int pagina, int quantidade)
        {
            var oficinas = await _oficinaRepository.Obter(pagina, quantidade);

            return oficinas.Select(oficina => new OficinaViewModel
            {
                Id = oficina.Id,
                Nome = oficina.Nome,
                Endereco = oficina.Endereco,
                Descricao = oficina.Descricao,
                Cnpj = oficina.Cnpj,
                Estrelas = oficina.Estrelas
            }).ToList();
        }

        public async Task<OficinaViewModel> Obter(Guid id)
        {
            var oficina = await _oficinaRepository.Obter(id);

            if (oficina == null)
                return null;

            return new OficinaViewModel
            {
                Id = oficina.Id,
                Nome = oficina.Nome,
                Endereco = oficina.Endereco,
                Descricao = oficina.Descricao,
                Cnpj = oficina.Cnpj,
                Estrelas = oficina.Estrelas
            };
        }

        public async Task<OficinaViewModel> Inserir(OficinaInputModel oficina)
        {
            var entidadeOficina = await _oficinaRepository.Obter(oficina.Nome, oficina.Cnpj);

            if (entidadeOficina.Count > 0)
                throw new OficinaJaCadastradaException();

            var oficinaInsert = new Oficina
            {
                Id = Guid.NewGuid(),
                Nome = oficina.Nome,
                Endereco = oficina.Endereco,
                Descricao = oficina.Descricao,
                Cnpj = oficina.Cnpj
            };

            await _oficinaRepository.Inserir(oficinaInsert);

            return new OficinaViewModel
            {
                Id = oficinaInsert.Id,
                Nome = oficina.Nome,
                Endereco = oficina.Endereco,
                Descricao = oficina.Descricao,
                Cnpj = oficina.Cnpj
            };
        }

        public async Task Atualizar(Guid id, OficinaInputModel oficina)
        {
            var entidadeOficina = await _oficinaRepository.Obter(id);

            if (entidadeOficina == null)
                throw new OficinaNaoCadastradaException();

            entidadeOficina.Nome = oficina.Nome;
            entidadeOficina.Endereco = oficina.Endereco;
            entidadeOficina.Descricao = oficina.Descricao;
            entidadeOficina.Cnpj = oficina.Cnpj;

            await _oficinaRepository.Atualizar(entidadeOficina);
        }

        public async Task Atualizar(Guid id, string descricao)
        {
            var entidadeOficina = await _oficinaRepository.Obter(id);

            if (entidadeOficina == null)
                throw new OficinaNaoCadastradaException();

            entidadeOficina.Descricao = descricao;

            await _oficinaRepository.Atualizar(entidadeOficina);
                
        }
        public async Task Remover(Guid id)
        {
            var oficina = await _oficinaRepository.Obter(id);

            if(oficina == null)
                throw new OficinaNaoCadastradaException();

            await _oficinaRepository.Remover(id);
        }

        public void Dispose()
        {
            _oficinaRepository?.Dispose();
        }

    }
}
