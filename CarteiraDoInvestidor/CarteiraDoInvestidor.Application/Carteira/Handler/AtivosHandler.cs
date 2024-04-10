using AtivoDoInvestidor.Application.Ativo.Handler.Command;
using AtivosDoInvestidor.Application.Ativos.Handler.Command;
using CarteiraDoInvestidor.Application.Carteira.Handler.Query;
using CarteiraDoInvestidor.Application.Carteira.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler
{
    public class AtivosHandler : IRequestHandler<CreateAtivoCommand, CreateAtivoCommandResponse>, 
                                 IRequestHandler<GetAllAtivoQuery, GetAllAtivoQueryResponse>, 
                                 IRequestHandler<EditAtivoCommand, EditAtivoCommandResponse>, 
                                 IRequestHandler<DeleteAtivoCommand, DeleteAtivoCommandResponse>, 
                                 IRequestHandler<GetIdAtivoQuery, GetIdAtivoQueryResponse>
    {
        private readonly IAtivoService _ativoService;

        public AtivosHandler(IAtivoService ativoService)
        {
            _ativoService = ativoService;
        }

        public async Task<CreateAtivoCommandResponse> Handle(CreateAtivoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._ativoService.Create(request.Ativo);
            return new CreateAtivoCommandResponse(result);
        }

        public async Task<GetAllAtivoQueryResponse> Handle(GetAllAtivoQuery request, CancellationToken cancellationToken)
        {
            var result = await this._ativoService.GetAll();
            return new GetAllAtivoQueryResponse(result);
        }

        public async Task<EditAtivoCommandResponse> Handle(EditAtivoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._ativoService.Edit(request.Ativos);
            return new EditAtivoCommandResponse(result);
        }

        public async Task<DeleteAtivoCommandResponse> Handle(DeleteAtivoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._ativoService.Delete(request.Id);
            return new DeleteAtivoCommandResponse(result);
        }

        public async Task<GetIdAtivoQueryResponse> Handle(GetIdAtivoQuery request, CancellationToken cancellationToken)
        {
           var result = await this._ativoService.GetId(request.Id);
            return new GetIdAtivoQueryResponse(result);
        }
    }
}
