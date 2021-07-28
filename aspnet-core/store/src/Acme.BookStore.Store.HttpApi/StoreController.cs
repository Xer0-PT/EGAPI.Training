using Acme.BookStore.Store.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Store
{
    public abstract class StoreController : AbpController
    {
        protected StoreController()
        {
            LocalizationResource = typeof(StoreResource);
        }
    }
}
