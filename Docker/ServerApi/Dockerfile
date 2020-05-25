# escape=`
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS builder

WORKDIR /src
COPY ./src/ServerAPI/ServerAPI.csproj .
RUN dotnet restore

COPY ./src/ServerAPI .
RUN dotnet publish

# app image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

EXPOSE 5001
CMD ["dotnet", "ServerAPI.dll"]

WORKDIR /dotnetapp
COPY --from=builder /src/bin/Debug/netcoreapp3.1/publish .