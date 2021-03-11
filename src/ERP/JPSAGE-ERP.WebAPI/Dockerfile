#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["src/ERP/JPSAGE-ERP.WebAPI/JPSAGE-ERP.WebAPI.csproj", "src/ERP/JPSAGE-ERP.WebAPI/"]
COPY ["src/ERP/JPSAGE-ERP.Application/JPSAGE-ERP.Application.csproj", "src/ERP/JPSAGE-ERP.Application/"]
COPY ["src/ERP/JPSAGE-ERP.Infrastructure.Data/JPSAGE-ERP.Infrastructure.Data.csproj", "src/ERP/JPSAGE-ERP.Infrastructure.Data/"]
COPY ["src/ERP/JPSAGE-ERP.Domain/JPSAGE-ERP.Domain.csproj", "src/ERP/JPSAGE-ERP.Domain/"]
COPY ["src/ERP/JPSAGE-ERP.Infrastructure.IoC/JPSAGE-ERP.Infrastructure.IoC.csproj", "src/ERP/JPSAGE-ERP.Infrastructure.IoC/"]
RUN dotnet restore "src/ERP/JPSAGE-ERP.WebAPI/JPSAGE-ERP.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/ERP/JPSAGE-ERP.WebAPI"
RUN dotnet build "JPSAGE-ERP.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JPSAGE-ERP.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JPSAGE-ERP.WebAPI.dll"]
