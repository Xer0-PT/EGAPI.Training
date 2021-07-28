using Acme.BookStore.Store.StoreBooks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    [ConnectionStringName(StoreDbProperties.ConnectionStringName)]
    public class StoreDbContext : AbpDbContext<StoreDbContext>, IStoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<StoreBook> StoreBooks { get; set; }


        public StoreDbContext(DbContextOptions<StoreDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureStore();
        }
    }
}