using practical_signalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddSignalR();

var app = builder.Build();

app.MapGet("/", () => "<h1>Hello World!</h1>");
app.UseStaticFiles();

// Hubs
app.MapHub<MessageHub>("/messages");
app.Run();
