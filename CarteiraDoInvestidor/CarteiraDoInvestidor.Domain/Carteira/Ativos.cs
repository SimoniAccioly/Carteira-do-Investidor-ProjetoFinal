using CarteiraDoInvestidor.CrossCuting.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteiraDoInvestidor.Domain.Carteira
{
    public class Ativos : Entity<Guid>
    {
        public string Papel { get; set; }
        public int Quantidade { get; set; }
        public double PrecoMedio { get; set; }
        public string Corretora { get; set; }
        public double TaxaDeCorretagem { get; set; }




    }
}
