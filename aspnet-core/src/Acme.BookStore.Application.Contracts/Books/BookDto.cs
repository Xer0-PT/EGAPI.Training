using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class BookDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
