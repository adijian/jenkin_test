FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet build "test1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test1.dll"]