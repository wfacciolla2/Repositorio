using CatalogoOficinas.InputModel;
using CatalogoOficinas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Services
{
    public interface IUsuarioService : IDisposable
    {
        Task<List<UsuarioViewModel>> Obter(int pagina, int quantidade);
        Task<UsuarioViewModel> Obter(Guid id);
        Task<UsuarioViewModel> Inserir(UsuarioInputModel usuario);
        Task Atualizar(Guid id, UsuarioInputModel usuario);
        Task Atualizar(Guid id, string status);
        Task Remover(Guid id);
    }
}
