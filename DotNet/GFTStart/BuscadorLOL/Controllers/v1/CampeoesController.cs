using BuscadorLOL.Exceptions;
using BuscadorLOL.InputModel;
using BuscadorLOL.Services;
using BuscadorLOL.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BuscadorLOL.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CampeoesController : ControllerBase
    {
        private readonly ICampeaoService _campeaoService;

        public CampeoesController(ICampeaoService campeaoService)
        {
            _campeaoService = campeaoService;
        }
        /// <summary>
        /// Buscar todos os Campeões de forma paginada
        /// </summary>
        /// <remarks>
        /// Não é possível retornar os jogos sem paginação
        /// </remarks>
        /// <param name="pagina">Indica qual página está sendo consultada. Mínimo 1</param>
        /// <param name="quantidade">Indica a quantidade de reistros por página. Mínimo 1 e máximo 50</param>
        /// <response code="200">Retorna a lista de Campeões</response>
        /// <response code="204">Caso não haja Campões</response> 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CampeaoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1,[FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var campeoes = await _campeaoService.Obter(pagina, quantidade);

            if (campeoes.Count() == 0)
                return NoContent();

            return Ok(campeoes);
        }
        /// <summary>
        /// Buscar um Campeão pelo seu Id
        /// </summary>
        /// <param name="idCampeao">Id do Campeão buscado</param>
        /// <response code="200">Retorna o Campeão filtrado</response>
        /// <response code="204">Caso não haja Campeão com este id</response> 
        [HttpGet("{idCampeao:guid}")]
        public async Task<ActionResult<CampeaoViewModel>> Obter([FromRoute] Guid idCampeao)
        {
            var campeao = await _campeaoService.Obter(idCampeao);
            if (campeao == null)
                return NoContent();

            return Ok(campeao);
        }
        /// <summary>
        /// Inserir um Campeão no catálogo
        /// </summary>
        /// <param name="jogoInputModel">Dados do Campeão a ser inserido</param>
        /// <response code="200">Cao o Campeão seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um Campeão com mesmo nome para a mesma Função</response>   
        [HttpPost]
        public async Task<ActionResult<CampeaoViewModel>> InserirCampeao([FromBody] CampeaoInputModel campeaoInputModel)
        {
            try
            {
                var campeao = await _campeaoService.Inserir(campeaoInputModel);
                return Ok(campeao);
            }
            catch (CampeaoJaCadastradoException ex)

            {
                return UnprocessableEntity("Já existe um Campeão cadastrado com esse nome e função");
            }
        }
        /// <summary>
        /// Atualizar um Campeão no catálogo
        /// </summary>
        /// /// <param name="idCampeao">Id do Campeão a ser atualizado</param>
        /// <param name="campeaoInputModel">Novos dados para atualizar o Campeão indicado</param>
        /// <response code="200">Cao o Campeão seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um Campeão com este Id</response>  
        [HttpPut("{idCampeao:guid}")]
        public async Task<ActionResult> AtualizarCampeao([FromRoute]Guid idCampeao, [FromBody] CampeaoInputModel campeaoInputModel)
        {
            try
            {
                await _campeaoService.Atualizar(idCampeao, campeaoInputModel);
                return Ok(campeaoInputModel);
            }
            catch (CampeaoJaCadastradoException ex)
            {
                return NotFound("Não existe Campeão cadastrado com esse nome");
            }
        }

        /// <summary>
        /// Atualizar o preço de um Campeão
        /// </summary>
        /// /// <param name="idCampeao">Id do Campeão a ser atualizado</param>
        /// <param name="preco">Novo preço do Campeão</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um Campeão com este Id</response>   
        [HttpPatch("{idCampeao:guid}/preco/{preco:float}")]
        public async Task<ActionResult> AtualizarCampeao([FromRoute] Guid idCampeao, [FromRoute] float preco)
        {
            try
            {
                await _campeaoService.Atualizar(idCampeao, preco);
                return Ok(preco);
            }
            catch (CampeaoNaoCadastradoException ex)
            {
                return NotFound("Não existe Campeão cadastrado com esse nome");
            }
        }
        /// <summary>
        /// Excluir um Campeão
        /// </summary>
        /// /// <param name="idCampeao">Id do Campeão a ser excluído</param>
        /// <response code="200">Cao o preço seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um Campeão com este Id</response>   
        [HttpDelete("{idCampeao:guid}")]
        public async Task<ActionResult> apagarCampeao([FromRoute] Guid idCampeao)
        {
            try
            {
                await _campeaoService.Remover(idCampeao);
                return Ok();
            }
            //catch (CampeaoNaoCadastradoException ex)
            catch (Exception ex)
            {
                return NotFound("Não existe Campeão cadastrado com esse nome");
            }
        }
    }
}
