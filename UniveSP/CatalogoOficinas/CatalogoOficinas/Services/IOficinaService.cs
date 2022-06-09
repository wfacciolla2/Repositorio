using CatalogoOficinas.InputModel;
using CatalogoOficinas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Services
{
    public interface IOficinaService : IDisposable
    {
        Task<List<OficinaViewModel>> Obter(int pagina, int quantidade);
        Task<OficinaViewModel> Obter(Guid id);
        Task<OficinaViewModel> Inserir(OficinaInputModel oficina);
        Task Atualizar(Guid id, OficinaInputModel oficina);
        Task Atualizar(Guid id, string descricao);
        Task Remover(Guid id);
    }
}
