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
COPY ["mycocktails.api.materialApi.csproj", "mycocktails.api.materialApi/"]
COPY ["nuget.config", "mycocktails.api.materialApi/"]

# NuGet restore
RUN dotnet restore "mycocktails.api.materialApi/mycocktails.api.materialApi.csproj"
COPY ["./", "mycocktails.api.materialApi/"]

# Build the API
WORKDIR "mycocktails.api.materialApi"
RUN dotnet build "mycocktails.api.materialApi.csproj" -c Release -o /app/build

# Publish it
FROM build AS publish
RUN dotnet publish "mycocktails.api.materialApi.csproj" -c Release -o /app/publish

# Make the final image for publishing
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mycocktails.api.materialApi.dll"]
