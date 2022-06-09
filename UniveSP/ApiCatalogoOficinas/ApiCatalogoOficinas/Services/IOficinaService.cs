using ApiCatalogoOficinas.InputModel;
using ApiCatalogoOficinas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Services
{
    public interface IOficinaService : IDisposable //interface para injeção de dependencias e garantia de código.
    {
        Task<List<OficinaViewModel>> Obter(int pagina, int quantidade); //Obter uma lista de oficinas
        Task<OficinaViewModel> Obter(Guid Id); //Obter uma oficina
        Task<OficinaViewModel> Inserir(OficinaInputModel oficina); //Inserir uma oficina
        Task Atualizar(Guid id, OficinaViewModel oficina); //Atualização completa de um cadastro de oficina
        Task Atualizar(Guid id, string descricao); //Atualizar a descrição da oficina
        Task Deletar(Guid id); //Deletar uma oficina
        Task Atualizar(Guid idOficina, OficinaInputModel oficinaInputModel);
    }
}
