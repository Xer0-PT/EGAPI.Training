using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(StoreDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class StoreApplicationContractsModule : AbpModule
    {

    }
}
