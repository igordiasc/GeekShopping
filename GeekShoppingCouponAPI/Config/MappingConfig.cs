using AutoMapper;
using GeekShoppingCouponAPI.Data.ValueObjects;
using GeekShoppingCouponAPI.Model;

namespace GeekShoppingCouponAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        { 
            var mappingConfig = new MapperConfiguration(config => {

                config.CreateMap<CouponVO, Coupon>().ReverseMap();
               
            });
            return mappingConfig;
        }
    }
}
