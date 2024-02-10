using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Play.Common.Interfaces;
using Play.Common.Settings;

namespace Play.Common.MongoDB
{
    /// <summary>
    /// Extensions for the MongoDB Services
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Add Mongo Extension
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            // Bson Serializer
            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
            BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));

            // Specify Mongo Service
            services.AddSingleton(serviceProvider =>
            {
                var Configuration = serviceProvider.GetService<IConfiguration>()!;
                var serviceSettings = Configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();
                var mongoDbSettings = Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();

                var mongoClient = new MongoClient(mongoDbSettings?.ConnectionString);
                return mongoClient.GetDatabase(serviceSettings?.ServiceName);
            });

            return services;
        }

        /// <summary>
        /// Add MongoRepository Extension
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="services"></param>
        /// <param name="collectionName"></param>
        /// <returns></returns>
        public static IServiceCollection AddMongoRepository<T>(this IServiceCollection services, string collectionName) where T : IEntity
        {
            services.AddSingleton<IRepository<T>>(serviceProvider =>
            {
                var database = serviceProvider.GetService<IMongoDatabase>();
                if (database != null)
                {
                    return new MongoRepository<T>(database, collectionName);
                }
                throw new Exception();
            });

            return services;
        }
    }
}