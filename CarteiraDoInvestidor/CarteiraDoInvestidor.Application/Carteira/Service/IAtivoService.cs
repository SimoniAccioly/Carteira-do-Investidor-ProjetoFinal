using CarteiraDoInvestidor.Application.Carteira.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public interface IAtivoService
    {
        Task<AtivosOutputDto> Create(AtivosInputDto dto);
        Task<List<AtivosOutputDto>> GetAll();
        Task<AtivosOutputDto> Edit(AtivosInputDto dto);
        Task<AtivosOutputDto> Delete(Guid id);
        Task<AtivosOutputDto> GetId(Guid id);
    }
}
