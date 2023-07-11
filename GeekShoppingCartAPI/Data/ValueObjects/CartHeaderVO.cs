﻿using GeekShoppingCartAPI.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShoppingCartAPI.Data.ValueObjects
{
    public class CartHeaderVO
    {
        public long Id { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
    }
}
