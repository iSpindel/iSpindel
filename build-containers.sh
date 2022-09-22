#!/bin/bash

echo "Building iSpindel.Server, the Data Ingestor"
docker build -f Docker/Dockerfile_data-ingestor . -t localhost:5000/ispindel-server:v1.0
docker push localhost:5000/ispindel-server:v1.0

echo "Building iSpindel.App, the Webservie"
docker build -f Docker/Dockerfile_webapp . -t localhost:5000/ispindel-webapp:v1.0
docker push localhost:5000/ispindel-webapp:v1.0