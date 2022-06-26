#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["nuget.config", "."]
COPY ["src/UserInterface/UserInterface.csproj", "src/UserInterface/"]
RUN dotnet restore "src/UserInterface/UserInterface.csproj"
COPY . .
WORKDIR "/src/src/UserInterface"
RUN dotnet build "UserInterface.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UserInterface.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserInterface.dll"]