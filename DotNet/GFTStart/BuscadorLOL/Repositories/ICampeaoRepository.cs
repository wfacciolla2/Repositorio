using BuscadorLOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Repositories
{
    public interface ICampeaoRepository : IDisposable
    {
        Task<List<Campeao>> Obter(int pagina, int quantidade);
        Task<Campeao> Obter(Guid id);
        Task<List<Campeao>> Obter(string nome, string funcao);
        Task Inserir(Campeao campeao);
        Task Atualizar(Campeao campeao);
        Task Remover(Guid id);
    }
}
