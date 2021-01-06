#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

# Container we use for final publish
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Build container
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build

# Copy the code into the container
WORKDIR /src
COPY ["src/mycocktails.library.cocktailApi/mycocktails.library.cocktailApi.csproj", "mycocktails.library.cocktailApi/"]

# NuGet restore
RUN dotnet restore "mycocktails.library.cocktailApi/mycocktails.library.cocktailApi.csproj"
COPY ["src/mycocktails.library.cocktailApi/", "mycocktails.library.cocktailApi/"]

# Build the API
WORKDIR "mycocktails.library.cocktailApi"
RUN dotnet build "mycocktails.library.cocktailApi.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "mycocktails.library.cocktailApi.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mycocktails.library.cocktailApi.dll"]
