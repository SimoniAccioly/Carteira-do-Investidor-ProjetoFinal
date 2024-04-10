using CarteiraDoInvestidor.Application.Carteira.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public interface ICarteiraService
    {
        Task<CarteiraOutputDto> Create(CarteiraInputDto dto);
        Task<List<CarteiraOutputDto>> GetAll();
        Task<CarteiraOutputDto> Edit(CarteiraInputDto dto);
        Task<CarteiraOutputDto> Delete(Guid id);
        Task<CarteiraOutputDto> GetId(Guid id);
    }
}
