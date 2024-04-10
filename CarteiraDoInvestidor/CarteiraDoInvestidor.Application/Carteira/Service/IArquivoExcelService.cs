using CarteiraDoInvestidor.Application.Carteira.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public interface IArquivoExcelService
    {
        Task<ArquivoExcelOutputDto> Create(ArquivoExcelInputDto dto);
        Task<List<ArquivoExcelOutputDto>> GetAll();

    }
}
