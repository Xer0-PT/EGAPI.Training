using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.Store.MongoDB
{
    [ConnectionStringName(StoreDbProperties.ConnectionStringName)]
    public class StoreMongoDbContext : AbpMongoDbContext, IStoreMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureStore();
        }
    }
}