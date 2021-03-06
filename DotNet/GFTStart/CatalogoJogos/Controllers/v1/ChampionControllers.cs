using CatalogoJogos.Exceptions;
using CatalogoJogos.InputModel;
using CatalogoJogos.Services;
using CatalogoJogos.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogos.Controllers.v1
{
    [Route("api/v1/[controller]")] //Comunicação da API
    [ApiController]
    public class ChampionControllers : ControllerBase
    {
        private readonly IJogoService _jogoService; //Instancia sera feita pelo ASP.NET (automatica)

        public ChampionControllers(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }
        /// <summary>
        /// Buscar todos os jogos de forma paginada
        /// </summary>
        /// <remarks>
        /// Não é possível retornar os jogos sem paginação
        /// </remarks>
        /// <param name="pagina">Indica qual página está sendo consultada. Mínimo 1</param>
        /// <param name="quantidade">Indica a quantidade de reistros por página. Mínimo 1 e máximo 50</param>
        /// <response code="200">Retorna a lista de jogos</response>
        /// <response code="204">Caso não haja jogos</response>  
        
        [HttpGet] //Obter uma lista
        //public async Task<ActionResult<List<JogoViewModel>>> Obter() //Classe Assincrona - melhor performance (estudar concorrencia)
        //{
        //    var result = await jogoService.Obter(1,5);
        //    return Ok(result);
        //}
        public async Task<ActionResult<IEnumerable<JogoViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1,[FromQuery, Range(1,50)] int quantidade = 5)
        {
           
            var jogos = await _jogoService.Obter(pagina, quantidade);
            if (jogos.Count()==0)
                return NoContent();
            
            return Ok(jogos);
        }
        /// <summary>
        /// Buscar um jogo pelo seu Id
        /// </summary>
        /// <param name="idJogo">Id do jogo buscado</param>
        /// <response code="200">Retorna o jogo filtrado</response>
        /// <response code="204">Caso não haja jogo com este id</response>   
        [HttpGet("{idJogo:guid}")] //Obter apenas 1 item da lista pelo id
        public async Task<ActionResult<JogoViewModel>> Obter([FromRoute] Guid idJogo)
        {
            var jogo = await _jogoService.Obter(idJogo);

            if (jogo == null)
                return NoContent();

            return Ok(jogo);
        }
        /// <summary>
        /// Inserir um jogo no catálogo
        /// </summary>
        /// <param name="jogoInputModel">Dados do jogo a ser inserido</param>
        /// <response code="200">Cao o jogo seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um jogo com mesmo nome para a mesma produtora</response>  

        [HttpPost] //Insere um jogo
        public async Task<ActionResult<JogoViewModel>> InserirJogo([FromBody] JogoInputModel jogoInputModel) //Insere e retorna o jogo que foi inserido
       //public async Task<ActionResult<object>> InserirJogo(object jogo) 
        {
            try
            {
                var jogo = await _jogoService.Inserir(jogoInputModel);
                return Ok();
            }
            catch (JogoJaCadastradoException ex)

            {
                return UnprocessableEntity("Já existe um jogo com este nome para esta produtora");
            }
        }

        [HttpPut("{idJogo:guid}")] //Atualiza o jogo
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo,[FromBody] JogoInputModel jogoInputModel)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, jogoInputModel);
                return Ok();
            }
            catch (JogoNaoCadastradoException ex)

            {
                return NotFound("Jogo não existe");
            }
        }

        [HttpPatch("{idJogo:guid}/preco/{preco:double}")] //Atualiza um item especifico do jogo
        public async Task<ActionResult> AtualizarJogo([FromRoute] Guid idJogo,[FromRoute] double preco)
        {
            try
            {
                await _jogoService.Atualizar(idJogo, preco);
                return Ok();
            }
            catch (JogoNaoCadastradoException ex)

            {
                return NotFound("Não existe este jogo");
            }
        }

        [HttpDelete("{idJogo:guid}")] //Deleta um jogo pelo ID
        public async Task<ActionResult> ApagarJogo([FromRoute] Guid idJogo)
        {
            try
            {
                await _jogoService.Remover(idJogo);
                return Ok();
            }
            catch (JogoNaoCadastradoException ex)

            {
                return NotFound("Erro ao apagar, o jogo não existe");
            }

        }
    }
}
