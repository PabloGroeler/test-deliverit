using Microsoft.Extensions.DependencyInjection;
using test_deliverit.src.Core.Data.Repository;
using test_deliverit.src.Core.Domain.Interfaces.Repository;

namespace test_deliverit.src.Core.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependecyService(IServiceCollection services)
        {
            services.AddTransient<IContaPagarRepository, ContaPagarRepository>();
        }
    }
}