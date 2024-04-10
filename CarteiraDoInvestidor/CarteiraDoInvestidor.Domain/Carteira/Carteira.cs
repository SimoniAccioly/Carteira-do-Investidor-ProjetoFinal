using CarteiraDoInvestidor.CrossCuting.Entity;

namespace CarteiraDoInvestidor.Domain.Carteira
{
    public class Carteira : Entity<Guid>
    {
        public string NomeCarteira { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual IList<Ativos> Ativos { get; set; }
        public virtual IList<ArquivoExcel> LinkExcel { get; set; }

        public int QuantidadeAtivos()
            => this.Ativos.Count;
        public int QuantidadeLinkExcel()
            => this.LinkExcel.Count;

    }
}
