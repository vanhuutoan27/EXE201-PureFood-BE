using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.API.AutoMappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CategoryReponses>().ReverseMap();
            CreateMap<Review, ReviewReponse>().ReverseMap();
            CreateMap<Review, CreateReviewRequest>().ReverseMap();
            CreateMap<Supplier, SupplierReponse>().ReverseMap();
            CreateMap<Supplier, CreateSupplierRequest>().ReverseMap();




        }
    }
}
