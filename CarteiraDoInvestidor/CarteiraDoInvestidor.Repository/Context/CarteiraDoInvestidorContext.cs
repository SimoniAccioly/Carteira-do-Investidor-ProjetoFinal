using Microsoft.EntityFrameworkCore;

namespace CarteiraDoInvestidor.Repository.Context
{
    public class CarteiraDoInvestidorContext : DbContext
    {
        public CarteiraDoInvestidorContext(DbContextOptions<CarteiraDoInvestidorContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CarteiraDoInvestidorContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}