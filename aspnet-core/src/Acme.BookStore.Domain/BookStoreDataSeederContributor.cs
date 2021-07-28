using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;

        public BookStoreDataSeederContributor(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book("teste 1", 19, 30),
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book("teste 2", 42, 26),
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book("teste 3", 9, 29),
                    autoSave: true
                    );

                await _bookRepository.InsertAsync(
                    new Book("teste 4", 15, 25),
                    autoSave: true
                    );

                await _bookRepository.InsertAsync(
                    new Book("teste 5", 11, 27),
                    autoSave: true
                    );
            }
        }
    }
}
