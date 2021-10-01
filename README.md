# Projeto final da disciplina de Programação em Ambiente WEB II

## Integrantes:   
- FRANCISCO JOSE DAS NEVES NETO  
- MATHEUS CESAR FERNANDES NEVES  
- MURILO NOBORU HIRACAKA KAWANAMI  
- VITOR MANOEL DE ALMEIDA SILVA  

# Running Front-End application
1. run yarn on project folder to install dependencies
2. run yarn start

# Running Back-End application
1. Run Pet.API

# Adding Migrations to Project
1. Go to Infrastructure project folder
2. Run dotnet ef --startup-project ..\Pet.API\Pet.API.csproj --project .\Pet.Infrastructure.csproj migrations add [MigrationName]
3. Run dotnet ef --startup-project ..\Pet.API\Pet.API.csproj --project .\Pet.Infrastructure.csproj database update
