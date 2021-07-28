using System;

namespace Acme.BookStore.Store.Purchases
{
    public class CreatePurchaseDto
    {
        public Guid PBookId { get; set; }
        public int Quantity { get; set; }
        public string BookName { get; set; }
    }
}
