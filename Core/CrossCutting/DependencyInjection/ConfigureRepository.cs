using Microsoft.Extensions.DependencyInjection;
using test_deliverit.Core.Data.Repository;
using test_deliverit.Core.Domain.Interfaces.Repository;

namespace test_deliverit.Core.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependecyService(IServiceCollection services)
        {
            services.AddTransient<IContaPagarRepository, ContaPagarRepository>();
        }
    }
}