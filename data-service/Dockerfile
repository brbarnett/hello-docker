FROM microsoft/aspnetcore-build:2.0

ENV DOTNET_USE_POLLING_FILE_WATCHER 1
ENV ASPNETCORE_ENVIRONMENT Development
ENV PORT 80

RUN mkdir -p /app
WORKDIR /app
COPY *.csproj /app

EXPOSE 80

ENTRYPOINT dotnet restore && dotnet watch run --configuration Debug