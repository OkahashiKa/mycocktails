#!bin/sh
set -e

CLI_VERSION=v4.3.1

if [ $# -ne 1 ]; then
    echo "Useges: sh ./generator.sh API_NAME"
    echo "API_NAME is 10.swagger/[SWAGGER DIR]"
    exit 1
fi

API_NAME=$1

# Remove work directory.
rm -rf ${PWD}/${API_NAME}/library
rm -rf ${PWD}/${API_NAME}/api
rm -rf ${PWD}/${API_NAME}/typescript-angular

# grep target yaml version.
export VERSION=`grep version ${API_NAME}/openapi.yaml | sed -e "s/version: //" | sed -e "s/ //g"`

# nameing api package.
ASP_PACKAGE_BASE=mycocktails.library.
ASP_API_BASE=mycocktails.api.
ASP_API_NAME=${API_NAME}Api
ASP_PACKAGE_NAME=${ASP_PACKAGE_BASE}${ASP_API_NAME}
ASP_API_NAME_FULL=${ASP_API_BASE}${ASP_API_NAME}

# nameing npm package.
NPM_BASE=@mycocktails/ng-
NPM_API_NAME=${API_NAME}api
NPM_API_POSTFIX=-service
NPM_NAME=${NPM_BASE}${NPM_API_NAME}${NPM_API_POSTFIX}

# generate api library.
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/library \
--additional-properties=packageVersion=${VERSION} \
--additional-properties=packageName=${ASP_PACKAGE_NAME} \
--additional-properties=packageTitle=${API_NAME} \
-c /local/build/aspnetcore.library.json

# pack api library.
dotnet pack ${PWD}/${API_NAME}/library/src/${ASP_PACKAGE_NAME}/${ASP_PACKAGE_NAME}.csproj \
-p:PackageVersion=${VERSION} -o ${PWD}/Package

# generate api stub.
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/api \
--additional-properties=packageVersion=${VERSION} \
--additional-properties=packageName=${ASP_API_NAME_FULL} \
--additional-properties=packageTitle=${API_NAME} \
-c /local/build/aspnetcore.json

# generate angular package.
docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli:${CLI_VERSION} generate \
-i /local/${API_NAME}/openapi.yaml -g typescript-angular -o /local/${API_NAME}/typescript-angular \
--additional-properties=npmVersion=${VERSION} \
--additional-properties=npmName=${NPM_NAME} \
-c /local/build/typescript-angular.json

# copy .npmrc file.
cp build/auth.linux.npmrc ./${API_NAME}/typescript-angular/.npmrc


cd ./${API_NAME}/typescript-angular

# install npm package
npm install -g npm-check-updates
ncu -u
npm install
cat package.json
npm run build

# push npm package.
npm publish dist

