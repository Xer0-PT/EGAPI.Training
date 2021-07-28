using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService : 
        ICrudAppService<
        BookDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateBookDto,
        UpdateBookDto>,
        IApplicationService
    {
        public new Task<BookDto> CreateAsync(CreateBookDto input);
        Task NewPurchaseUpdateStock(Guid bookId, int quantity);
        Task UpdatedPurchaseUpdateStock(Guid bookId, int stockToUpdate, bool flag);
        Task<BookDto> GetAllBooksIncludingDeleted(string name);
    }
}
