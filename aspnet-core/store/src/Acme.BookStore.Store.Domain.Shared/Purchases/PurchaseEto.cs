using System;
using Volo.Abp.EventBus;

namespace Acme.BookStore.Store.Purchases
{
    [Serializable]
    [EventName("Purchase")]
    public class PurchaseEto
    {
        public Guid PBookId { get; set; }
        public float TotalCost { get; set; }
        public int Quantity { get; set; }
        public bool UpdateFlag { get; set; }
        public int StockToUpdate { get; set; }

        public PurchaseEto()
        {}

        public PurchaseEto(Guid pBookId, float totalCost, int quantity, bool updateFlag, int stockToUpdate)
        {
            PBookId = pBookId;
            TotalCost = totalCost;
            Quantity = quantity;
            UpdateFlag = updateFlag;
            StockToUpdate = stockToUpdate;
        }
    }
}
