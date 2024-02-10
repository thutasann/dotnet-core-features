namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public required string Host { get; init; }
        public required int Port { get; init; }
        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}