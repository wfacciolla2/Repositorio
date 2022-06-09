using CatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Repositories
{
    public interface IOficinaRepository : IDisposable
    {
        Task<List<Oficina>> Obter(int pagina, int quantidade);
        Task<Oficina> Obter(Guid id);
        Task<List<Oficina>> Obter(string nome, string cnpj);
        Task Inserir(Oficina oficina);
        Task Atualizar(Oficina oficina);
        Task Remover(Guid id);
    }
}
