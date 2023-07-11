using GeekShoppingCartAPI.Model;
using AutoMapper;
using GeekShoppingCartAPI.Data.ValueObjects;

namespace GeekShoppingCartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        { 
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
                config.CreateMap<CartVO, Cart>().ReverseMap();
                
            });
            return mappingConfig;
        }
    }
}
