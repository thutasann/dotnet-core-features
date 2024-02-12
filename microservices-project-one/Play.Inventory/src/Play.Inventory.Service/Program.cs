using Play.Inventory.Service.Middlewares;
using Play.Common.MongoDB;
using Play.Inventory.Service.Entities;
using Play.Inventory.Service.Clients;
using Polly;
using Polly.Timeout;

var builder = WebApplication.CreateBuilder(args);

// Configuration
builder.Services.AddMongo().AddMongoRepository<InventoryItem>("inventoryitems");

Random jitterer = new();

// Http Client Registration
builder.Services.AddHttpClient<CatalogClient>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5008");
})
.AddTransientHttpErrorPolicy(transient => transient.Or<TimeoutRejectedException>().WaitAndRetryAsync( // exponential backoff
    5,
    retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)) + TimeSpan.FromMilliseconds(jitterer.Next(0, 1000)),
    onRetry: (outcome, timespan, retryAttempt) =>
    {
#pragma warning disable ASP0000 // Do not call 'IServiceCollection.BuildServiceProvider' in 'ConfigureServices'
        var serviceProvider = builder.Services.BuildServiceProvider();
#pragma warning restore ASP0000 // Do not call 'IServiceCollection.BuildServiceProvider' in 'ConfigureServices'
        serviceProvider.GetService<ILogger<CatalogClient>>()?
            .LogWarning($"Delaying for {timespan.TotalSeconds} seconds, then making retry {retryAttempt}"); // Dont use in Production
    }
))
.AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(1)); // for retries

// Controllers
builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});

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
