using CatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Repositories
{
    public interface IUsuarioRepository : IDisposable
    {
        Task<List<Usuario>> Obter(int pagina, int quantidade);
        Task<Usuario> Obter(Guid id);
        Task<List<Usuario>> Obter(string nome, string cpf);
        Task Inserir(Usuario usuario);
        Task Atualizar(Usuario usuario);
        Task Remover(Guid id);
    }
}
