using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Command
{
    public class EditCarteiraCommand : IRequest<EditCarteiraCommandResponse>
    {
        public Guid Id { get; set; }
        public CarteiraInputDto Carteira { get; set; }


        public EditCarteiraCommand(CarteiraInputDto carteira)
        {
            Carteira = carteira;
        }
    }

    public class EditCarteiraCommandResponse
    {
        public CarteiraOutputDto Carteira { get; set; }

        public EditCarteiraCommandResponse(CarteiraOutputDto carteira)
        {
            Carteira = carteira;
        }
    }
}
