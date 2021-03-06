#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

# Copy the code into the container
WORKDIR /src
COPY ["mycocktails.api.cocktailApi.csproj", "mycocktails.api.cocktailApi/"]
COPY ["nuget.config", "mycocktails.api.cocktailApi/"]

# NuGet restore
RUN dotnet restore "mycocktails.api.cocktailApi/mycocktails.api.cocktailApi.csproj"
COPY ["./", "mycocktails.api.cocktailApi/"]

# Build the API
WORKDIR "mycocktails.api.cocktailApi"
RUN dotnet build "mycocktails.api.cocktailApi.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "mycocktails.api.cocktailApi.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mycocktails.api.cocktailApi.dll"]
