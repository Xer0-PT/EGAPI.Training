using Volo.Abp.Modularity;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(StoreApplicationModule),
        typeof(StoreDomainTestModule)
        )]
    public class StoreApplicationTestModule : AbpModule
    {

    }
}
