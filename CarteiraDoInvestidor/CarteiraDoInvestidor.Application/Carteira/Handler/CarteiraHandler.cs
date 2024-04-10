using CarteiraDoInvestidor.Application.Carteira.Handler.Command;
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
    public class CarteiraHandler : IRequestHandler<CreateCarteiraCommand, CreateCarteiraCommandResponse>,
                                IRequestHandler<EditCarteiraCommand, EditCarteiraCommandResponse>,
                                IRequestHandler<DeleteCarteiraCommand, DeleteCarteiraCommandResponse>,
                                IRequestHandler<GetAllCarteiraQuery, GetAllCarteiraQueryResponse>,
                                IRequestHandler<GetIdCarteiraQuery, GetIdCarteiraQueryResponse>
    {

        private readonly ICarteiraService _carteiraService;

        public CarteiraHandler(ICarteiraService carteiraService)
        {
            _carteiraService = carteiraService;
        }

        public async Task<GetAllCarteiraQueryResponse> Handle(GetAllCarteiraQuery request, CancellationToken cancellationToken)
        {
            var result = await _carteiraService.GetAll();
            return new GetAllCarteiraQueryResponse(result);
        }

        public async Task<GetIdCarteiraQueryResponse> Handle(GetIdCarteiraQuery request, CancellationToken cancellationToken)
        {
            var result = await _carteiraService.GetId(request.Id);
            return new GetIdCarteiraQueryResponse(result);
        }

        public async Task<CreateCarteiraCommandResponse> Handle(CreateCarteiraCommand request, CancellationToken cancellationToken)
        {
            var result = await _carteiraService.Create(request.Carteira);
            return new CreateCarteiraCommandResponse(result);
        }

        public async Task<EditCarteiraCommandResponse> Handle(EditCarteiraCommand request, CancellationToken cancellationToken)
        {
            var result = await this._carteiraService.Edit(request.Carteira);

            return new EditCarteiraCommandResponse(result);
        }

        public async Task<DeleteCarteiraCommandResponse> Handle(DeleteCarteiraCommand request, CancellationToken cancellationToken)
        {
            var result = await this._carteiraService.Delete(request.Id);

            return new DeleteCarteiraCommandResponse(result);
        }
    }
}
