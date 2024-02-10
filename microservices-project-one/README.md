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

### Create Common Lib

```bash
mkdir Play.Common

mkdir src

cd src
```

```bash
dotnet new classlib -n Play.Common
```

**Publish in Local**

```bash
cd Play.Common
dotnet pack -o ../../../packages/
```

**Install From Local**

```bash
cd Play.Catalog
dotnet nuget add source ./packages -n PlayEconomyTTS
dotnet add package Play.Common

```

**Install From Nuget Gallery**

```bash
cd src
cd Play.Catalog.Service
dotnet add package Play.Common
```

### Docker setup

```bash
docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo
```

## Creating NuGet Package for Shared Lib
