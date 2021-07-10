using BuscadorLOL.Entities;
using BuscadorLOL.Exceptions;
using BuscadorLOL.InputModel;
using BuscadorLOL.Repositories;
using BuscadorLOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Services
{
    public class CampeaoService : ICampeaoService
    {
        private readonly ICampeaoRepository _campeaoRepository;

        public CampeaoService(ICampeaoRepository campeaoRepository)
        {
            _campeaoRepository = campeaoRepository;
        }

        public async Task<List<CampeaoViewModel>> Obter(int pagina, int quantidade)
        {
            var campeoes = await _campeaoRepository.Obter(pagina, quantidade);

            return campeoes.Select(campeao => new CampeaoViewModel
            {
                Id = campeao.Id,
                Nome = campeao.Nome,
                Funcao = campeao.Funcao,
                Preco = campeao.Preco
            }).ToList();
        }

        public async Task<CampeaoViewModel> Obter(Guid id)
        {
            var campeao = await _campeaoRepository.Obter(id);

            if (campeao == null)
                return null;

            return new CampeaoViewModel
            {
                Id = campeao.Id,
                Nome = campeao.Nome,
                Funcao = campeao.Funcao,
                Preco = campeao.Preco
            };
        }

        public async Task<CampeaoViewModel> Inserir(CampeaoInputModel campeao)
        {
            var entidadeCampeao = await _campeaoRepository.Obter(campeao.Nome, campeao.Funcao);

            if (entidadeCampeao.Count > 0)
                throw new CampeaoJaCadastradoException();

            var campeaoInsert = new Campeao
            {
                Id = Guid.NewGuid(),
                Nome = campeao.Nome,
                Funcao = campeao.Funcao,
                Preco = campeao.Preco
            };

            await _campeaoRepository.Inserir(campeaoInsert);

            return new CampeaoViewModel
            {
                Id = campeaoInsert.Id,
                Nome = campeao.Nome,
                Funcao = campeao.Funcao,
                Preco = campeao.Preco
            };
        }

        public async Task Atualizar(Guid id, CampeaoInputModel campeao)
        {
            var entidadeCampeao = await _campeaoRepository.Obter(id);

            if (entidadeCampeao == null)
                throw new CampeaoNaoCadastradoException();

            entidadeCampeao.Nome = campeao.Nome;
            entidadeCampeao.Funcao = campeao.Funcao;
            entidadeCampeao.Preco = campeao.Preco;

            await _campeaoRepository.Atualizar(entidadeCampeao);
        }

        public async Task Atualizar(Guid id, float preco)
        {
            var entidadeCampeao = await _campeaoRepository.Obter(id);

            if (entidadeCampeao == null)
                throw new CampeaoNaoCadastradoException();

            entidadeCampeao.Preco = preco;

            await _campeaoRepository.Atualizar(entidadeCampeao);
        }

        public async Task Remover(Guid id)
        {
            var campeao = _campeaoRepository.Obter(id);

            if (campeao == null)
                throw new CampeaoNaoCadastradoException();

            await _campeaoRepository.Remover(id);
        }

        public void Dispose()
        {
            _campeaoRepository?.Dispose();
        }
    }
}
