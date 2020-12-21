#!bin/sh
set -e

VERSION=$1

dotnet pack ${PWD}/entity/mycocktails.library.entity/mycocktails.library.entity.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package