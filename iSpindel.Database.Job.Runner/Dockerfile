ARG BASE_IMAGE_ARCH="-arm64"
ARG DOTNET_ARCH="arm"

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine-slim${BASE_IMAGE_ARCH} AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine-slim${BASE_IMAGE_ARCH} AS build
ARG DOTNET_ARCH
WORKDIR /src

# just load dependencies - as changes mostly occur in source code and not in dependencies, this step can be cached if seperate like this
COPY iSpindel.Database.Job.Runner/Database.Job.Runner.csproj \
     iSpindel.Database.Job.Runner.csproj
RUN dotnet restore "iSpindel.Database.Job.Runner/Database.Job.Runner.csproj"

# copy actual source code. build without restore, as is has been done in the previous step
COPY iSpindel.Database.Job.Runner iSpindel.Database.Job.Runner
WORKDIR "/src/iSpindel.Database.Job.Runner"
RUN dotnet build "iSpindel.Database.Job.Runner.csproj" -c Release -r linux-${DOTNET_ARCH} --no-restore --no-self-contained -p:PublishSingleFile=True

FROM build AS publish
ARG DOTNET_ARCH
RUN dotnet publish "iSpindel.Database.Job.Runner.csproj" --no-build -c Release -r linux-${DOTNET_ARCH} -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["iSpindel.Database.Job.Runner"]