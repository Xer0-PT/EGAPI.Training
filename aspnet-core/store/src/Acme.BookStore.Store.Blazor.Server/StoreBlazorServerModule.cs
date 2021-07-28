using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(StoreBlazorModule)
        )]
    public class StoreBlazorServerModule : AbpModule
    {
        
    }
}