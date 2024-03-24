using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformReadDto, Platform>();

            CreateMap<Platform, PlatformCreateDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}