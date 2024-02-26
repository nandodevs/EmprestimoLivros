# Usa a imagem base do ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 1433

# Build da aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["EmprestimoLivros/EmprestimoLivros.csproj", "EmprestimoLivros/"]
RUN dotnet restore "EmprestimoLivros/EmprestimoLivros.csproj"
COPY . .
WORKDIR "/src/EmprestimoLivros"
RUN dotnet build "EmprestimoLivros.csproj" -c Release -o /app/build

# Publicação da aplicação
FROM build AS publish
RUN dotnet publish "EmprestimoLivros.csproj" -c Release -o /app/publish

# Configuração final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmprestimoLivros.dll"]
