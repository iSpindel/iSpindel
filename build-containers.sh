#!/bin/bash

CURRENT_ARCH=$(uname -m)
BASE_IMAGE_ARCH=
DOTNET_ARCH=
REGISTRY=localhost:5000

if [[ "$CURRENT_ARCH" == *"x86"* ]]; then
    BASE_IMAGE_ARCH=""
    DOTNET_ARCH="x64"
fi

if [[ "$CURRENT_ARCH" == *"arm"* ]]; then
    BASE_IMAGE_ARCH="-arm32v7"
    DOTNET_ARCH="arm"
fi

echo "Building for $CURRENT_ARCH, Base-Image: $BASE_IMAGE_ARCH, Dotnet: $DOTNET_ARCH"

echo "Building iSpindel.Server, the Data Ingestor"
docker build --build-arg DOTNET_ARCH=$DOTNET_ARCH --build-arg BASE_IMAGE_ARCH=$BASE_IMAGE_ARCH -f Docker/Dockerfile_data-ingestor . -t $REGISTRY/ispindel-server:v1.0
docker push $REGISTRY/ispindel-server:v1.0

echo "Building iSpindel.App, the Webservice"
docker build --build-arg DOTNET_ARCH=$DOTNET_ARCH --build-arg BASE_IMAGE_ARCH=$BASE_IMAGE_ARCH -f Docker/Dockerfile_webapp . -t $REGISTRY/ispindel-webapp:v1.0
docker push $REGISTRY/ispindel-webapp:v1.0
