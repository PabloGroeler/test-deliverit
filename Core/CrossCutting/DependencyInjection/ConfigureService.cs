using Microsoft.Extensions.DependencyInjection;
using test_deliverit.Core.Domain.Interfaces.Services;
using test_deliverit.Core.Services;

namespace test_deliverit.Core.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependencysService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IContaPagarService, ContaPagarService>();
        }

    }
}