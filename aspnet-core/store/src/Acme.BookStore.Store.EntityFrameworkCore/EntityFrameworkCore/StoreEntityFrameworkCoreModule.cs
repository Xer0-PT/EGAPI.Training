using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    [DependsOn(
        typeof(StoreDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class StoreEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StoreDbContext>(options =>
            {
                // Swagger dava erro 500.
                // ---> Autofac.Core.DependencyResolutionException: None of the constructors found with ....
                options.AddDefaultRepositories(includeAllEntities: true); // Resolve o problema
            });
        }
    }
}