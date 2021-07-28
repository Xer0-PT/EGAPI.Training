using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Store.StoreBooks
{
    public class StoreBook : FullAuditedAggregateRoot<Guid>
    {
        public StoreBook(Guid id, string name, float price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void UpdateStock(int stock)
        {
            Stock = stock;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }


    }
}
