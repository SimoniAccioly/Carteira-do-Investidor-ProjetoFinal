using CarteiraDoInvestidor.Domain.Conta;
using CarteiraDoInvestidor.Domain.Conta.Repository;
using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;

namespace CarteiraDoInvestidor.Repository.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CarteiraDoInvestidorContext context) : base(context)
        {

        }
    }
}
