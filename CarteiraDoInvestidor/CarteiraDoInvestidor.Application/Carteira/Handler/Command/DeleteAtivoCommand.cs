using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace AtivosDoInvestidor.Application.Ativos.Handler.Command
{
    public class DeleteAtivoCommand : IRequest<DeleteAtivoCommandResponse>
    {
        public Guid Id { get; set; }

        public DeleteAtivoCommand(Guid id)
        {
            Id = id;
        }
    }

    public class DeleteAtivoCommandResponse
    {
        public AtivosOutputDto Ativos { get; set; }

        public DeleteAtivoCommandResponse(AtivosOutputDto ativos)
        {
            Ativos = ativos;
        }
    }
}
