FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
CMD ["dotnet", "watch", "run", "--project" , "PlatformService.csproj",  "--urls", "http://+:80"]


# COPY . ./
# RUN dotnet publish -c Release -o out

# FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS final-env
# WORKDIR /app
# COPY --from=build-env /app/out .
# ENTRYPOINT [ "dotnet", "PlatformService.dll" ]