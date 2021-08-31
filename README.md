Projeto final da disciplina de Programação em Ambiente WEB II

# Running Front-End application
1. run yarn on project folder to install dependencies
2. run yarn start

# Running Back-End application


# Adding Migrations to Project
1. Go to Infrastructure project folder
2. Run dotnet ef --startup-project ..\Pet.API\Pet.API.csproj --project .\Pet.Infrastructure.csproj migrations add [MigrationName]
3. Run dotnet ef --startup-project ..\Pet.API\Pet.API.csproj --project .\Pet.Infrastructure.csproj database update