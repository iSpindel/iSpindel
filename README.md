
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
cd iSpindel.Database
dotnet ef migrations add <name> -c ApplicationDbContext -o Data/Migrations
dotnet ef database update -c ApplicationDbContext
```
