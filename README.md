# Learn DAPR in 2024

I am learning DAPR from multiple books, video courses, and websites.

## Few commands to get started with DAPR

```bash
darp --version

darp --help

darp init # In  Run as administrator. It should install all required components

dapr init -k  # For Kubernetes

dapr status -k

dapr dashboard
```

## First Project in DAPR

```bash
dotnet new webapi -o dapr.microservice.webapi

dotnet add package Dapr.AspNetCore --version 1.12.0

# launch Dapr
dapr run --app-id "sample" --app-port "5000" --dapr-http-port "5010" -- dotnet run --project dapr.microservice.webapi.csproj --urls="http://+:5000"

http://localhost:5000/api/helloworld/gethello # Web API

http://localhost:5010/v1.0/invoke/sample/method/api/helloworld/gethello # DAPR invoke
```

![Accessing Web API using DAPR](../learn-dapr-in-2024/documentation/images/Access_WebAPI_Using_Dapr.PNG)
