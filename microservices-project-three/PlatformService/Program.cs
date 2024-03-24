using Microsoft.EntityFrameworkCore;
using PlatformService.Data;
using PlatformService.Middleware;
using PlatformService.Repositories;
using PlatformService.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Data Context
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!);
});

// Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Reigster Scopes
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();

var app = builder.Build();
app.UseMiddleware<ResponseTimeMiddleware>();
PrepDb.PrepPopulation(app);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

