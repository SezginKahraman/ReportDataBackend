#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["ReportDataBackend.API/ReportDataBackend.API.csproj", "ReportDataBackend.API/"]
COPY ["ReportDataBackend.Business/ReportDataBackend.Business.csproj", "ReportDataBackend.Business/"]
COPY ["ReportDataBackend.DataAccess/ReportDataBackend.DataAccess.csproj", "ReportDataBackend.DataAccess/"]
COPY ["ReportDataBackend.Entity/ReportDataBackend.Entity.csproj", "ReportDataBackend.Entity/"]
RUN dotnet restore "./ReportDataBackend.API/./ReportDataBackend.API.csproj"
COPY . .
WORKDIR "/src/ReportDataBackend.API"
RUN dotnet build "./ReportDataBackend.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ReportDataBackend.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReportDataBackend.API.dll"]