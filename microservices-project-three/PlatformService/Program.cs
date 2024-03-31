using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Middleware;
using PlatformService.Repositories;
using PlatformService.Repositories.Interfaces;
using PlatformService.SyncDataServices.Http;

var builder = WebApplication.CreateBuilder(args);

// Data Context
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("InMen");
});

// Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Register HttpClient
builder.Services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Reigster Scopes
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();


var app = builder.Build();
app.UseMiddleware<ResponseTimeMiddleware>();
PrepDb.PrepPopulation(app);

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

