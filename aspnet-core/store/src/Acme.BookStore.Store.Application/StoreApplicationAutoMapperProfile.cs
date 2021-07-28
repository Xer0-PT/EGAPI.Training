using Acme.BookStore.Store.StoreBooks;
using Acme.BookStore.Store.Purchases;
using AutoMapper;
using System.Collections.Generic;

namespace Acme.BookStore.Store
{
    public class StoreApplicationAutoMapperProfile : Profile
    {
        public StoreApplicationAutoMapperProfile()
        {
            // Purchases
            CreateMap<Purchase, PurchaseDto>();

            CreateMap<PurchaseDto, Purchase>();

            CreateMap<CreatePurchaseDto, Purchase>();

            CreateMap<UpdatePurchaseDto, Purchase>();

            CreateMap<Purchase, PurchaseEto>();


            // Books
            CreateMap<StoreBook, StoreBookDto>();
            
            CreateMap<StoreBookDto, StoreBook>();

            CreateMap<CreateStoreBookDto, StoreBook>();

            CreateMap<UpdateStoreBookDto, StoreBook>();

            CreateMap<StoreBook, StoreBookEto>();

            CreateMap<List<StoreBook>, List<StoreBookDto>>();
        }
    }
}