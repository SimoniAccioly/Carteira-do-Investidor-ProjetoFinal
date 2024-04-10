using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Command
{
    public class DeleteCarteiraCommand : IRequest<DeleteCarteiraCommandResponse>
    {
        public Guid Id { get; set; }

        public DeleteCarteiraCommand(Guid id)
        {
            Id = id;
        }
    }

    public class DeleteCarteiraCommandResponse
    {
        public CarteiraOutputDto Carteira { get; set; }

        public DeleteCarteiraCommandResponse(CarteiraOutputDto carteira)
        {
            Carteira = carteira;
        }
    }
}
