#!/bin/bash
set -e

# install need package
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

# remove old models
rm -rf Models

# dotnet restore
dotnet restore

# scafold local postgres.
dotnet ef dbcontext scaffold "Server=localhost;Port=5432;Database=mycocktails_db;Username=postgres;Password=passwd;" Npgsql.EntityFrameworkCore.PostgreSQL -o Models --context mycocktaildbContext