# Building the images
Always execute the commands from the root folder

## Data Ingestor
```
docker build -f Docker/Dockerfile_data-ingestor . -t ispindel-server:v1.0 --progress=plain
```

## WebApp 
```
docker build -f Docker/Dockerfile_webapp . -t ispindel-webapp:v1.0 --progress=plain
```

# Docker compose
```
# just start database and mqtt
docker compose -f Docker/docker-compose.yml --profile services up -d

# database, mqtt and mqtt-generator
docker compose -f Docker/docker-compose.yml --profile testing up -d

# webapp and data-ingestor
docker compose -f Docker/docker-compose.yml --profile dotnet up -d
```