#!bin/sh
set -e

if [ $# -ne 1 ]; then
    echo "Useges: sh ./generator.sh API_NAME"
    echo "API_NAME is 10.swagger/[SWAGGER DIR]"
    exit 1
fi
API_NAME=$1

rm -rf ${PWD}/${API_NAME}/aspnetcore

docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli:v4.2.3 genarate -i /local/${API_NAME}/openapi.yml -g aspnetcore -o /local/${API_NAME}/aspnetcore -c /local/build/aspnetcore.json