#!bin/sh
set -e

CLI_VERSION=v4.3.1

if [ $# -ne 1 ]; then
    echo "Useges: sh ./generator.sh API_NAME"
    echo "API_NAME is 10.swagger/[SWAGGER DIR]"
    exit 1
fi

API_NAME=$1

rm -rf ${PWD}/${API_NAME}/library
rm -rf ${PWD}/${API_NAME}/api

export VERSION=`grep version ${API_NAME}/openapi.yaml | sed -e "s/version: //" | sed -e "s/ //g"`
ASP_PACKAGE_BASE=mycocktails.library.
ASP_API_NAME=${API_NAME}Api
ASP_PACKAGE_NAME=${ASP_PACKAGE_BASE}${ASP_API_NAME}

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/library \
--additional-properties=packageVersion=${VERSION} \
--additional-properties=packageName=${ASP_PACKAGE_NAME} \
--additional-properties=packageTitle=${API_NAME} \
-c /local/build/aspnetcore.library.json

dotnet pack ${PWD}/${API_NAME}/library/src/${ASP_PACKAGE_NAME}/${ASP_PACKAGE_NAME}.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/api \
--additional-properties=packageVersion=${VERSION} \
--additional-properties=packageName=${ASP_PACKAGE_NAME} \
--additional-properties=packageTitle=${API_NAME} \
-c /local/build/aspnetcore.json
