FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Osz2Decryptor.CLI/Osz2Decryptor.CLI.csproj", "Osz2Decryptor.CLI/"]
RUN dotnet restore "Osz2Decryptor.CLI/Osz2Decryptor.CLI.csproj"
COPY . .
WORKDIR "/src/Osz2Decryptor.CLI"
RUN dotnet build "Osz2Decryptor.CLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Osz2Decryptor.CLI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Osz2Decryptor.CLI.dll"]
