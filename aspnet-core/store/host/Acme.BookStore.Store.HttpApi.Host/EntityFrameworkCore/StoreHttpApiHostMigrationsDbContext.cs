using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    public class StoreHttpApiHostMigrationsDbContext : AbpDbContext<StoreHttpApiHostMigrationsDbContext>
    {
        public StoreHttpApiHostMigrationsDbContext(DbContextOptions<StoreHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureStore();
        }
    }
}
