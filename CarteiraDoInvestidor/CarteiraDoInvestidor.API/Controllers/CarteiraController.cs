using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Application.Carteira.Handler.Command;
using CarteiraDoInvestidor.Application.Carteira.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarteiraDoInvestidor.API.Controllers
{
    [ApiController]
    public class CarteiraController : ControllerBase
    {
        private readonly IMediator mediator;

        public CarteiraController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("carteira/obter-todos")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await this.mediator.Send(new GetAllCarteiraQuery()));
        }

        [HttpGet]
        [Route("carteira/obter-por-id/{id}")]
        public async Task<IActionResult> GetId(Guid id)
        {
            return Ok(await this.mediator.Send(new GetIdCarteiraQuery(id)));
        }

        [HttpPost]
        [Route("carteira/criar")]
        public async Task<IActionResult> Create(CarteiraInputDto dto)
        {
            var result = await this.mediator.Send(new CreateCarteiraCommand(dto));
            return Created($"{result.Carteira.Id}", result.Carteira);
        }

        [HttpPut]
        [Route("carteira/editar/{id}")]
        public async Task<IActionResult> Edit([FromBody] CarteiraInputDto dto)
        {
            var result = await this.mediator.Send(new EditCarteiraCommand(dto));
            return Ok(result);
        }

        [HttpDelete]
        [Route("carteira/excluir/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await this.mediator.Send(new DeleteCarteiraCommand(id));
            return Ok(result);
        }
    }
}
