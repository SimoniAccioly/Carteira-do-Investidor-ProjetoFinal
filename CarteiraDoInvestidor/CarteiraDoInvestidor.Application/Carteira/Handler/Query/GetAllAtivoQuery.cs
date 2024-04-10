using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetAllAtivoQuery : IRequest<GetAllAtivoQueryResponse>
    {

    }

    public class GetAllAtivoQueryResponse
    {
        public IList<AtivosOutputDto> Ativos { get; set; }

        public GetAllAtivoQueryResponse(IList<AtivosOutputDto> ativos)
        {
            Ativos = ativos;
        }
    }
}
