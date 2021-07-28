using Acme.BookStore.Store.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Store
{
    public abstract class StoreAppService : ApplicationService
    {
        protected StoreAppService()
        {
            LocalizationResource = typeof(StoreResource);
            ObjectMapperContext = typeof(StoreApplicationModule);
        }
    }
}
