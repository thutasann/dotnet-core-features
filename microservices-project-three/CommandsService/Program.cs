using CommandsService.AsyncDataServices;
using CommandsService.Data;
using CommandsService.EventProcessing;
using CommandsService.Repositories;
using CommandsService.Repositories.Interfaces;
using CommandsService.SyncDataServices.Grpc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DB Context
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("InMen"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Auto Mapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// GRPC Client
builder.Services.AddScoped<IPlatformDataClient, PlatformDataClient>();

// Register EventProcess
builder.Services.AddSingleton<IEventProcessor, EventProcessor>();

// HostedService MessageBus Subscriber
builder.Services.AddHostedService<MessageBusSubscriber>();

// Register Scopes
builder.Services.AddScoped<ICommandRepo, CommandRepo>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
PrepDb.PrepPopulation(app); // PrepDB for data from gRPC
app.Run();
