using dotnet_pokemon_review.Middleware;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using Play.Catalog.Service.Interfaces;
using Play.Catalog.Service.Repositories;
using Play.Catalog.Service.Settings;

ServiceSettings? serviceSettings = new();

var builder = WebApplication.CreateBuilder(args);

// Bson Serializer
BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));

// Configuration
serviceSettings = builder.Configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();
builder.Services.AddSingleton(serviceProvider =>
{
    var mongoDbSettings = builder.Configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
    var mongoClient = new MongoClient(mongoDbSettings?.ConnectionString);
    return mongoClient.GetDatabase(serviceSettings?.ServiceName);
});

// DI
builder.Services.AddSingleton<IItemsRepository, ItemsRepository>();

// Controllers
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
app.UseMiddleware<ResponseTimeMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
