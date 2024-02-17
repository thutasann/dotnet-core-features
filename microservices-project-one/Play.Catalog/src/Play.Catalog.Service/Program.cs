using MassTransit;
using MassTransit.Definition;
using Play.Catalog.Service.Entities;
using Play.Catalog.Service.Middlewares;
using Play.Common.MassTransit;
using Play.Common.MongoDB;
using Play.Common.Settings;

ServiceSettings? serviceSettings = new();

var builder = WebApplication.CreateBuilder(args);

// Configuration
serviceSettings = builder.Configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();

// Mongo Service and MassTransit + RabbitMQ from Common Lib
builder.Services.AddMongo().AddMongoRepository<Item>("items").AddMassTransitWithRabbitMq();

// Controllers
builder.Services.AddControllers();

// Swagger
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
