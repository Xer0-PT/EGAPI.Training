using Acme.BookStore.Store.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(StoreEntityFrameworkCoreTestModule)
        )]
    public class StoreDomainTestModule : AbpModule
    {
        
    }
}
