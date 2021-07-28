using Acme.BookStore.Store.Purchases;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Store
{
    public class Purchase : FullAuditedAggregateRoot<Guid>
    {
        public Guid PBookId { get; set; }
        public float TotalCost { get; set; }
        public int Quantity { get; set; }
        public bool UpdateFlag { get; set; }
        public int StockToUpdate { get; set; }

        public Purchase()
        {}

        public Purchase(Guid pBookId, float totalCost, int quantity)
        {
            PBookId = pBookId;
            TotalCost = totalCost;
            Quantity = quantity;
        }

        public Purchase(Guid pBookId, float totalCost, int quantity, bool updateFlag, int updateQuantity)
        {
            PBookId = pBookId;
            TotalCost = totalCost;
            Quantity = quantity;
            UpdateFlag = updateFlag;
            StockToUpdate = updateQuantity;
        }

        public void UpdatePurchase(float totalCost, int newQuantity, bool flag, int stockToUpdate)
        {
            TotalCost = totalCost;
            Quantity = newQuantity;
            UpdateFlag = flag;
            StockToUpdate = stockToUpdate;
        }
    }
}
