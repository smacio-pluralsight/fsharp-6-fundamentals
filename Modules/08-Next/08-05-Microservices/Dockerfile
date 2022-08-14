FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
COPY ./bin/Debug/net6.0 .
EXPOSE 80
ENTRYPOINT ["dotnet", "api.dll"]
