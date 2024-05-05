# C# & .NET CORE API FEATURES COLLECTION

This is the collection of C# Fundamentals & DOTNET CORE API Features Collection. <br/>
Typescript Data Structure and Algorithms are also included to compare DSA between C# and Typescript.

## Tech Stacks / Tools

-   .NET Core
-   EF Core
-   SignalR
-   Mysql
-   MongoDB
-   Docker, K8S, RabbitMQ
-   Typescript

## Features

| Topic                                   | Source                                                                                                      | Type             |
| --------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ---------------- |
| Data Structure and Algorithm            | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/data-structure-algo)                 | C# DSA           |
| Advanced C#                             | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/advanced-c#)                         | Advanced C#      |
| Advanced LINQ                           | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/advanced-LINQ)                       | Advanced LINQ    |
| TypeScript Data Structure and Algorithm | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/typescript-data-structure-algorithm) | TypeScript DSA   |
| JWT Authentication                      | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/jwt-auth)                            | Auth             |
| Practical SingalR                       | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/practical-signalR-mvc)               | WebSocket        |
| SignalR Nextjs Simple Chat app          | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/signalR-nextjs-chat)                 | WebSocket        |
| SignalR Blazor TicTacToe                | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/signalR-blazor-tictactoe)            | WebSocket        |
| Send Email With MailKit & SMTP          | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/email-mailkit-smtp)                  | Email            |
| EF Core Relationships                   | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/ef-core-relationships)               | EF Core          |
| Game System MicroService Project        | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/microservices-project-one)           | MicroService ⭐️ |
| Ecommerce System MicroService Project   | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/microservices-project-two)           | MicroService ⭐️ |
| Platform System MicroService Project    | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/microservices-project-three)         | MicroService ⭐️ |

## Scripts

### Create Dotnet project

**Web API**

```bash
dotnet new webapi -o <project-name>
```

**Console App**

```bash
dotnet new console -n <project-name>
```

**MVC**

```bash
dotnet new mvc -o <project-name>
```

**Lib**

```bash
dotnet new classlib -n Play.Common
```

### Dotnet Watch Run

```bash
cd <project-dir>
```

```bash
dotnet watch run
```

### Dotnet Create Solution

```
dotnet new sln -n MySolution
```

### Add Proj to Solution

```
dotnet sln add Project1/Project1.csproj
dotnet sln add Project2/Project2.csproj
```

**Reference project (P2P) **

```bash
dotnet add reference ../Play.Catalog.Contracts/Play.Catalog.Contracts.csproj
```

### Dotnet Create Blazor

```bash
dotnet new blazor -o <ProjectName>
```

### Dotnet Create Blazor WebAssembly

```bash
dotnet new blazorwasm -o <ProjectName>
```

### EF Database Migration

-   Replace `DefaultConnection` in `ConnectionStrings` with your real one.

```bash
dotnet tool install --global dotnet-ef --version 7.*
```

```bash
dotnet ef migrations add Init
```

```bash
dotnet ef database Update
```

### Dotnet Certificates

```bash
dotnet dev-certs https --trust
```
