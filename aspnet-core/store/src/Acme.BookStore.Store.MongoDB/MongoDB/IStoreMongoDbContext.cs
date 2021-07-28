using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.Store.MongoDB
{
    [ConnectionStringName(StoreDbProperties.ConnectionStringName)]
    public interface IStoreMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
