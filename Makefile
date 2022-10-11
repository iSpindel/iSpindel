.PHONY: start stop quickstart logs cleanup
registry := raspberrypi:5000
quiet = -q
platform_docker = ""
platform_dotnet = ""
platform_image = ""
version = v1.0

build-all: amd64 build-server build-webapp build-generator \
	arm32 build-server build-webapp build-generator \
	arm64 build-server build-webapp build-generator

build-core: amd64 build-server build-webapp \
	arm32 build-server build-webapp \
	arm64 build-server build-webapp

verbose: quiet = ""
LS_OUT = $(shell ls)

build-server-x64:   amd64 build-server
build-server-arm32: arm32 build-server
build-server-arm64: arm64 build-server

build-webapp-x64:   amd64 build-webapp
build-webapp-arm32: arm32 build-webapp
build-webapp-arm64: arm64 build-webapp

build-generator-x64:   amd64 build-generator
build-generator-arm32: arm32 build-generator
build-generator-arm64: arm64 build-generator


arm32:
	platform_docker ="linux/arm/v7"
	platform_dotnet ="arm"
	platform_image ="-arm32v7"
	platform_tag = "arm32"

arm64:
	platform_docker ="linux/arm64"
	platform_dotnet ="arm64"
	platform_image ="-arm64v8"
	platform_tag = "arm64"

amd64:
	platform_docker ="linux/amd64"
	platform_dotnet ="x64"
	platform_image = ""
	platform_tag = "x64"



start:
	docker compose -d -f Docker/docker-compose.yml --project-directory Docker up

logs:
	docker compose logs -f

stop:
	docker compose down

cleanup:
	docker compose down --rmi all --volumes --remove-orphans
	
build-server:
	docker buildx build $(quiet) --push \
	--platform=$(platform_docker) \
	--build-arg DOTNET_ARCH=$(platform_dotnet) \
	--build-arg BASE_IMAGE_ARCH=$(platform_image) \
	-f Docker/Dockerfile_data-ingestor \
	-t $(registry)/ispindel-server:$(platform_tag)-$(version) .

build-webapp:
	docker buildx build $(quiet) --push \
	--platform=$(platform_docker) \
	--build-arg DOTNET_ARCH=$(platform_dotnet) \
	--build-arg BASE_IMAGE_ARCH=$(platform_image) \
	-f Docker/Dockerfile_webapp \
	-t $(registry)/ispindel-webapp:$(platform_tag)-$(version) .

build-generator:
	docker buildx build $(quiet) --push \
	--platform=$(platform_docker) \
	--build-arg DOTNET_ARCH=$(platform_dotnet) \
	--build-arg BASE_IMAGE_ARCH=$(platform_image) \
	-f ../MQTT-Generator/Dockerfile \
	-t $(registry)/mqtt-producer:$(platform_tag)-$(version) ../MQTT-Generator