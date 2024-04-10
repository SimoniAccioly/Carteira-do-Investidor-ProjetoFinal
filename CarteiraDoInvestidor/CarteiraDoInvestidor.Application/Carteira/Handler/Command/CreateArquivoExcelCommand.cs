using CarteiraDoInvestidor.Application.Carteira.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Handler.Command
{
    public class CreateArquivoExcelCommand : IRequest<CreateArquivoExcelCommandResponse>
    {
        public ArquivoExcelInputDto LinkExcel { get; set; }

        public CreateArquivoExcelCommand(ArquivoExcelInputDto arquivos)
        {
            LinkExcel = arquivos;
        }
    }

    public class CreateArquivoExcelCommandResponse
    {
        public ArquivoExcelOutputDto LinkExcel { get; set; }

        public CreateArquivoExcelCommandResponse(ArquivoExcelOutputDto arquivos)
        {
            LinkExcel = arquivos;
        }
    }
}
