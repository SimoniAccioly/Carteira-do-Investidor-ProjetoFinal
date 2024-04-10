using AutoMapper;
using CarteiraDoInvestidor.Application.Carteira.Dto;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using CarteiraDoInvestidor.Repository.Repository;

namespace CarteiraDoInvestidor.Application.Carteira.Service
{
    public class CarteiraService : ICarteiraService
    {
        private readonly ICarteiraRepository carteiraRepository;
        private readonly IMapper mapper;

        public CarteiraService(ICarteiraRepository carteiraRepository, IMapper mapper)
        {
            this.carteiraRepository = carteiraRepository;
            this.mapper = mapper;
        }

        public async Task<CarteiraOutputDto> Create(CarteiraInputDto dto)
        {
            var carteira = this.mapper.Map < CarteiraDoInvestidor.Domain.Carteira.Carteira>(dto);

            await this.carteiraRepository.Save(carteira);

            return this.mapper.Map<CarteiraOutputDto>(carteira);
        }

        public async Task<List<CarteiraOutputDto>> GetAll()
        {
            var result = await this.carteiraRepository.GetAll();

            return this.mapper.Map<List<CarteiraOutputDto>>(result);
        }

        public async Task<CarteiraOutputDto> Edit(CarteiraInputDto dto)
        {
            var carteira = this.mapper.Map<CarteiraDoInvestidor.Domain.Carteira.Carteira>(dto);

            await this.carteiraRepository.Update(carteira);

            return this.mapper.Map<CarteiraOutputDto>(carteira);
        }

        public async Task<CarteiraOutputDto> Delete(Guid id)
        {
            var carteira = await this.carteiraRepository.Get(id);

            await this.carteiraRepository.Delete(carteira);

            return this.mapper.Map<CarteiraOutputDto>(carteira);
        }

        public async Task<CarteiraOutputDto> GetId(Guid id)
        {
            var result = await this.carteiraRepository.Get(id);

            return this.mapper.Map<CarteiraOutputDto>(result);
        }

   
    }
}
