using Acme.BookStore.Permissions;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService :
        CrudAppService<
            Book,
            BookDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateBookDto,
            UpdateBookDto>,
        IBookAppService,
        IApplicationService
    {
        private readonly IDataFilter<ISoftDelete> _softDeleteFilter;

        public BookAppService(IRepository<Book, Guid> repository,
            IDataFilter<ISoftDelete> softDeleteFilter) : base(repository)
        {
            _softDeleteFilter = softDeleteFilter;

            GetPolicyName = BookStorePermissions.Books.Default;
            GetListPolicyName = BookStorePermissions.Books.Default;
            CreatePolicyName = BookStorePermissions.Books.Create;
            UpdatePolicyName = BookStorePermissions.Books.Edit;
            DeletePolicyName = BookStorePermissions.Books.Delete;
        }

        public override async Task<BookDto> CreateAsync(CreateBookDto input)
        {
            var bookExists = await GetAllBooksIncludingDeleted(input.Name);

            if (bookExists != null)
                throw new UserFriendlyException("The name you chose already exists!");
            if (input.Stock < 0)
                throw new UserFriendlyException("You can't insert stock below zero!");
            if (input.Price < 0)
                throw new UserFriendlyException("You can't insert price below zero!");
            
            var book = new Book(input.Name, input.Price, input.Stock);
            
            await Repository.InsertAsync(book);

            return ObjectMapper.Map<Book, BookDto>(book);
        }

        async Task IBookAppService.NewPurchaseUpdateStock(Guid bookId, int quantity)
        {
            var book = await Repository.GetAsync(bookId);
            book.NewPurchaseUpdateStock(quantity);
            await Repository.UpdateAsync(book);
        }
        async Task IBookAppService.UpdatedPurchaseUpdateStock(Guid bookId, int stockToUpdate, bool flag)
        {
            var book = await Repository.GetAsync(bookId);
            book.UpdatedPurchaseUpdateStock(stockToUpdate, flag);
            await Repository.UpdateAsync(book);
        }

        public async Task<BookDto> GetAllBooksIncludingDeleted(string name)
        {
            using (_softDeleteFilter.Disable())
            {
                var book = await Repository.FindAsync(x => x.Name.ToLower() == name.ToLower());
                return ObjectMapper.Map<Book, BookDto>(book);
            }
        }
    }
}
