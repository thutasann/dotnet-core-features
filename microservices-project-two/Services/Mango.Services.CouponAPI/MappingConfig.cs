using AutoMapper;
using Mango.Services.CouponAPI.Dto;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI
{
    /// <summary>
    /// Mapping Config for DTO
    /// </summary>
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}