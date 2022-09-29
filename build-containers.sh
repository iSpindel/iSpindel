#!/bin/bash
REGISTRY=localhost:5000
#REGISTRY=hauspi:6000

echo ">> Building iSpindel.Server, the Data Ingestor"
echo "> Step 1/2 - x86_64 Build"
docker buildx build -q --build-arg DOTNET_ARCH=x64 --build-arg BASE_IMAGE_ARCH="" -f Docker/Dockerfile_data-ingestor -t $REGISTRY/ispindel-server:v1.0 --push .

echo "> Step 2/2 - arm Build"
docker buildx build -q --platform=linux/arm/v7 --build-arg DOTNET_ARCH="arm" --build-arg BASE_IMAGE_ARCH="-arm32v7" -f Docker/Dockerfile_data-ingestor -t $REGISTRY/ispindel-server:v1.0 --push .

echo ">> Building iSpindel.App, the Webservice"
echo "> Step 1/2 - x86_64 Build"
docker buildx build -q --build-arg DOTNET_ARCH=x64 --build-arg BASE_IMAGE_ARCH="" -f Docker/Dockerfile_webapp -t $REGISTRY/ispindel-webapp:v1.0 --push .

echo "> Step 2/2 - arm Build"
docker buildx build -q --platform=linux/arm/v7 --build-arg DOTNET_ARCH="arm" --build-arg BASE_IMAGE_ARCH="-arm32v7" -f Docker/Dockerfile_webapp -t $REGISTRY/ispindel-webapp:v1.0 --push .

if [[ -d "../MQTT-Generator" ]]; then
    echo ">> Building the MQTT Payload Generator"
    echo "> Step 1/2 - x86_64 Build"
    docker buildx build -q --build-arg DOTNET_ARCH="x64" -f ../MQTT-Generator/Dockerfile -t $REGISTRY/mqtt-producer:x64-v1.0 --push ../MQTT-Generator

    echo "> Step 2/2 - arm Build"
    docker buildx build -q --platform=linux/arm/v7 --build-arg DOTNET_ARCH="arm" --build-arg BASE_IMAGE_ARCH="-arm32v7" -f ../MQTT-Generator/Dockerfile -t $REGISTRY/mqtt-producer:arm-v1.0 --push ../MQTT-Generator
fi
