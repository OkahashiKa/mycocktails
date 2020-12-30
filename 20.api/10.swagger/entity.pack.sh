#!bin/sh
set -e

VERSION=$1

#dotnet ef dbcontext scaffold "Server=ec2-54-159-107-189.compute-1.amazonaws.com;Port=5432;Database=d7th5desesjlf8;Username=krtcueuzjvyqxw;Password=a81b64b6a8da2db3765f83c139aef195cbd6d5740f617bb4b1268e680e85a75d;sslmode=require" \
#Npgsql.EntityFrameworkCore.PostgreSQL \
#--project ${PWD}/entity/mycocktails.library.entity/mycocktails.library.entity.csproj
#--context-dir ${PWD}/entity/mycocktails.library.entity/Models \
#--output-dir ${PWD}/entity/mycocktails.library.entity/Models \
#--context CocktailsDBContext

dotnet pack ${PWD}/entity/mycocktails.library.entity/mycocktails.library.entity.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package