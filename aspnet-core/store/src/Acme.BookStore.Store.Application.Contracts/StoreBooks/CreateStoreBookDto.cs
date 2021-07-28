using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Store.StoreBooks
{
    public class CreateStoreBookDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public CreateStoreBookDto(Guid id, string name, float price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
