FROM mcr.microsoft.com/dotnet/sdk:3.1 as build
WORKDIR /app
EXPOSE 80
COPY Shared/SharedLib/*.csproj Shared/SharedLib/
COPY IdentityServer/IdentityServerApp/*.csproj IdentityServer/IdentityServerApp/ 
RUN dotnet restore  IdentityServer/IdentityServerApp/*.csproj
COPY . .
RUN dotnet publish IdentityServer/IdentityServerApp/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:3.1 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","IdentityServerApp.dll" ]