using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public Book()
        {}

        public Book(string name, float price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void NewPurchaseUpdateStock(int quantity)
        {
            Stock -= quantity;
        }

        public void UpdatedPurchaseUpdateStock(int stockToUpdate, bool flag)
        {
            if (flag == true)
                Stock += stockToUpdate;
            else
                Stock -= stockToUpdate;
        }
    }
}
