# Local setup commands

```bash
cd iSpindel.App
dotnet user-secrets set "Database:Username" "<username>"
dotnet user-secrets set "Database:Password" "<password>"
```

## Entity framework core commands

### Setup

Requires .NET Core 3.1

Restore dotnet tools

```bash
dotnet tool restore
```

Entity framework core is available as `dotnet ef`.

### Migrations for iSpindel.Database - iSpindelContext

```bash
cd iSpindel.Database
dotnet ef database update -c iSpindelContext --startup-project "../iSpindel.App"
```

To add a new migration:

```bash
dotnet ef migrations add <name> -c iSpindelContext --startup-project "../iSpindel.App"
```

### Migrations for iSpindel.App - ApplicationDbContext

```bash
cd iSpindel.App
dotnet ef database update -c ApplicationDbContext
```

To add a new migration:

```bash
dotnet ef migrations add <name> -c ApplicationDbContext -o Data/Migrations
```

### Postgres Database Preparations for EF

0. Install Postgres

    ```bash
    $> sudo apt update
    $> sudo apt install postgresql
    $> sudo -i -u postgres
    ```

1. Create Database User

    ```bash
    $> createuser ispindel
    ```

2. Create Database

    ```bash
    $> createdb iSpindel
    ```

3. Grant Access to User

    ```bash
    $ psql
    postgres=> alter user ispindel with encrypted password '<password>';
    postgres=> grant all privileges on database "iSpindel" to ispindel;
    ```

4. Test Access

    ```bash
    psql -h localhost -p 5432 -U ispindel -d iSpindel
    ```

5. Configure external access to database

    ```bash
    $ sudo vim /etc/postgresql/9.6/main/pg_hba.conf
    # add the following entry
    host    iSpindel        ispindel        192.168.1.0/24           trust
    ```

6. Set Postgres listen address

    ```bash
    $ sudo vim /etc/postgresql/9.6/main/postgresql.conf
    # add the following entry
    listen_adresses= '*'
    ```

7. Restart Postgres

    ```bash
    sudo service postgresql restart
    ```

### Using Postgres in Docker

0. Get Postgres Docker Container

    ```bash
    $ docker pull postgres
    $ docker run --name postgres -e POSTGRES_PASSWORD=<password> -d -p 5432:5432 -v /data/docker/volumes/postgres:/var/lib/postgresql/data postgres

    $ docker exec -it <image-hash> bash
    $> su - postgres
    ```

1. Create Database User

    ```bash
    $> createuser ispindel
    ```

2. Create Database

    ```bash
    $> createdb iSpindel
    ```

3. Grant Access to User

    ```bash
    $ psql
    postgres=> alter user ispindel with encrypted password '<password>';
    postgres=> grant all privileges on database "iSpindel" to ispindel;
    ```

### Cross compile for raspberry pi

1. Ensure dotnet core is installed
2. Use simple script to compile

    ```bash
    cd iSpindel.Database.Job.Runner
    ./publishForPi.sh
    ```

3. success

    ```bash
    scp appsettings.json pi@<ZIELPI>:/home/pi
    cd bin/Release/net6.0/linux-arm/publish
    scp iSpindel.Database.Job.Runner pi@<ZIELPI>:/home/pi/iSpindel
    ```

4. modify appsettings


### Starting the iSpindel Program

1. Start the Database Runner. Make sure appsettings.json is correct

    ```bash
    cd iSpindel.Database.Job.Runner
    ./publishForPi.sh
    # copy to pi
    ./iSpindel.Database.Job.Runner
    ```

2. Start the Angular App

    ```bash
    cd iSpindel.ClientApp
    yarn run start
    ```

3. Start the WebApi. Make sure appsettings.json is correct

    ```bash
    cd iSpindel.App
    dotnet run
    ```

## Publishing iSpindel

### iSpindel.App
The build for the WebApp also triggers a yarn run build:prod

1. cd iSpindel.App
2. dotnet publish -r linux-arm64 -c Release --no-self-contained -p:PublishSingleFile=True
3. scp -r bin\Release\net6.0\linux-arm64\publish\* pi@raspi:~/iSpindel/WebApp

### iSpindel.Database.Job.Runner
1. cd iSpindel.Database.Job.Runner
2. dotnet publish -r linux-arm64 -c Release --no-self-contained -p:PublishSingleFile=True
3. scp -r bin\Release\net6.0\linux-arm64\publish\iSpindel.Database.Job.Runner pi@raspi:~/iSpindel/DatabaseRunner
3. scp -r appsettings.json pi@raspi:~/iSpindel/DatabaseRunner
