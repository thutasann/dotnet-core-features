using ef_core_relationships.Data;
using ef_core_relationships.Interfaces;
using ef_core_relationships.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Data Context
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!);
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.MaxDepth = 32;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Scopes
builder.Services.AddScoped<IUserRepo, UserRepository>();
builder.Services.AddScoped<ICharacterRepo, CharacterRepository>();

var app = builder.Build();

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