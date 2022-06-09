using ApiCatalogoOficinas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Repository
{
    public interface IOficinaRepository : IDisposable
    {
        Task<List<Oficina>> Obter(int pagina, int quantidade);
        Task<Oficina> Obter(Guid id);
        Task<List<Oficina>> Obter(string nome, string descricao);
        Task Inserir(Oficina oficina);
        Task Atualizar(Oficina oficina);
        Task Remover(Guid id);
    }
}
