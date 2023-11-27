#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Productos.API/Productos.API.csproj", "Productos.API/"]
COPY ["Productos.API/Productos.Infrastructure.csproj", "Productos.Infrastructure/"]
COPY ["Productos.Core/Productos.Core.csproj", "Productos.Core/"]
RUN dotnet restore "./Productos.API/./Productos.API.csproj"
COPY . .
WORKDIR "/src/Productos.API"
RUN dotnet build "./Productos.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Productos.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Productos.API.dll"]