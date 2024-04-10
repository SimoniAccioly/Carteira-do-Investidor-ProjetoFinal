using CarteiraDoInvestidor.Application.Conta.Handler.Command;
using CarteiraDoInvestidor.Application.Conta.Handler.Query;
using CarteiraDoInvestidor.Application.Conta.Service;
using MediatR;

namespace CarteiraDoInvestidor.Application.Conta.Handler
{
    public class UsuarioHandler : IRequestHandler<CreateUsuarioCommand, CreateUsuarioCommandResponse>,
                                  IRequestHandler<EditUsuarioCommand, EditUsuarioCommandResponse>,
                                  IRequestHandler<DeleteUsuarioCommand, DeleteUsuarioCommandResponse>,
                                  IRequestHandler<GetAllUsuarioQuery, GetAllUsuarioQueryResponse>,
                                  IRequestHandler<GetIdUsuarioQuery, GetIdUsuarioQueryResponse>

    {
        private readonly IUsuarioService usuarioService;

        public UsuarioHandler(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        public async Task<CreateUsuarioCommandResponse> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await usuarioService.Create(request.Usuario);

            return new CreateUsuarioCommandResponse(result);
        }

        public async Task<EditUsuarioCommandResponse> Handle(EditUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await usuarioService.Edit(request.Id, request.Usuario);

            return new EditUsuarioCommandResponse(result);
        }

        public async Task<DeleteUsuarioCommandResponse> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = await usuarioService.Delete(request.Id);

            return new DeleteUsuarioCommandResponse(result);
        }

        public async Task<GetAllUsuarioQueryResponse> Handle(GetAllUsuarioQuery request, CancellationToken cancellationToken)
        {
            var result = await usuarioService.GetAll();

            return new GetAllUsuarioQueryResponse(result);
        }

        public async Task<GetIdUsuarioQueryResponse> Handle(GetIdUsuarioQuery request, CancellationToken cancellationToken)
        {
            var result = await usuarioService.GetId(request.Id);

            return new GetIdUsuarioQueryResponse(result);
        }
    }

   
}
