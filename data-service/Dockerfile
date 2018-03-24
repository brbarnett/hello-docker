FROM microsoft/aspnetcore-build:2.0

RUN mkdir -p /app
WORKDIR /app

COPY *.csproj /app
RUN dotnet restore

COPY . /app

RUN dotnet publish -c Release -o out

ENV PORT 80
EXPOSE 80

CMD ["dotnet", "data-service.dll"]