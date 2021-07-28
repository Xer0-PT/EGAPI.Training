using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Events.Distributed;

namespace Acme.BookStore.Books
{
    public class CreateBookDto
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
