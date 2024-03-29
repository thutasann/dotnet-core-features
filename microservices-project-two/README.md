# .NET Microservices Project Two

This Project is from the [Introduction to .NET Microservices ](https://www.youtube.com/watch?v=Nw4AZs1kLAs). and The system is Ecommerce System.

## TechStacks

-   EF Core
-   MySql
-   Azure Message Bus
-   Identity Framwork Core

## Overview / Microservice Application Flow

![Overview](./examples/overview.png)
![App Flow](./examples/app-flow.png)

## Scripts

### Create new Solution

```bash
dotnet new sln -n Mango
```

### Createing API Service

```bash
cd Services

dotnet new webapi -o <project-name>
```

### Dotnet Restore

```bash
cd <dir>

dotnet restore
```

### Creating MVC

```bash
cd Frontend

dotnet new mvc -o Mango.Web
```

### EF Database Migration

```bash
dotnet tool install --global dotnet-ef --version 7.*
```

```bash
dotnet ef migrations add init
```

```bash
dotnet ef database update
```
