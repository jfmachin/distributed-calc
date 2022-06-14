FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
COPY bin/Release/net6.0/publish/ app/
WORKDIR /app
ENTRYPOINT ["dotnet", "webapi.dll"]
# docker run -d --network mynet -p 80:80 --name webapi dist-calc-webapi