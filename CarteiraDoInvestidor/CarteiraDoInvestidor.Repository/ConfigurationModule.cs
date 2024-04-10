using CarteiraDoInvestidor.CrossCuting.Infrastructure;
using CarteiraDoInvestidor.Domain.Carteira.Repository;
using CarteiraDoInvestidor.Domain.Conta.Repository;
using CarteiraDoInvestidor.Repository.Context;
using CarteiraDoInvestidor.Repository.Database;
using CarteiraDoInvestidor.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarteiraDoInvestidor.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CarteiraDoInvestidorContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<ICarteiraRepository, CarteiraRepository>();
            services.AddScoped<IAtivoRepository, AtivosRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IArquivoExcelRepository, ArquivosExcelRepository>();
            services.AddScoped<AzureBlobStorage>();

            


            return services;
        }
    }
}
