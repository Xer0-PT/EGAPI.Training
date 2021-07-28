using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Store.StoreBooks
{
    public class StoreBookDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
