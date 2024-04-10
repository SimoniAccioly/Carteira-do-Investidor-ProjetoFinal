using CarteiraDoInvestidor.Domain.Carteira;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;

namespace CarteiraDoInvestidor.Repository.Repository
{
    public class CarteiraRepository : Repository<Carteira>, ICarteiraRepository
    {
        public CarteiraRepository(CarteiraDoInvestidorContext context) : base(context)
        {
        }
    }
}
