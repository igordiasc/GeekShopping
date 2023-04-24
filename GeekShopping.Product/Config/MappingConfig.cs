using GeekShoppingProduct.Data.ValueObjects;
using GeekShoppingProduct.Model;
using AutoMapper;

namespace GeekShoppingProduct.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        { 
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
