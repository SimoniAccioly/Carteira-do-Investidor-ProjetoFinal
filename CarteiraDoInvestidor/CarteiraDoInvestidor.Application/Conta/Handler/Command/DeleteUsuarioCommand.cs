using CarteiraDoInvestidor.Application.Conta.Dto;
using MediatR;

namespace CarteiraDoInvestidor.Application.Conta.Handler.Command
{
    public class DeleteUsuarioCommand : IRequest<DeleteUsuarioCommandResponse>
    {
        public Guid Id { get; set; }

        public DeleteUsuarioCommand(Guid id)
        {
            Id = id;
        }
    }

    public class DeleteUsuarioCommandResponse
    {
        public UsuarioOutputDto Usuario { get; set; }

        public DeleteUsuarioCommandResponse(UsuarioOutputDto usuario)
        {
            Usuario = usuario;
        }
    }
}
