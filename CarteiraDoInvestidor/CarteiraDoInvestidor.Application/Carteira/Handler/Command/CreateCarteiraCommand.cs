using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Command
{
    public class CreateCarteiraCommand : IRequest<CreateCarteiraCommandResponse>
    {
        public CarteiraInputDto Carteira { get; set; }

        public CreateCarteiraCommand(CarteiraInputDto carteira)
        {
            Carteira = carteira;
        }
    }

    public class CreateCarteiraCommandResponse
    {
        public CarteiraOutputDto Carteira { get; set; }

        public CreateCarteiraCommandResponse(CarteiraOutputDto carteira)
        {
            Carteira = carteira;
        }
    }
}
