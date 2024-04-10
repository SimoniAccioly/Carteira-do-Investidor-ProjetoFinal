using AtivoDoInvestidor.Application.Ativo.Handler.Command;
using AtivosDoInvestidor.Application.Ativos.Handler.Command;
using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Application.Carteira.Handler.Query;
using CarteiraDoInvestidor.Domain.Carteira;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarteiraDoInvestidor.API.Controllers
{
    [ApiController]
    public class AtivosController : ControllerBase
    {
        private readonly IMediator mediator;

        public AtivosController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("ativos/obter-todos")]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.mediator.Send(new GetAllAtivoQuery());
            return Ok(result);
        }

        [HttpPost()]
        [Route("ativos/criar")]
        public async Task<IActionResult> Create(AtivosInputDto dto)
        {
            var result = await this.mediator.Send(new CreateAtivoCommand(dto));
            return Ok(result);

        }

        [HttpGet]
        [Route("ativos/obter-por-id/{id}")]
        public async Task<IActionResult> GetId(Guid id)
        {
            var result = await this.mediator.Send(new GetIdAtivoQuery(id));
            return Ok(result);
        }

        [HttpPut]
        [Route("ativos/editar/{id}")]
        public async Task<IActionResult> Edit([FromBody] AtivosInputDto dto)
        {
            var result = await this.mediator.Send(new EditAtivoCommand(dto));
            return Ok(result);
        }

        [HttpDelete]
        [Route("ativos/excluir/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await this.mediator.Send(new DeleteAtivoCommand(id));
            return Ok(result);
        }
    }
}
