# The current .net 5.0 runtime base image from docker hub
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
# Setting the current working directory to the app directory in base image.
WORKDIR /app

# Copying all the project files from their local directories into their respective directories in the image.
COPY *.sln .
COPY ["UsersService.Api/*.csproj", "./UsersService.Api/"]
COPY UsersService.Data/*.csproj ./UsersService.Data/
COPY UsersService.Domain/*.csproj ./UsersService.Domain/
COPY UsersService.Library/*.csproj ./UsersService.Library/
COPY UsersService.UnitTests/*.csproj ./UsersService.UnitTests/

# Building/resotirng the copied project files in the image.
RUN dotnet restore

# Copying the all dependencies from the local directories to their respective directories in the image.
COPY UsersService.Api/. ./UsersService.Api/
COPY UsersService.Data/. ./UsersService.Data/
COPY UsersService.Domain/. ./UsersService.Domain/
COPY UsersService.Library/. ./UsersService.Library/

# Navigating and setting the work directory to the directory where executable project (program) is located within the image.
WORKDIR /app/UsersService.Api

# Publishing the project in the image.
RUN dotnet publish -c Release -o out

# Getting a runtime to execute the published application version.
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

# Navigating back to the main app directory in image.
WORKDIR /app

# Copying files from the build environment to the published version in image.
COPY --from=build-env /app/UsersService.Api/out .

# Declaring the entry point to execute the application from in the image.
ENTRYPOINT ["dotnet", "UsersService.Api.dll"]