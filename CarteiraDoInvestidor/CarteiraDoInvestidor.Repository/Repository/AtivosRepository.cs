using CarteiraDoInvestidor.Domain.Carteira;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Repository.Repository
{
    public class AtivosRepository : Repository<Ativos>, IAtivoRepository
    {
        public AtivosRepository(CarteiraDoInvestidorContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ativos>> ObterTodosAtivos()
        {
            return await this.Query.ToListAsync();
        }
    }
}
