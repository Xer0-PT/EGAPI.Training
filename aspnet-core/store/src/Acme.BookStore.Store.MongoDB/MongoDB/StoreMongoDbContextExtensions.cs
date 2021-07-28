using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.Store.MongoDB
{
    public static class StoreMongoDbContextExtensions
    {
        public static void ConfigureStore(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new StoreMongoModelBuilderConfigurationOptions(
                StoreDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}