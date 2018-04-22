FROM microsoft/aspnetcore:2.0.7 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0.7-2.1.105 AS build
WORKDIR /src
COPY . .
RUN dotnet restore
#WORKDIR /src/src/Services/Experts/Experts.API
RUN dotnet build --no-restore -c Release -o /app

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Experts.API.dll"]
