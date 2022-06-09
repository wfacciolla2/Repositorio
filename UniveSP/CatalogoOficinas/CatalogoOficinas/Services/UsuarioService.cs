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
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<UsuarioViewModel>> Obter(int pagina, int quantidade)
        {
            var usuarios = await _usuarioRepository.Obter(pagina, quantidade);

            return usuarios.Select(usuario => new UsuarioViewModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Cpf = usuario.Cpf,
                Nasc = usuario.Nasc,
                Telefone = usuario.Telefone,
                Status = usuario.Status
            }).ToList();
        }

        public async Task<UsuarioViewModel> Obter(Guid id)
        {
            var usuario = await _usuarioRepository.Obter(id);

            if (usuario == null)
                return null;

            return new UsuarioViewModel
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Cpf = usuario.Cpf,
                Nasc = usuario.Nasc,
                Telefone = usuario.Telefone,
                Status = usuario.Status
            };
        }

        public async Task<UsuarioViewModel> Inserir(UsuarioInputModel usuario)
        {
            var entidadeUsuario = await _usuarioRepository.Obter(usuario.Nome, usuario.Cpf);

            if (entidadeUsuario.Count > 0)
                throw new UsuarioJaCadastradoException();

            var usuarioInsert = new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = usuario.Nome,
                Email = usuario.Email,
                Cpf = usuario.Cpf,
                Nasc = usuario.Nasc,
                Telefone = usuario.Telefone,
                Status = usuario.Status
            };

            await _usuarioRepository.Inserir(usuarioInsert);

            return new UsuarioViewModel
            {
                Id = usuarioInsert.Id,
                Nome = usuario.Nome,
                Email = usuario.Email,
                Cpf = usuario.Cpf,
                Nasc = usuario.Nasc,
                Telefone = usuario.Telefone,
                Status = usuario.Status
            };
        }

        public async Task Atualizar(Guid id, UsuarioInputModel usuario)
        {
            var entidadeUsuario = await _usuarioRepository.Obter(id);

            if (entidadeUsuario == null)
                throw new UsuarioNaoCadastradoException();

            entidadeUsuario.Nome = usuario.Nome;
            entidadeUsuario.Email = usuario.Email;
            entidadeUsuario.Cpf = usuario.Cpf;
            entidadeUsuario.Nasc = usuario.Nasc;
            entidadeUsuario.Telefone = usuario.Telefone;
            entidadeUsuario.Status = usuario.Status;

            await _usuarioRepository.Atualizar(entidadeUsuario);
        }

        public async Task Atualizar(Guid id, string status)
        {
            var entidadeUsuario = await _usuarioRepository.Obter(id);

            if (entidadeUsuario == null)
                throw new UsuarioNaoCadastradoException();

            entidadeUsuario.Status = status;

            await _usuarioRepository.Atualizar(entidadeUsuario);

        }
        public async Task Remover(Guid id)
        {
            var usuario = await _usuarioRepository.Obter(id);

            if (usuario == null)
                throw new UsuarioNaoCadastradoException();

            await _usuarioRepository.Remover(id);
        }

        public void Dispose()
        {
            _usuarioRepository?.Dispose();
        }

    }
}
