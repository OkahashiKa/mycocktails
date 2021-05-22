$CLI_VERSION="v4.3.1"

if ($args.Length -ne 1)
{
    echo "Useges:./generator.ps1 API_NAME"
    echo "API_NAME is 10.swagger/[SWAGGER DIR]"
    exit
}

$API_NAME=$Args[0]

# Remove work directory.
if(Test-Path ${PWD}/${API_NAME}/library){
  rm ${PWD}/${API_NAME}/library -Recurse
}
if(Test-Path ${PWD}/${API_NAME}/api){
  rm ${PWD}/${API_NAME}/api -Recurse
}
if(Test-Path ${PWD}/${API_NAME}/typescript-angular){
  rm ${PWD}/${API_NAME}/typescript-angular -Recurse
}

# grep target yaml version.
$VERSION=Select-String "version" ${PWD}/${API_NAME}/openapi.yaml
$env:VERSION=$VERSION
$env:VERSION=$env:VERSION.Substring($env:VERSION.Length - 5, 5);

# nameing api package.
$ASP_PACKAGE_BASE="mycocktails.library."
$ASP_API_BASE="mycocktails.api."
$ASP_API_NAME=${API_NAME} + "Api"
$ASP_PACKAGE_NAME=${ASP_PACKAGE_BASE} + ${ASP_API_NAME}
$ASP_API_NAME_FULL=${ASP_API_BASE} + ${ASP_API_NAME}

# nameing npm package.
$NPM_BASE="@mycocktails/ng-"
$NPM_API_NAME=${API_NAME} + "api"
$NPM_API_POSTFIX="-service"
$NPM_NAME=${NPM_BASE} + ${NPM_API_NAME} + ${NPM_API_POSTFIX}

# generate api library.
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate `
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/library `
--additional-properties=packageVersion=$env:VERSION `
--additional-properties=packageName=${ASP_PACKAGE_NAME} `
--additional-properties=packageTitle=${API_NAME} `
-c /local/build/aspnetcore.library.json

# # pack api library.
dotnet pack ${PWD}/${API_NAME}/library/src/${ASP_PACKAGE_NAME}/${ASP_PACKAGE_NAME}.csproj `
-p:PackageVersion=$env:VERSION -o ${PWD}/Package

# generate api stub.
docker run --rm -v "${PWD}:/local" openapitools/openapi-generator-cli:${CLI_VERSION} generate `
-i /local/${API_NAME}/openapi.yaml -g aspnetcore -o /local/${API_NAME}/api `
--additional-properties=packageVersion=$env:VERSION `
--additional-properties=packageName=${ASP_API_NAME_FULL} `
--additional-properties=packageTitle=${API_NAME} `
-c /local/build/aspnetcore.json

# generate angular package.
docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli:${CLI_VERSION} generate `
-i /local/${API_NAME}/openapi.yaml -g typescript-angular -o /local/${API_NAME}/typescript-angular `
--additional-properties=npmVersion=$env:VERSION `
--additional-properties=npmName=${NPM_NAME} `
-c /local/build/typescript-angular.json

# copy .npmrc file.
cp build/auth.windows.npmrc ./${API_NAME}/typescript-angular/.npmrc

# get pat.
vsts-npm-auth -config .npmrc

# install npm package
cd ./${API_NAME}/typescript-angular
npm install -g npm-check-updates
ncu -u
npm install
npm run build

# push npm package.
npm publish

# move directry.
cd ../../Package