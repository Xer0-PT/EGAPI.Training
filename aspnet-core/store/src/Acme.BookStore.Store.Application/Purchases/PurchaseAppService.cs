using Acme.BookStore.Store.StoreBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Store.Purchases
{
    public class PurchaseAppService :
        CrudAppService<
            Purchase,
            PurchaseDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreatePurchaseDto,
            UpdatePurchaseDto>,
        IPurchaseAppService
    {
        private readonly IStoreBookAppService _bookAppService;
        private readonly IRepository<StoreBook, Guid> _bookRepo;
        private readonly IDataFilter<ISoftDelete> _softDeleteFilter;

        public PurchaseAppService(
            IRepository<Purchase, Guid> repository,
            IStoreBookAppService bookAppService,
            IRepository<StoreBook, Guid> bookRepo,
            IDataFilter<ISoftDelete> softDeleteFilter)
            : base(repository)
        {
            _bookAppService = bookAppService;
            _bookRepo = bookRepo;
            _softDeleteFilter = softDeleteFilter;
        }

        public override async Task<PurchaseDto> CreateAsync(CreatePurchaseDto input)
        {
            // GetAsync retorna automaticamente a EntityNotFoundException caso seja null
            //StoreBookDto book = await _bookAppService.GetAsync(input.PBookId);

            var book = await _bookRepo.FirstAsync(x => x.Name.ToLower() == input.BookName.ToLower() && x.IsDeleted == false);

            //var book = await GetAllBooksIncludingDeleted(input.BookName);

            if (book == null)
                throw new UserFriendlyException("The book you chose doesn't exist!");
            if (book.Stock < input.Quantity)
                throw new BusinessException("Store:0001").WithData("Stock", book.Stock);


            var totalCost = book.Price * input.Quantity;

            var purchase = new Purchase(book.Id, totalCost, input.Quantity);

            await Repository.InsertAsync(purchase, autoSave: true);

            return ObjectMapper.Map<Purchase, PurchaseDto>(purchase);
        }

        public override async Task<PurchaseDto> UpdateAsync(Guid id, UpdatePurchaseDto input)
        {
            var purchase = await Repository.GetAsync(id);
            var book = await _bookAppService.GetAsync(purchase.PBookId);

            if (input.Quantity > book.Stock)
                throw new BusinessException("Store:0001").WithData("Stock", book.Stock);

            var newTotalCost = book.Price * input.Quantity;
            int stockToUpdate;
            bool flag;

            if (input.Quantity > purchase.Quantity)
            {
                stockToUpdate = input.Quantity - purchase.Quantity;
                flag = false;
            }
            else
            {
                stockToUpdate = purchase.Quantity - input.Quantity;
                flag = true;
            }

            purchase.UpdatePurchase(newTotalCost, input.Quantity, flag, stockToUpdate);

            await Repository.UpdateAsync(purchase);

            return ObjectMapper.Map<Purchase, PurchaseDto>(purchase);
        }

        public override async Task<PagedResultDto<PurchaseDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            IQueryable<Purchase> purchaseQueryable = await Repository.GetQueryableAsync();
            IQueryable<StoreBook> bookQueryable = await _bookRepo.GetQueryableAsync();

            //IQueryable<StoreBook> bookQueryable = await GetAllBooksIncludingDeleted();

            var query = from purchase in purchaseQueryable
                        join book in bookQueryable on purchase.PBookId equals book.Id
                        select new { purchase, book };

            var queryResult = await AsyncExecuter.ToListAsync(query);

            var purchaseDtos = queryResult.Select(x =>
            {
                var purchaseDto = ObjectMapper.Map<Purchase, PurchaseDto>(x.purchase);
                purchaseDto.BookName = x.book.Name;
                return purchaseDto;
            }).ToList();

            var totalCount = await Repository.GetCountAsync();

            return new PagedResultDto<PurchaseDto>(totalCount, purchaseDtos);
        }

        public override async Task<PurchaseDto> GetAsync(Guid id)
        {
            var purchase = await Repository.GetAsync(id);
            var book = await _bookRepo.GetAsync(purchase.PBookId);

            var purchaseDto = ObjectMapper.Map<Purchase, PurchaseDto>(purchase);
            purchaseDto.BookName = book.Name;

            return purchaseDto;
        }

//        public Task<IQueryable<StoreBook>> GetAllBooksIncludingDeleted()
//        {
//            using (_softDeleteFilter.Disable())
//            {
//                //return await _bookRepo.GetQueryableAsync();
//                return (Task<IQueryable<StoreBook>>)_bookRepo.AsQueryable();



//#warning Falta mostrar as compras feitas com livros que foram apagados!
//            }
//        }
    }
}
