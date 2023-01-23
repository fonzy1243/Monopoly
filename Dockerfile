FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Minipoly/Minipoly.csproj", "Minipoly/"]
RUN dotnet restore "Minipoly/Minipoly.csproj"
COPY . .
WORKDIR "/src/Minipoly"
RUN dotnet build "Minipoly.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Minipoly.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Minipoly.dll"]
