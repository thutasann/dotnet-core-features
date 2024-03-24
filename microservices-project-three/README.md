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

### Docker Push

```bash
docker push thutasann/platformservice
```

### Docker Compose

```bash
docker-compose up --build
```

> http://localhost:5000/swagger/index.html <br/>
