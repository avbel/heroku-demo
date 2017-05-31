# run `dotnet publish -c Release` before build this Dockerfile
FROM microsoft/aspnetcore:1.1.2-jessie
WORKDIR /app
COPY ./bin/Release/netcoreapp1.1/publish .
ENTRYPOINT ["dotnet", "heroku_demo.dll"]
