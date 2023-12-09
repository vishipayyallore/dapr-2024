# eStores for Cookies

I am learning this project from multiple books, video courses, and websites.

## DAPR - Distributed Application Runtime - An event-driven, portable runtime for building microservices on cloud and edge

```powershell
dotnet new webapi -o CS.Services.Orders.Api
dotnet new webapi -o CS.Services.Reservations.Api
```

## Ways to Execute and Debug DAPR

> 1. Using DAPR CLI
> 2. Using Visual Studio Code, .NET Core Attach to Process
> 3. Leverage the Dapr extension for VS Code to scaffold the configuration files and launch the Dapr runtime

## Few commands to get started with DAPR

```bash
darp --version

darp --help

darp init # In  Run as administrator. It should install all required components

dapr uninstall --all

dapr init # For Standalone

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

dapr run --app-id "sample" --app-port "5001" --dapr-http-port "5010" --dapr-grpc-port "50010" --metrics-port "9091"

http://localhost:5000/api/helloworld/gethello # Web API

http://localhost:5010/v1.0/invoke/sample/method/api/helloworld/gethello # DAPR invoke
```

![Accessing Web API using DAPR](../learn-dapr-in-2024/documentation/images/Access_WebAPI_Using_Dapr.PNG)
