using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;

namespace PureFood.API.AutoMappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();
            CreateMap<Product, ProductRespone>().ReverseMap();
        }
    }
}
