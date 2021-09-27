#!bin/sh
set -e

VERSION=$1

rm -rf ${PWD}/common/mycocktails.library.entity/Models

dotnet ef dbcontext scaffold "Server=localhost;Port=5432;Database=mycocktails-db;Username=postgress;Password=passwd" \
Npgsql.EntityFrameworkCore.PostgreSQL \
--project ${PWD}/common/mycocktails.library.entity/mycocktails.library.entity.csproj \
--context-dir ${PWD}/common/mycocktails.library.entity/Models \
--output-dir ${PWD}/common/mycocktails.library.entity/Models \
--context MyCocktailsDBContext

dotnet pack ${PWD}/common/mycocktails.library.entity/mycocktails.library.entity.csproj -p:PackageVersion=${VERSION} -o ${PWD}/Package
