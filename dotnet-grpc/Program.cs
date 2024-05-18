using dotnet_grpc.Data;
using dotnet_grpc.Middleware;
using dotnet_grpc.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!);
});


builder.Services.AddGrpc().AddJsonTranscoding();

var app = builder.Build();

app.UseMiddleware<ResponseTimeMiddleware>();
app.MapGrpcService<GreeterService>();
app.MapGrpcService<TodoService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
