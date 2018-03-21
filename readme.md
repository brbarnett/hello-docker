# Hello Docker

Note: this repo was tested using Docker v17.12.0-ce

## Getting started

Run the following commands to start the included containers:

### api container

Note: this project was tested using Node.js v8.10.0

```
cd api
docker build -t api .
docker run -d -p 8080:8080 api
```

Navigate to http://localhost:8080/

### data-service container

Note: this project was tested using dotnet runtime v2.0.6, SDK v2.1.101

```
cd data-service
docker build -t data-service .
docker run -d -p 8081:5000 data-service
```

Navigate to http://localhost:5000/api/values