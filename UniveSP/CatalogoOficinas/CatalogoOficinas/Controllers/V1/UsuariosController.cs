using CatalogoOficinas.Entities;
using CatalogoOficinas.Exceptions;
using CatalogoOficinas.InputModel;
using CatalogoOficinas.Services;
using CatalogoOficinas.ViewModel;
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
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioViewModel>>> Obter([FromQuery, Range(1, int.MaxValue)] int pagina = 1, [FromQuery, Range(1, 50)] int quantidade = 5)
        {
            var usuarios = await _usuarioService.Obter(pagina, quantidade);
            if (usuarios.Count() == 0)
                return NoContent();

            return Ok(usuarios);
        }

        [HttpGet("{idUsuario:guid}")]
        public async Task<ActionResult<UsuarioViewModel>> Obter([FromRoute] Guid idUsuario)
        {
            var usuario = await _usuarioService.Obter(idUsuario);
            if (usuario == null)
                return NoContent();

            return Ok(usuario);
        }
        [HttpPost]
        public async Task<ActionResult<UsuarioViewModel>> InserirUsuario([FromBody] UsuarioInputModel usuarioInputModel)
        {
            try
            {
                var usuario = await _usuarioService.Inserir(usuarioInputModel);

                return Ok(usuario);
            }
            catch (UsuarioJaCadastradoException ex)
            {
                return UnprocessableEntity("Este Usuario já existe");
            }
        }
        [HttpPut("{idUsuario:guid}")]
        public async Task<ActionResult> AtualizarUsuario([FromRoute] Guid idUsuario, [FromBody] UsuarioInputModel usuarioInputModel)
        {
            try
            {
                await _usuarioService.Atualizar(idUsuario, usuarioInputModel);
                return Ok();
            }
            catch (UsuarioNaoCadastradoException ex)
            {
                return NotFound("Usuário inexistente");
            }
        }
        [HttpPatch("{idUsuario:guid}/status/{status}")]
        public async Task<ActionResult> AtualizarUsuario([FromRoute] Guid idUsuario, [FromRoute] string status)
        {
            try
            {
                await _usuarioService.Atualizar(idUsuario, status);

                return Ok();
            }
            catch (UsuarioNaoCadastradoException ex)
            {
                return NotFound("Usuário não cadastrado");
            }
        }
        [HttpDelete("{idUsuario:guid}")]
        public async Task<ActionResult> ApagarUsuario([FromRoute] Guid Usuario)
        {
            try
            {
                await _usuarioService.Remover(Usuario);
                return Ok();
            }
            catch (UsuarioNaoCadastradoException ex)
            {
                return NotFound("Usuário não cadastrado");
            }
        }

    }
}
