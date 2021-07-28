using Acme.BookStore.Store.StoreBooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Store.StoreBooks
{
    public interface IStoreBookRepository : IRepository<StoreBook, Guid>
    {
    }
}
