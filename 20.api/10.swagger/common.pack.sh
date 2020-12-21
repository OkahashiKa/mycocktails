#!bin/sh
set -e

VERSION=$1

dotnet pack ${PWD}/common/mycocktails.library.common/mycocktails.library.common.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package