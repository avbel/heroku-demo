# heroku_demo

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

[![Deploy](https://www.herokucdn.com/deploy/button.svg)](https://heroku.com/deploy)

Before using `Deploy to Azure` change in `azuredeploy.json` value `GIT_REPOSITORY_URL_HERE` by public url of this project on remote git server. 
Before using `Deploy to Heroku` change in `app.json` value `GIT_REPOSITORY_URL_HERE` by public url of this project on remote git server. 

## Run

### Directly

```bash
export BANDWIDTH_USER_ID=<YOUR-USER-ID>
export BANDWIDTH_API_TOKEN=<YOUR-API-TOKEN>
export BANDWIDTH_API_SECRET=<YOUR-API-SECRET>
dotnet restore # to install dependencies
dotnet run
```

### Via Docker

```bash
# to prepare image
docker build -t my-web-app-dev -f Dockerfile.Development 

# to run the app (it will listen port 8080)
docker run -i -t --rm -p 8080:5000 -e BANDWIDTH_USER_ID=<YOUR-USER-ID> -e BANDWIDTH_API_TOKEN=<YOUR-API-TOKEN> -e BANDWIDTH_API_SECRET=<YOUR-API-SECRET> my-web-app-dev 
```
