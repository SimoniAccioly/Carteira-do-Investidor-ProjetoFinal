using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Application.Carteira.Handler.Command;
using CarteiraDoInvestidor.Application.Carteira.Handler.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarteiraDoInvestidor.API.Controllers
{
    [ApiController]
    public class ArquivosExcelController : ControllerBase
    {
        private readonly IMediator mediator;

        public ArquivosExcelController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("arquivos/obter-todos")]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.mediator.Send(new GetAllArquivosExcelQuery());
            return Ok(result);
        }

        [HttpPost()]
        [Route("arquivos/criar")]
        public async Task<IActionResult> Create(ArquivoExcelInputDto dto)
        {
            var result = await this.mediator.Send(new CreateArquivoExcelCommand(dto));
            return Ok(result);

        }
    }
}
