using Play.Catalog.Service.Entities;
using Play.Catalog.Service.Middlewares;
using Play.Catalog.Service.Repositories;
using Play.Catalog.Service.Settings;

ServiceSettings? serviceSettings = new();

var builder = WebApplication.CreateBuilder(args);

// Configuration
serviceSettings = builder.Configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();
builder.Services.AddMongo().AddMongoRepository<Item>("items"); // From Extension Method

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
