# escape=`
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS builder

WORKDIR /src
COPY ./src/ConsoleApiClient/ConsoleApiClient.csproj .
RUN dotnet restore

COPY ./src/ConsoleApiClient .
RUN dotnet publish

# app image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

CMD ["dotnet", "WebApiClient.dll"]

WORKDIR /dotnetapp
COPY --from=builder /src/bin/Debug/netcoreapp3.1/publish .