# Building the images
Always execute the commands from the root folder

## Data Ingestor
docker build -f Docker/Dockerfile_data-ingestor . -t ispindel-server:v1.0 --progress=plain

## WebApp 
docker build -f Docker/Dockerfile_webapp . -t ispindel-webapp:v1.0 --progress=plain