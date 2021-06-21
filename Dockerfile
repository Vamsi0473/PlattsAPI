#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["PlattsAPI/PlattsAPI.csproj", "PlattsAPI/"]
RUN dotnet restore "PlattsAPI/PlattsAPI.csproj"
COPY . .
WORKDIR "/src/PlattsAPI"
RUN dotnet build "PlattsAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlattsAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlattsAPI.dll"]