using GeekShoppingCouponAPI.Data.ValueObjects;

namespace GeekShoppingCouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCouponCode(string couponCode);
    }
}
