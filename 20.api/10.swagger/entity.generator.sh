#!bin/sh
set -e

VERSION=$1

dotnet ef dbcontext scaffold "Server=localhost;Port=5432;Database=mycocktails_db;Username=postgres;Password=passwd" \
Npgsql.EntityFrameworkCore.PostgreSQL \
--project ${PWD}/entity/mycocktails.library.entity/mycocktails.library.entity.csproj \
--context-dir ${PWD}/entity/mycocktails.library.entity/Models \
--output-dir ${PWD}/entity/mycocktails.library.entity/Models \
--context CocktailsDBContext

dotnet pack ${PWD}/entity/mycocktails.library.entity/mycocktails.library.entity.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package
