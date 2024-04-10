using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetIdAtivoQuery : IRequest<GetIdAtivoQueryResponse>
    {
        public Guid Id { get; set; }

        public GetIdAtivoQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetIdAtivoQueryResponse
    {
        public AtivosOutputDto Ativos { get; set; }

        public GetIdAtivoQueryResponse(AtivosOutputDto ativos)
        {
            Ativos = ativos;
        }

    }
}
