using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStore.Store.EntityFrameworkCore
{
    public class StoreHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<StoreHttpApiHostMigrationsDbContext>
    {
        public StoreHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<StoreHttpApiHostMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));
            //.UseSqlServer(configuration.GetConnectionString("Store"));

            return new StoreHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
