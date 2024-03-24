# .NET Microservices Project Three

This Project is from the [.NET Microservices](https://www.youtube.com/watch?v=DgVjEo3OGBI).
It will include two services `Platform service` and `Command service`.

## Tech Stacks

-   Postgres
-   Docker
-   Kubernetes
-   gRPC (Synchronous messaging)
-   RabbitMQ (Asynchronous messaging)

## Solution Architecture

![Solution Architecture](examples/solution-architecture.png)

## Platform service Architecture

![Platform service Architecture](examples/platform-service-architecture.png)

## Command service Architecture

![Command service Architecture](examples/command-service-architecture.png)

## Docker Commands

### Docker Build

```bash
docker build -t thutasann/platformservice .
```

### Docker Run Service

```bash
docker run -p 8081:80 -e ASPNETCORE_URLS=http://+:80 thutasann/platformservice
```

###

```bash
docker-compose up --build
```

> http://localhost:8080/swagger/index.html
> http://localhost:8080/api/platform
