using CarteiraDoInvestidor.Application.Conta.Dto;
using MediatR;

namespace CarteiraDoInvestidor.Application.Conta.Handler.Query
{
    public class GetIdUsuarioQuery : IRequest<GetIdUsuarioQueryResponse>
    {
        public Guid Id { get; set; }

        public GetIdUsuarioQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetIdUsuarioQueryResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public GetIdUsuarioQueryResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
