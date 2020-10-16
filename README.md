# OnlineFurniture

## Dependency
- NetCore
- PostgreeSQl
- NPM

## PreBuild
1. install modules : npm install
2. Copy configs on Default configs to OnlineFurniture and change connection string
3. Run dotnet ef migrations add InitialCreate
4. Run dotnet ef database update