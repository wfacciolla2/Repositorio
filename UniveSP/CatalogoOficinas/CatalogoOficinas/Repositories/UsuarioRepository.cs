using CatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static Dictionary<Guid, Usuario> usuarios = new Dictionary<Guid, Usuario>()
        {
            {Guid.Parse("8185d868-dd94-4ebb-ab0c-5f3581af329e"), new Usuario{ Id = Guid.Parse("8185d868-dd94-4ebb-ab0c-5f3581af329e"), Nome = "Wellington", Email = "facciollacorp@gmail.com", Cpf = "405.158.318.08", Nasc = "07/05/1990", Telefone = "12988830267", Status = "Ativo" } }
        };

        public Task<List<Usuario>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(usuarios.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Usuario> Obter(Guid id)
        {
            if (!usuarios.ContainsKey(id))
                return null;

            return Task.FromResult(usuarios[id]);
        }

        public Task<List<Usuario>> Obter(string nome, string cpf)
        {
            return Task.FromResult(usuarios.Values.Where(usuario => usuario.Nome.Equals(nome) && usuario.Cpf.Equals(cpf)).ToList());
        }
        public Task<List<Usuario>> ObterSemLambda(string nome, string cpf)
        {
            var retorno = new List<Usuario>();

            foreach (var usuario in usuarios.Values)
            {
                if (usuario.Nome.Equals(nome) && usuario.Cpf.Equals(cpf))
                    retorno.Add(usuario);
            }

            return Task.FromResult(retorno);
        }

        public Task Inserir(Usuario usuario)
        {
            usuarios.Add(usuario.Id, usuario);
            return Task.CompletedTask;
        }

        public Task Atualizar(Usuario usuario)
        {
            usuarios[usuario.Id] = usuario;
            return Task.CompletedTask;
        }

        public Task Remover(Guid id)
        {
            usuarios.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }
    }
}
