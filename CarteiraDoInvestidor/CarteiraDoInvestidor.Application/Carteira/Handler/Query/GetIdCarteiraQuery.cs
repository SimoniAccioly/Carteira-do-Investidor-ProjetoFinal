using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetIdCarteiraQuery : IRequest<GetIdCarteiraQueryResponse>
    {
        public Guid Id { get; set; }

        public GetIdCarteiraQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetIdCarteiraQueryResponse
    {
        public CarteiraOutputDto Carteira { get; set; }

        public GetIdCarteiraQueryResponse(CarteiraOutputDto carteira)
        {
            Carteira = carteira;
        }

    }
}
