
# Local setup commands
```
dotnet user-secrets set "Database:Username" "<username>"
dotnet user-secrets set "Database:Password" "<password>"
```

# Entity framework core commands

## Setup

Restore dotnet tools
```
dotnet tool restore
```
Entity framework core is available as `dotnet ef`.

## Migrations for iSpindel.Database - iSpindelContext
```
cd iSpindel.Database
dotnet ef migrations add <name> -c iSpindelContext --startup-project "../iSpindel.App"
dotnet ef database update -c iSpindelContext --startup-project "../iSpindel.App"
```

## Migrations for iSpindel.App - ApplicationDbContext
```
cd iSpindel.Database
dotnet ef migrations add <name> -c ApplicationDbContext -o Data/Migrations
dotnet ef database update -c ApplicationDbContext
```
