using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.Store.MongoDB
{
    public class StoreMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public StoreMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}