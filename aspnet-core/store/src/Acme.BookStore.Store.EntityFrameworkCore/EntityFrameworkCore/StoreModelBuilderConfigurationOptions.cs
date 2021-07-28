using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    public class StoreModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public StoreModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}