# C# & .NET CORE API FEATURES COLLECTION

This is the collection of C# Fundamentals & DOTNET CORE API Features Collection. <br>
SQL files alredy included in the `sql` folder.

## Tech Stacks

- .NET Core
- EF Core
- Mysql
- Nextjs
- ShadcnUI

## Features

| Topic                            | Source                                                                                            | Type         |
| -------------------------------- | ------------------------------------------------------------------------------------------------- | ------------ |
| Data Structure and Algorithm     | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/data-structure-algo)       | DSA          |
| JWT Authentication               | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/jwt-auth)                  | Auth         |
| Practical SingalR                | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/practical-signalR-mvc)     | WebSocket    |
| SignalR Nextjs Simple Chat app   | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/signalR-nextjs-chat)       | WebSocket    |
| Send Email With MailKit & SMTP   | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/email-mailkit-smtp)        | WebSocket    |
| Game System MicroService Project | [Source](https://github.com/thutasann/dotnet-core-features/tree/master/microservices-project-one) | MicroService |

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

### Dotnet Watch Run

```bash
cd <project-dir>
```

```bash
dotnet watch run
```

### EF Database Migration

- Replace `DefaultConnection` in `ConnectionStrings` with your real one.

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
