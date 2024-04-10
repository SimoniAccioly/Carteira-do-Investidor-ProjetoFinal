using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Query
{
    public class GetAllArquivosExcelQuery : IRequest<GetAllArquivosExcelQueryResponse>
    {

    }

    public class GetAllArquivosExcelQueryResponse
    {
        public IList<ArquivoExcelOutputDto> ArquivosExcel { get; set; }

        public GetAllArquivosExcelQueryResponse(IList<ArquivoExcelOutputDto> arquivos)
        {
            ArquivosExcel = arquivos;
        }
    }
}
