using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EventBus;

namespace Acme.BookStore.Store.StoreBooks
{
    [Serializable]
    [EventName("StoreBook")]
    public class StoreBookEto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public StoreBookEto()
        {}

        public StoreBookEto(string name, float price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }
}
