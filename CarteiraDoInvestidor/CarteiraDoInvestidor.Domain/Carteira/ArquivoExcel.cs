using CarteiraDoInvestidor.CrossCuting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Domain.Carteira
{
    public class ArquivoExcel : Entity<Guid>
    {
        public string LinkExcel { get; set; }
    }
}
