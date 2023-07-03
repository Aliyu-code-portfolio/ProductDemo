using AutoMapper;
using ProductSystem.Models;
using ProductSystem.Utilities.DTOs;

namespace TWMS.WebAPI.MapProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductToDisplayDto>();
            CreateMap<ProductToUpdateDto, Product>();
            CreateMap<ProductToCreateDto, Product>();
        }
    }
}
