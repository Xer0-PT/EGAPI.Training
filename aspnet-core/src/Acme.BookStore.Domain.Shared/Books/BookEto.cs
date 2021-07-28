using System;
using Volo.Abp.EventBus;

namespace Acme.BookStore.Books
{
    [Serializable]
    [EventName("Book")]
    public class BookEto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public BookEto()
        {}
    }
}
