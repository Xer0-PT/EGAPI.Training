using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Store.StoreBooks
{
    public class StoreBookAppService :
        CrudAppService<
            StoreBook,
            StoreBookDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateStoreBookDto,
            UpdateStoreBookDto>,
        IStoreBookAppService
    {
        public StoreBookAppService(IRepository<StoreBook, Guid> repository) : base(repository)
        {
            
        }

        public async Task UpdateStock(Guid id, int stock)
        {
            var book = await Repository.GetAsync(id);
            book.UpdateStock(stock);
            await Repository.UpdateAsync(book);
        }

        public override async Task<PagedResultDto<StoreBookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var books = await Repository.GetListAsync(x => x.IsDeleted == false);

            var totalCount = books.Count;

            return new PagedResultDto<StoreBookDto>(totalCount, ObjectMapper.Map<List<StoreBook>, List<StoreBookDto>>(books));
        }
    }
}
