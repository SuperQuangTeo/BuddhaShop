using AutoMapper;
using BuddhaShop.DTOs;
using BuddhaShop.Models;

namespace BuddhaShop.AutoMapping
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(rs => rs.Category.CategoryName))
                .ForMember(x => x.SupplierName, y => y.MapFrom(rs => rs.Supplier.SupplierName));
            CreateMap<ProductDTO, Product>()
                .ForMember(x => x.Category, y => y.MapFrom(rs => rs.CategoryName))
                .ForMember(x => x.Supplier, y => y.MapFrom(rs => rs.SupplierName));
            CreateMap<Category, CategoryDTO>();
            CreateMap<Supplier, SupplierDTO>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<SupplierDTO, Supplier>();
        }
    }
}
