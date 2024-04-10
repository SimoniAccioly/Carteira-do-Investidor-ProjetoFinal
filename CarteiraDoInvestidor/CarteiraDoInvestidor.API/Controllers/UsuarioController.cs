using CarteiraDoInvestidor.Application.Conta.Dto;
using CarteiraDoInvestidor.Application.Conta.Handler.Command;
using CarteiraDoInvestidor.Application.Conta.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarteiraDoInvestidor.API.Controllers
{
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator mediator;

        public UsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("usuario/obter-todos")]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await this.mediator.Send(new GetAllUsuarioQuery()));
        }

        [HttpGet]
        [Route("usuario/obter-por-id/{id}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            return Ok(await this.mediator.Send(new GetIdUsuarioQuery(id)));
        }

        [HttpPost]
        [Route("usuario/criar")]
        public async Task<IActionResult> Criar(UsuarioInputDto dto)
        {
            var result = await this.mediator.Send(new CreateUsuarioCommand(dto));
            return Created($"{result.Usuario.Id}", result.Usuario);
        }

        [HttpPut]
        [Route("usuario/editar/{id}")]
        public async Task<IActionResult> Editar([FromBody] UsuarioInputDto dto)
        {
            var result = await this.mediator.Send(new EditUsuarioCommand(dto));
            return Ok(result);
        }

        [HttpDelete]
        [Route("usuario/excluir/{id}")]
        public async Task<IActionResult> Excluir(Guid id)
        {
            var result = await this.mediator.Send(new DeleteUsuarioCommand(id));
            return Ok(result);
        }
    }
}
