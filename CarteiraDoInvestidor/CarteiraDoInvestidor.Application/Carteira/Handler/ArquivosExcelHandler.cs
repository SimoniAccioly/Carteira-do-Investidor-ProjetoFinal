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
    public class ArquivosExcelHandler : IRequestHandler<CreateArquivoExcelCommand, CreateArquivoExcelCommandResponse>,
                                  IRequestHandler<GetAllArquivosExcelQuery, GetAllArquivosExcelQueryResponse>

    {
        private readonly IArquivoExcelService _arquivoService;

        public ArquivosExcelHandler(IArquivoExcelService arquivoService)
        {
            _arquivoService = arquivoService;
        }

        public async Task<CreateArquivoExcelCommandResponse> Handle(CreateArquivoExcelCommand request, CancellationToken cancellationToken)
        {
            var result = await this._arquivoService.Create(request.LinkExcel);
            return new CreateArquivoExcelCommandResponse(result);
        }

        public async Task<GetAllArquivosExcelQueryResponse> Handle(GetAllArquivosExcelQuery request, CancellationToken cancellationToken)
        {
            var result = await this._arquivoService.GetAll();
            return new GetAllArquivosExcelQueryResponse(result);
        }
    }
}
