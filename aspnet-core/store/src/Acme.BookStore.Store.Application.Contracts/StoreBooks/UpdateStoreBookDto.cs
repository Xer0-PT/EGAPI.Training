using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Store.StoreBooks
{
    public class UpdateStoreBookDto
    {
        public UpdateStoreBookDto(string name)
        {
            Name = name;
        }

        public UpdateStoreBookDto(float price)
        {
            Price = price;
        }

        public UpdateStoreBookDto(int stock)
        {
            Stock = stock;
        }

        public UpdateStoreBookDto(string name, float price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
