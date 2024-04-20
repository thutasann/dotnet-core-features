using AutoMapper;
using Grpc.Core;
using PlatformService.Repositories.Interfaces;

namespace PlatformService.SyncDataServices.Grpc
{
    /// <summary>
    /// gRPC Platform Service
    /// </summary>
    public class GrpcPlatformService : GrpcPlatform.GrpcPlatformBase
    {

        private readonly IPlatformRepo _repo;
        private readonly IMapper _mapper;

        public GrpcPlatformService(IPlatformRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public override async Task<PlatformResponse> GetAllPlatforms(GetAllRequest request, ServerCallContext context)
        {
            var response = new PlatformResponse();
            var platforms = await _repo.GetAllPlatformsAsync();

            foreach (var plat in platforms)
            {
                response.Platform.Add(_mapper.Map<GrpcPlatformModel>(plat));
            }

            return response;
        }
    }
}