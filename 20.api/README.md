# create api by swagger
## mac
1. Write swagger yaml.
2. Put swagger yaml on /10.swagger/[api name].
3. Run generator.sh on /10.swagger.
    ``` bash
    generator.sh <api name>
    ```
4. Push the package to Azure DevOps on /10.swagger/Package.
    ```
    dotnet nuget push --source "mycocktails-artifacts" --api-key az <package-path>
    ```

## windows
1. Write swagger yaml.
2. Put swagger yaml on /10.swagger/[api name].
3. Run generator.ps1 on /10.swagger.
    ``` bash
    generator.ps1 <api name>
    ```
4. Push the package to Azure DevOps on /10.swagger/Package.
    ```
    dotnet nuget push --source "mycocktails-artifacts" --api-key az <package-path>
    ```