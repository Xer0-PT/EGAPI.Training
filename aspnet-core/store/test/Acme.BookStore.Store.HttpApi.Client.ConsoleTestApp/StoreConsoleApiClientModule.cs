using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(StoreHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StoreConsoleApiClientModule : AbpModule
    {
        
    }
}
