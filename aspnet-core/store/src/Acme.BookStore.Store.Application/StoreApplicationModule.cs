using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Acme.BookStore.Store
{
    [DependsOn(
        typeof(StoreDomainModule),
        typeof(StoreApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class StoreApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //context.Services.AddAutoMapperObjectMapper<StoreApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<StoreApplicationModule>();
            });
        }
    }
}
