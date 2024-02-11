using Play.Inventory.Service.Middlewares;
using Play.Common.MongoDB;
using Play.Inventory.Service.Entities;

var builder = WebApplication.CreateBuilder(args);

// Configuration
builder.Services.AddMongo().AddMongoRepository<InventoryItem>("inventoryitems");

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
