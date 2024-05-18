using Grpc.Core;

namespace dotnet_grpc.Services;

public class GreeterService(ILogger<GreeterService> logger) : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger = logger;

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        Console.WriteLine($"Last Name : {request.LastName}");
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name + " " + request.LastName
        });
    }

}
