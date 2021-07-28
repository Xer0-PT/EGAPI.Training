using Acme.BookStore.Store.StoreBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Store.Purchases
{
    public interface IPurchaseAppService :
        ICrudAppService<
            PurchaseDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreatePurchaseDto,
            UpdatePurchaseDto>
    {
        new Task<PurchaseDto> CreateAsync(CreatePurchaseDto input);
        new Task<PurchaseDto> UpdateAsync(Guid id, UpdatePurchaseDto input);
        new Task<PagedResultDto<PurchaseDto>> GetListAsync(PagedAndSortedResultRequestDto input);
        new Task<PurchaseDto> GetAsync(Guid id);
        //Task<IQueryable<StoreBook>> GetAllBooksIncludingDeleted();
    }
}
