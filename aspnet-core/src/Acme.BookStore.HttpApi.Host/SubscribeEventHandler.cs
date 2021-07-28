using Acme.BookStore.Books;
using Acme.BookStore.Store.StoreBooks;
using Acme.BookStore.Store.Purchases;
using AutoMapper;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;

namespace Acme.BookStore
{
    public class SubscribeEventHandler :
        IDistributedEventHandler<EntityCreatedEto<PurchaseEto>>,
        IDistributedEventHandler<EntityUpdatedEto<PurchaseEto>>,
        ITransientDependency
    {
        private readonly IBookAppService _bookAppService;

        public SubscribeEventHandler(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        public Task HandleEventAsync(EntityCreatedEto<PurchaseEto> eventData)
        {
            var bookId = eventData.Entity.PBookId;
            var quantity = eventData.Entity.Quantity;
            return _bookAppService.NewPurchaseUpdateStock(bookId, quantity);
        }

        public Task HandleEventAsync(EntityUpdatedEto<PurchaseEto> eventData)
        {
            var bookId = eventData.Entity.PBookId;
            var stockToUpdate = eventData.Entity.StockToUpdate;
            var flag = eventData.Entity.UpdateFlag;
            return _bookAppService.UpdatedPurchaseUpdateStock(bookId, stockToUpdate, flag);
        }
    }
}
