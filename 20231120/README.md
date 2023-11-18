# Few commands to get started with DAPR

## First Project in DAPR

```bash
dotnet new webapi -o Hello.DaprWebApi

cd .\Hello.DaprWebApi\

dotnet add package Dapr.AspNetCore --version 1.12.0
```

## Execute the project

```bash
dotnet run
curl https://localhost:7090/weatherforecast
```

```bash
# launch Dapr
dapr run --app-id "sample" --app-port "5000" --dapr-http-port "5010" -- dotnet run --project dapr.microservice.webapi.csproj --urls="http://+:5000"

dapr run --app-id "sample" --app-port "5001" --dapr-http-port "5010" --dapr-grpc-port "50010" --metrics-port "9091"

http://localhost:5000/api/helloworld/gethello # Web API

http://localhost:5010/v1.0/invoke/sample/method/api/helloworld/gethello # DAPR invoke
```

![Accessing Web API using DAPR](../learn-dapr-in-2024/documentation/images/Access_WebAPI_Using_Dapr.PNG)
