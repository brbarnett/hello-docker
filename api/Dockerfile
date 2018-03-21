# Start from latest (at the time of authoring) Node.js LTS version
FROM node:8.10.0 AS build-env

# Add metadata
LABEL maintainer="brandon.r.barnett@gmail.com"

# Copy all source code from this directory to ./src in the container
COPY . /src

# Change working directory to /src, which now contains app code
WORKDIR /src

# Run `npm install` to install Node dependencies
RUN npm install

FROM alpine
RUN apk add --no-cache nodejs
WORKDIR /src
COPY --from=build-env /src .

# Open port 8080
EXPOSE 8080

# Add entry point for Node.js app
ENTRYPOINT ["node", "./server.js"]