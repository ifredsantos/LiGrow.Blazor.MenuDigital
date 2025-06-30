# Imagem base de runtime (para produção)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Imagem para build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia o .csproj e faz restore
COPY ["src/LiGrow.Blazor.MenuDigital.WebApi/LiGrow.Blazor.MenuDigital.WebApi.csproj", "src/LiGrow.Blazor.MenuDigital.WebApi/"]
RUN dotnet restore "src/LiGrow.Blazor.MenuDigital.WebApi/LiGrow.Blazor.MenuDigital.WebApi.csproj"

# Copia o restante do código
COPY . .

# Compila o projeto
WORKDIR "/src/LiGrow.Blazor.MenuDigital.WebApi"
RUN dotnet build "LiGrow.Blazor.MenuDigital.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publica a aplicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "LiGrow.Blazor.MenuDigital.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Imagem final (runtime)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "LiGrow.Blazor.MenuDigital.WebApi.dll"]
