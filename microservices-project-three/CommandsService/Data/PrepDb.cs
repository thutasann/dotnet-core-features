using CommandsService.Models;
using CommandsService.Repositories.Interfaces;
using CommandsService.SyncDataServices.Grpc;

namespace CommandsService.Data
{

    /// <summary>
    /// Preparation DB for data from GRPC
    /// </summary>
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder)
        {
            Console.WriteLine("📊---> Preparing Population....");
            using var serviceSope = applicationBuilder.ApplicationServices.CreateScope();
            var grpcClient = serviceSope.ServiceProvider.GetService<IPlatformDataClient>();

            var platforms = grpcClient!.ReturnAllPlatforms();

            SeedData(serviceSope.ServiceProvider.GetService<ICommandRepo>()!, platforms!);
        }

        private static void SeedData(ICommandRepo repo, IEnumerable<Platform> platforms)
        {
            Console.WriteLine("Seeding new platforms....");

            foreach (var plat in platforms)
            {
                if (!repo.ExternalPlatformExists(plat.ExternalId))
                {
                    repo.CreatePlatform(plat);
                }
                repo.SaveChanges();
            }
        }
    }
}