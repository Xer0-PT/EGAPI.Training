using Acme.BookStore.Books;
using Acme.BookStore.Store.StoreBooks;
using Acme.BookStore.Store.Purchases;
using AutoMapper;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;

namespace Acme.BookStore.Store
{
    public class SubscribeEventHandler :
        IDistributedEventHandler<EntityCreatedEto<BookEto>>,
        IDistributedEventHandler<EntityUpdatedEto<BookEto>>,
        IDistributedEventHandler<EntityDeletedEto<BookEto>>,
        ITransientDependency
    {
        private readonly StoreBookAppService _bookAppService;
        public SubscribeEventHandler(StoreBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public Task HandleEventAsync(EntityCreatedEto<BookEto> eventData)
        {
            var book = new CreateStoreBookDto(eventData.Entity.Id, eventData.Entity.Name, eventData.Entity.Price,
            eventData.Entity.Stock);

            return _bookAppService.CreateAsync(book);
        }

        public Task HandleEventAsync(EntityUpdatedEto<BookEto> eventData)
        {
            var book = new UpdateStoreBookDto(eventData.Entity.Name, eventData.Entity.Price,
            eventData.Entity.Stock);

            return _bookAppService.UpdateAsync(eventData.Entity.Id, book);
        }

        public Task HandleEventAsync(EntityDeletedEto<BookEto> eventData)
        {
            return _bookAppService.DeleteAsync(eventData.Entity.Id);
        }
    }
}
