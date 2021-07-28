using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Acme.BookStore.Store.Blazor.WebAssembly
{
    [DependsOn(
        typeof(StoreBlazorModule),
        typeof(StoreHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class StoreBlazorWebAssemblyModule : AbpModule
    {
        
    }
}