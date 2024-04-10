using CarteiraDoInvestidor.Application.Carteira.Service;
using CarteiraDoInvestidor.Application.Conta.Service;
using Microsoft.Extensions.DependencyInjection;
using MediatR;


namespace CarteiraDoInvestidor.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            
           services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

           services.AddMediatR(typeof(Application.ConfigurationModule).Assembly);

            services.AddScoped<ICarteiraService, CarteiraService>();
            services.AddScoped<IAtivoService, AtivoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IArquivoExcelService, ArquivoExcelService>();


            return services;
        }
    }

}
