#!bin/sh
set -e

CLI_VERSION=v4.3.1

if [ $# -ne 1 ]; then
    echo "Useges: sh ./generator.sh API_NAME"
    echo "API_NAME is 10.swagger/[SWAGGER DIR]"
    exit 1
fi
API_NAME=$1

rm -rf ${PWD}/${API_NAME}/aspnetcore

ASP_PACKAGE_BASE=mycocktail.library.
ASP_API_NAME=${API_NAME}Api
ASP_PACKAGE_NAME=${ASP_PACKAGE_BASE}${ASP_API_NAME}
ASP_PACKAGE_TITLE=${ASP_API_NAME}

docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/aspnetcore \
--additional-properties=packageVersion=0.1.0 \
--additional-properties=packageName=${ASP_PACKAGE_NAME} \
--additional-properties=packageTitle=${API_NAME} \
-c /local/build/aspnetcore.json