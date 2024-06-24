using AutoMapper;
using fronttaskApi.DTOs.Category;
using fronttaskApi.DTOs.ProductDtos;
using fronttaskApi.Models;

namespace fronttaskApi.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryArchiveDto>()
                .ForMember(d => d.CreatedDate, opt => opt.MapFrom(s => s.CreatedDate.ToString("MM.dd.yyyy")));
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<Category, CategoryProductDto>()
                .ForMember(d => d.ProductCount, opt => opt.MapFrom(s => s.Products.Count))
                .ForMember(d => d.CreatedDate, opt => opt.MapFrom(s => s.CreatedDate.ToString("MM.dd.yyyy")));
            CreateMap<Category, CategoryDetailDTO>()
                .ForMember(d => d.Products, opt => opt.MapFrom(s => s.Products.Select(p => p.Name)))
                .ForMember(d => d.ProductCount, opt => opt.MapFrom(s => s.Products.Count))
                .ForMember(d => d.CreatedDate, opt => opt.MapFrom(s => s.CreatedDate.ToString("MM.dd.yyyy")));
            CreateMap<CategoryEditDto, Category>();


            //Product
            CreateMap<Product, ProductMainImageDto>()
                .ForMember(d => d.MainImage, opt => opt.MapFrom(s => s.ProductImages.FirstOrDefault(i => i.IsMain).Name));
            CreateMap<Product, ProductDetailDto>()
                .ForMember(d => d.Category, opt => opt.MapFrom(s => s.Category.Name))
                .ForMember(d => d.Images, opt => opt.MapFrom(s => s.ProductImages.Select(i => new ProductImageDto
                {
                    Name = i.Name,
                    IsMain = i.IsMain
                }).ToList()));
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductEditDto, Product>();

        }
    }
}
