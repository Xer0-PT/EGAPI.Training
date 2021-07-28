using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Guids;

namespace Acme.BookStore.Store.Purchases
{
    public class PurchaseManager : DomainService
    {
        private readonly IRepository<Purchase, Guid> _purchaseRepository;
        private readonly IGuidGenerator _guidGenerator;

        public PurchaseManager(IRepository<Purchase, Guid> purchaseRepository,
            IGuidGenerator guidGenerator)
        {
            _purchaseRepository = purchaseRepository;
            _guidGenerator = guidGenerator;
        }

        //public async Task<Purchase> CreatePurchase(Guid pBookId, float totalCost, int quantity)
        //{
        //    var purchase = new Purchase(pBookId, totalCost, quantity);

        //    await _purchaseRepository.InsertAsync(purchase);

        //    return purchase;
        //}

    }
}
