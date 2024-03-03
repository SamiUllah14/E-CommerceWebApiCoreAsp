using AutoMapper;
using E_CommerceApi.Models;
using E_CommerceApi.Models.Dtos;

namespace E_CommerceApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<ProductClass, ProductsDtos>();
            CreateMap<ProductsDtos, ProductsDtos>();


            CreateMap<ProductClass, ProductsCreateDtos>().ReverseMap();

            CreateMap<ProductClass, ProductsUpdateDtos>().ReverseMap();

        }

    }
}
