using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Middleware;
using PlatformService.Repositories;
using PlatformService.Repositories.Interfaces;
using PlatformService.SyncDataServices.Http;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine("isProduction ==> " + builder.Environment.IsProduction());

if (builder.Environment.IsProduction())
{
    Console.WriteLine("--> Using InMemo Db");
    builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("InMen"));
}
else
{
    Console.WriteLine("--> Using MySQL Db");
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        options.UseMySQL(builder.Configuration.GetConnectionString("PlatformsConn")!);
    });
}

// Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Register HttpClient
builder.Services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();
Console.WriteLine($"==> Prod Command Service Endpoint : {builder.Configuration["CommandService"]}");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Reigster Scopes
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

var app = builder.Build();
app.UseMiddleware<ResponseTimeMiddleware>();

// Prepare DB
PrepDb.PrepPopulation(app, app.Environment.IsProduction());

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

