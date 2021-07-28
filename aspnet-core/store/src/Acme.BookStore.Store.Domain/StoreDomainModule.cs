using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(StoreDomainSharedModule)
    )]
    public class StoreDomainModule : AbpModule
    {

    }
}
