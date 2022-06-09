using ApiCatalogoOficinas.Exceptions;
using ApiCatalogoOficinas.InputModel;
using ApiCatalogoOficinas.Services;
using ApiCatalogoOficinas.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoOficinas.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OficinasController : ControllerBase
    {

        private readonly IOficinaService _oficinaService; //Propriedade para o constructor

        public OficinasController(IOficinaService oficinaService) //Construtor (instancia o IOficinaService).
        {
            _oficinaService = oficinaService;
        }

        [HttpGet] //Método e busca geral, retorna todos os itens do catalogo e delimita o numero de resultados por paginas 
        public async Task<ActionResult<IEnumerable<OficinaViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1,50)] int quantidade = 5)
        {
            var oficinas = await _oficinaService.Obter(pagina, quantidade);
            if (oficinas.Count() == 0)
                return NoContent();

            return Ok(oficinas);
        }

        [HttpGet("{idOficina:guid}")] //Método de busca unitario pela rota, retorna apenas 1 item do catalogo que pela struct guid (o guid gera um valor aletório e unico)
        public async Task<ActionResult<List<OficinaViewModel>>> Obter([FromRoute] Guid idOficina)
        {
            var oficina = await _oficinaService.Obter(idOficina);
            if (oficina == null)
                return NoContent();

            return Ok(oficina);
        }

        [HttpPost] //Permite a inserção de novos cadastros de oficinas
        public async Task<ActionResult<OficinaViewModel>> InserirOficina([FromBody]OficinaInputModel oficinaInputModel)//Pipeline do APS NET Core trasforma o JSON em DTO. 
        {
            try
            {
                var oficina = await _oficinaService.Inserir(oficinaInputModel);
                return Ok(oficina);
            }
            catch (OficinaJaCadastradaException ex)
            {
                return UnprocessableEntity("Já existe uma oficina com este nome.");
            }
        }

        [HttpPut("{idOficina:guid}")] //Permite atualizar o cadastro inteiro de uma oficina.
        public async Task<ActionResult> AtualizarOficina([FromRoute]Guid idOficina, [FromBody] OficinaInputModel oficinaInputModel)
        {
            try
            {
                await _oficinaService.Atualizar(idOficina, oficinaInputModel);
                return Ok();
            }
            catch (OficinaNaoCadastradaException ex)
            {
                return NotFound("Esta Oficina não existe");
            }
        }

        [HttpPatch("{idOficina:guid}/descricao/{descricao:string}")] //Permite atualizar um item do cadastro de uma oficina (Neste caso a descrição da oficina).
        public async Task<ActionResult> AtualizarOficina([FromRoute]Guid idOficina, [FromRoute]string descricao)
        {
            try
            {
                await _oficinaService.Atualizar(idOficina, descricao);
                return Ok();
            }
            catch (OficinaNaoCadastradaException ex)
            {
                return NotFound("Esta Oficina não existe");
            }
        }
        [HttpDelete("{idOficina:guid")] //Metodo responsavel por remover o cadastro de uma oficina.
        public async Task<ActionResult> ApagarOficina([FromRoute] Guid idOficina)
        {
            try
            {
                await _oficinaService.Deletar(idOficina);
                return Ok();
            }
            catch (OficinaNaoCadastradaException ex)
            {
                return NotFound("Esta Oficina não existe");
            }
        }
    }
}
