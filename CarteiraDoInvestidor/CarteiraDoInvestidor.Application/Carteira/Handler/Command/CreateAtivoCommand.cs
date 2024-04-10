using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace AtivoDoInvestidor.Application.Ativo.Handler.Command
{
    public class CreateAtivoCommand : IRequest<CreateAtivoCommandResponse>
    {
        public AtivosInputDto Ativo { get; set; }

        public CreateAtivoCommand(AtivosInputDto ativos)
        {
            Ativo = ativos;
        }
    }

    public class CreateAtivoCommandResponse
    {
        public AtivosOutputDto Ativo { get; set; }

        public CreateAtivoCommandResponse(AtivosOutputDto ativos)
        {
            Ativo = ativos;
        }
    }
}

