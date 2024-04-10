using CarteiraDoInvestidor.CrossCuting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Domain.Carteira.Repository
{
    public interface IArquivoExcelRepository : IRepository<ArquivoExcel>
    {
        Task<IEnumerable<ArquivoExcel>> ObterTodosArquivos();
    }
}
