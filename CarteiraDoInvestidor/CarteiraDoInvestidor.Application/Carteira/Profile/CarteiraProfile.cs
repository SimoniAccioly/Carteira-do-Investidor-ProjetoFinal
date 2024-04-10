using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Domain.Carteira;

namespace CarteiraDoInvestidor.Application.Carteira.Profile
{
    public class CarteiraProfile : AutoMapper.Profile
    {
        public CarteiraProfile()
        {
          
            CreateMap<Ativos, AtivosOutputDto>();

            CreateMap<AtivosInputDto, Ativos> ();

            CreateMap<ArquivoExcel, ArquivoExcelOutputDto> ();

            CreateMap<ArquivoExcelInputDto, ArquivoExcel>();

            CreateMap<CarteiraDoInvestidor.Domain.Carteira.Carteira, CarteiraOutputDto>();

            CreateMap<CarteiraInputDto, CarteiraDoInvestidor.Domain.Carteira.Carteira>();

        }
    }
}
