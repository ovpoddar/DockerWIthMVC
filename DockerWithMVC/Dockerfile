FROM  mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app/src
COPY ["DockerWithMVC.csproj", "./"]
RUN dotnet restore "DockerWithMVC.csproj"
COPY . .
WORKDIR /app/src/
RUN dotnet build "DockerWithMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerWithMVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerWithMVC.dll"]
