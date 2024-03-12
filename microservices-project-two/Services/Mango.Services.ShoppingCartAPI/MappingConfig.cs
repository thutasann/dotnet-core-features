using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mango.Services.ShoppingCartAPI.Dtos;
using Mango.Services.ShoppingCartAPI.Model;

namespace Mango.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}