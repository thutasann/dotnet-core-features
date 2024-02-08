# .NET Microservices Project One

This Project is from the [.NET Microservices](https://www.youtube.com/watch?v=CqCDOosvZIk&t=673s). and The system is `Play Economy` Game system.

## Tech Stacks

- MongoDB
- Docker
- RabbitMQ

## High Level Architecture

![High Level Architecture](examples/high-level.png)

### Create Microservices

```bash
mkdir Play.Catalog

mkdir src

cd src
```

```bash
dotnet new webapi -n Play.Catalog.Service
```

### Docker setup

```bash
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
```
