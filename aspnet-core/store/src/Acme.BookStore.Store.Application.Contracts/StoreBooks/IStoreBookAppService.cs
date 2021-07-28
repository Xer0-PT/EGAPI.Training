using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Store.StoreBooks
{
    public interface IStoreBookAppService :
        ICrudAppService<
            StoreBookDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateStoreBookDto,
            UpdateStoreBookDto>
    {

    }
}
