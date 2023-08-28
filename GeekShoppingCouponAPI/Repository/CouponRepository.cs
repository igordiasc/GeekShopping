using AutoMapper;
using GeekShoppingCouponAPI.Data.ValueObjects;
using GeekShoppingCouponAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShoppingCouponAPI.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CouponRepository(MySQLContext sqlContext, IMapper mapper)
        {
            _context = sqlContext;
            _mapper = mapper;

        }
        public async Task<CouponVO> GetCouponByCouponCode(string couponCode)
        {
            var coupon = await _context.Coupons.FirstOrDefaultAsync(c => c.CouponCode == couponCode);
            return _mapper.Map<CouponVO>(coupon);
        }
    }
}
