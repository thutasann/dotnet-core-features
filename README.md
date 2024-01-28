# .NET CORE API FEATURES COLLECTION

This is the collection of DOTNET CORE API Features Collection. <br>
SQL files alredy included in the `sql` folder.

## Features

- [Data Structure and Algorithms](https://github.com/thutasann/dotnet-core-features/tree/master/data-structure-algo)
- [JWT Authentication](https://github.com/thutasann/dotnet-core-features/tree/master/jwt-auth)
- [Practical SingalR](https://github.com/thutasann/dotnet-core-features/tree/master/practical-signalR-mvc)

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
