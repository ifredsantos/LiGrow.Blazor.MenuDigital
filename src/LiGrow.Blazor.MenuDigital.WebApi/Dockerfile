FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# CORREÇÃO AQUI — apenas 1 nível de 'src'
COPY ["LiGrow.Blazor.MenuDigital.WebApi/LiGrow.Blazor.MenuDigital.WebApi.csproj", "LiGrow.Blazor.MenuDigital.WebApi/"]
RUN dotnet restore "LiGrow.Blazor.MenuDigital.WebApi/LiGrow.Blazor.MenuDigital.WebApi.csproj"

COPY . .
WORKDIR "/src/LiGrow.Blazor.MenuDigital.WebApi"
RUN dotnet build "LiGrow.Blazor.MenuDigital.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "LiGrow.Blazor.MenuDigital.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LiGrow.Blazor.MenuDigital.WebApi.dll"]
