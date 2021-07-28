using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(StoreApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class StoreHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(StoreApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
