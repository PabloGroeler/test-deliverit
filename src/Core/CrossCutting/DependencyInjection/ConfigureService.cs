using Microsoft.Extensions.DependencyInjection;
using test_deliverit.src.Core.Domain.Interfaces.Services;
using test_deliverit.src.Core.Services;

namespace test_deliverit.src.Core.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependencysService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IContaPagarService, ContaPagarService>();
        }

    }
}