#!bin/sh
set -e

VERSION='0.1.0'

dotnet pack ${PWD}/common/mycocktails.library.common/mycocktails.library.common.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package