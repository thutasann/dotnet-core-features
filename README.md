# C# & .NET CORE API FEATURES COLLECTION

This is the collection of C# Fundamentals & DOTNET CORE API Features Collection. <br/>
Typescript Data Structure and Algorithms are also included to compare DSA between C# and Typescript.

## Tech Stacks / Tools

-   .NET Core
-   EF Core
-   Mysql
-   MongoDB
-   Docker
-   Nodejs
-   Typescript

## Features

| Topic                                   | Source                                                                                                      | Type             |
| --------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ---------------- |
| Data Structure and Algorithm            | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/data-structure-algo)                 | C# DSA           |
| Advanced C#                             | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/advanced-c#)                         | Advanced C#      |
| TypeScript Data Structure and Algorithm | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/typescript-data-structure-algorithm) | TypeScript DSA   |
| JWT Authentication                      | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/jwt-auth)                            | Auth             |
| Practical SingalR                       | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/practical-signalR-mvc)               | WebSocket        |
| SignalR Nextjs Simple Chat app          | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/signalR-nextjs-chat)                 | WebSocket        |
| Send Email With MailKit & SMTP          | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/email-mailkit-smtp)                  | Email            |
| EF Core Relationshipts                  | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/ef-core-relationships)               | Ef-Core          |
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

### EF Database Migration

-   Replace `DefaultConnection` in `ConnectionStrings` with your real one.

```bash
dotnet tool install --global dotnet-ef --version 7.*
```

```bash
dotnet ef migrations add init
```

```bash
dotnet ef database update
```

### Dotnet Certificates

```bash
dotnet dev-certs https --trust
```
