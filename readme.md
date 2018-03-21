# Hello Docker

Note: this repo was tested using Docker v17.12.0-ce

## Getting started

Run the following commands to start the included containers:

### api container
```
cd api
docker build -t api .
docker run -d -p 8080:8080 api
```

