using System;
using Acme.BookStore.Store.StoreBooks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    public static class StoreDbContextModelCreatingExtensions
    {
        public static void ConfigureStore(
            this ModelBuilder builder,
            Action<StoreModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new StoreModelBuilderConfigurationOptions(
                StoreDbProperties.DbTablePrefix,
                StoreDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<Purchase>(b =>
            {
                b.ToTable(options.TablePrefix + "Purchases", options.Schema);
                b.ConfigureByConvention();
            });

            builder.Entity<StoreBook>(b =>
            {
                b.ToTable(options.TablePrefix + "StoreBooks", options.Schema);
                b.ConfigureByConvention();
            });
        }
    }
}