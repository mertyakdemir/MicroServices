FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/SharedLib/*.csproj Shared/SharedLib/
COPY Frontend/Web/*.csproj Frontend/Web/
RUN dotnet restore Frontend/Web/*.csproj
COPY . .
RUN dotnet publish Frontend/Web/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","Web.dll" ]