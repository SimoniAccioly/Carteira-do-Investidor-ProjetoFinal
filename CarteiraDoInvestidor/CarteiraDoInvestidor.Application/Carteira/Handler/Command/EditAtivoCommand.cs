using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace AtivosDoInvestidor.Application.Ativos.Handler.Command
{
    public class EditAtivoCommand : IRequest<EditAtivoCommandResponse>
    {
        public Guid Id { get; set; }
        public AtivosInputDto Ativos { get; set; }


        public EditAtivoCommand(AtivosInputDto ativos)
        {
            Ativos = ativos;
        }
    }

    public class EditAtivoCommandResponse
    {
        public AtivosOutputDto Ativos { get; set; }

        public EditAtivoCommandResponse(AtivosOutputDto ativos)
        {
            Ativos = ativos;
        }
    }
}
