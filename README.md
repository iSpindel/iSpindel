# Local setup commands

```bash
cd iSpindel.App
dotnet user-secrets set "Database:Username" "<username>"
dotnet user-secrets set "Database:Password" "<password>"
```

# Entity framework core commands

## Setup

Requires .NET Core 3.1

Restore dotnet tools

```bash
dotnet tool restore
```

Entity framework core is available as `dotnet ef`.

## Migrations for iSpindel.Database - iSpindelContext

```bash
cd iSpindel.Database
dotnet ef database update -c iSpindelContext --startup-project "../iSpindel.App"
```

To add a new migration:

```bash
dotnet ef migrations add <name> -c iSpindelContext --startup-project "../iSpindel.App"
```

## Migrations for iSpindel.App - ApplicationDbContext

```bash
cd iSpindel.App
dotnet ef database update -c ApplicationDbContext
```

To add a new migration:

```bash
dotnet ef migrations add <name> -c ApplicationDbContext -o Data/Migrations
```

## Postgres Database Preparations for EF

0. Install Postgres
```bash
sudo apt update
sudo apt install postgresql
sudo -i -u postgres
```
1. Create Database User
```bash
$ createuser ispindel
```

2. Create Database 
```bash
createdb iSpindel
```
3. Grant Access to User
```bash
alter user ispindel with encrypted password '<password>';
grant all privileges on database "iSpindel" to ispindel;
```
4. Test Access
```bash
psql -h localhost -p 5432 -U ispindel -d iSpindel
```