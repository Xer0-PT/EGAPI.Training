using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Store.Purchases
{
    public class PurchaseDto : FullAuditedEntityDto<Guid>
    {
        public PurchaseDto(string bookName)
        {
            BookName = bookName;
        }

        public PurchaseDto(Guid pBookId, float totalCost, int quantity)
        {
            PBookId = pBookId;
            TotalCost = totalCost;
            Quantity = quantity;
        }

        public PurchaseDto(Guid pBookId, float totalCost, int quantity, bool updateFlag, int stockToUpdate)
        {
            PBookId = pBookId;
            TotalCost = totalCost;
            Quantity = quantity;
            UpdateFlag = updateFlag;
            StockToUpdate = stockToUpdate;
        }

        public Guid PBookId { get; set; }
        public float TotalCost { get; set; }
        public int Quantity { get; set; }
        public bool UpdateFlag { get; set; }
        public int StockToUpdate { get; set; }
        public string BookName { get; set; }

    }
}
