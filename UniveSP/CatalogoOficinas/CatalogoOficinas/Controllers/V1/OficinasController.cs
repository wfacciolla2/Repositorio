using CatalogoOficinas.Exceptions;
using CatalogoOficinas.InputModel;
using CatalogoOficinas.Services;
using CatalogoOficinas.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoOficinas.Controllers.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class OficinasController : ControllerBase
    {
        private readonly IOficinaService _oficinaService;
        public OficinasController(IOficinaService oficinaService)
        {
            _oficinaService = oficinaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OficinaViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var oficinas = await _oficinaService.Obter(pagina, quantidade);
            if (oficinas.Count() == 0)
                return NoContent();

            return Ok(oficinas);
        }

        [HttpGet("{idOficina:guid}")]
        public async Task<ActionResult<OficinaViewModel>> Obter([FromRoute]Guid idOficina)
        {
            var oficina = await _oficinaService.Obter(idOficina);
            if (oficina == null)
                return NoContent();

            return Ok(oficina);
        }
        [HttpPost]
        public async Task<ActionResult<OficinaViewModel>> InserirOficina([FromBody]OficinaInputModel oficinaInputModel)
        {
            try
            {
                var oficina = await _oficinaService.Inserir(oficinaInputModel);

                return Ok(oficina);
            }
            catch (OficinaJaCadastradaException ex)
            
            {
                return UnprocessableEntity("Esta Oficina já existe");
            }
        }
        [HttpPut("{idOficina:guid}")]
        public async Task<ActionResult> AtualizarOficina([FromRoute]Guid idOficina, [FromBody]OficinaInputModel oficinaInputModel)
        {
            try
            {
                await _oficinaService.Atualizar(idOficina, oficinaInputModel);
                return Ok();
            }
            catch (OficinaNaoCadastradaException ex)
            
            {
                return NotFound("Não existe essa Oficina");
            }
        }
        [HttpPatch("{idOficina:guid}/descricao/{descricao}")]
        public async Task<ActionResult> AtualizarOficina([FromRoute]Guid idOficina,[FromRoute] string descricao)
        {
            try
            {
                await _oficinaService.Atualizar(idOficina, descricao);

                return Ok();            
            }
            catch (OficinaNaoCadastradaException ex)
            
            {
                return NotFound("Não existe essa Oficina");
            }
        }
    
        [HttpDelete("{idOficina:guid}")]
        public async Task<ActionResult> ApagarOficina([FromRoute]Guid idOficina)
        {
            try
            {
                await _oficinaService.Remover(idOficina);
                return Ok();
            }
            catch (OficinaNaoCadastradaException ex)
            {
                return NotFound("Não existe essa Oficina");
            }
        }
    }
}
