using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        /// <summary>
        /// Preparation Population
        /// </summary>
        /// <param name="app"></param>
        public static void PrepPopulation(IApplicationBuilder app, bool isProduction)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProduction);
        }

        private static void SeedData(AppDbContext? context, bool isProduction)
        {
            if (context != null && !context.Platforms.Any())
            {

                if (isProduction == true)
                {
                    Console.WriteLine("Produ Migration....");
                    try
                    {
                        context.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"====>  Could not run migration in PROD : {ex.Message}");
                    }
                }

                Console.WriteLine("==> Seeding Data");
                context.Platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("==> We already have data");
            }
        }
    }
}