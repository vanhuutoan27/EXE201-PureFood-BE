using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Domain.Identity;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;

namespace PureFood.API.AutoMappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, ProductRespone>()
        .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.SupplierName))
        .ForMember(dest => dest.CategoryName, ost => ost.MapFrom(src => src.Category.CategoryName))
       .ForMember(dest => dest.Images, opt => opt.MapFrom(src =>
        src.Images.Select(img => img.Url).ToList()));
            CreateMap<Cart, CreateCartRequest>().ReverseMap();
            CreateMap<CartItem, CreateCartItemsRequest>().ReverseMap();
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CategoryReponses>().ReverseMap();
            CreateMap<Review, ReviewReponse>().ReverseMap();
            CreateMap<Review, CreateReviewRequest>().ReverseMap();
            CreateMap<Supplier, SupplierReponse>().ReverseMap();
            CreateMap<Supplier, CreateSupplierRequest>().ReverseMap();
            CreateMap<AppUser, UserReponse>()
                        .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                        .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                        .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                        .ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
                        .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender)).ReverseMap();

            CreateMap<Order, OrderResponse>();
                CreateMap<Payment, PaymentRespone>()
        .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Order != null ? src.Order.OrderId : Guid.Empty))
        .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Order != null ? src.Order.UserId : Guid.Empty))
         .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt ?? DateTime.Now))  // Gán giá trị nếu null
    .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt ?? DateTime.Now)) // Gán giá trị nếu null
         .ReverseMap();
            CreateMap<Payment, CreatePaymentRequest>().ReverseMap();
        }
    }
}