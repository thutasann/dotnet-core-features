using ef_core_relationships.Data;
using ef_core_relationships.Middleware;
using ef_core_relationships.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureOptions<DatabaseOptionsSetup>();

// Data Context and database Options COnfiguration
builder.Services.AddDbContext<DataContext>(
    (serviceProvider, option) =>
    {
        var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;

        option.UseMySQL(databaseOptions.ConnectionString, action =>
        {
            action.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            action.EnableRetryOnFailure(databaseOptions.MaxRetryCount);
            action.CommandTimeout(databaseOptions.CommandTimeout);
        });

        option.EnableDetailedErrors(databaseOptions.EnableDetailedErrors);
        option.EnableSensitiveDataLogging(databaseOptions.EnableSensitiveDataLogging);
    });

// Controllers and Swagger Endpoints
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Response Time Middleware
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