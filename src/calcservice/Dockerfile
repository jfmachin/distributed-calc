FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
COPY bin/Release/net6.0/publish/ app/
WORKDIR /app
ENTRYPOINT ["dotnet", "calcservice.dll"]
# docker run -d --network mynet --name random-ops random-ops