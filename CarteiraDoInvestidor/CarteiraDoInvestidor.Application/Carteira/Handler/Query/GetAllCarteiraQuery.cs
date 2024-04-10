using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetAllCarteiraQuery : IRequest<GetAllCarteiraQueryResponse>
    {
    }

    public class GetAllCarteiraQueryResponse
    {

        public IList<CarteiraOutputDto> Carteira { get; set; }

        public GetAllCarteiraQueryResponse(IList<CarteiraOutputDto> carteira)
        {
            this.Carteira = carteira;
        }
    }
}
