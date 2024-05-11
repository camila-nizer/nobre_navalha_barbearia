# Usa a imagem base do ASP.NET Core 6.0
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5124

# Define a camada de compilação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ApiCrud/ApiCrud.csproj", "ApiCrud/"]
RUN dotnet restore "ApiCrud/ApiCrud.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ApiCrud/ApiCrud.csproj" -c Release -o /app/build

# Define a camada de publicação
FROM build AS publish
RUN dotnet publish "ApiCrud/ApiCrud.csproj" -c Release -o /app/publish

# Configura o contêiner final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApiCrud.dll"]

