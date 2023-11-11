# Learn DAPR in 2024

I am learning DAPR from multiple books, video courses, and websites.

## Few commands to get started with DAPR

```bash
darp --version

darp --help

darp init

dapr init -k  # For Kubernetes

dapr status -k

dapr dashboard
```

## First Project in DAPR

```bash
dotnet new webapi -o dapr.microservice.webapi

dotnet add package Dapr.AspNetCore --version 1.12.0

# launch Dapr
dapr run --app-id helloworld --app-port 5000 --dapr-http-port 5010 -- dotnet run --project ./dapr.microservice.webapi/dapr.microservice.webapi.csproj --urls="http://+:5000"

dapr run --app-id "helloworld" --app-port "5000" --dapr-http-port "5010" -- dotnet run --project dapr.microservice.webapi.csproj --urls="http://+:5000"


http://localhost:5010/v1.0/invoke/hello-world/method/hello

http://localhost:5010/v1.0/invoke/hello-world/method/helloworld
http://localhost:5010/v1.0/invoke/hello-world/method/get

curl -X POST http://localhost:5010/v1.0/invoke/hello-world/method/get -H "dapr-app-id: hello-world"

```
