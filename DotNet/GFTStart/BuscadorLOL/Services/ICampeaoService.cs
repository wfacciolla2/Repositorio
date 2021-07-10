using BuscadorLOL.InputModel;
using BuscadorLOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Services
{
    public interface ICampeaoService : IDisposable
    {
        Task<List<CampeaoViewModel>> Obter(int pagina, int quantidade);
        Task<CampeaoViewModel> Obter(Guid id);
        Task<CampeaoViewModel> Inserir(CampeaoInputModel campeao);
        Task Atualizar(Guid id, CampeaoInputModel campeao);
        Task Atualizar(Guid id, float preco);
        Task Remover(Guid id);

    }
}
