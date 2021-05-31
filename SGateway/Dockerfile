FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY  SGateway/*.csproj  SGateway/
RUN dotnet restore SGateway/*.csproj
COPY . .
RUN dotnet publish SGateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","SGateway.dll" ]