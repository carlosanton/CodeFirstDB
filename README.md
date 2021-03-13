# CodeFirstDB

Creación de la Base de Datos con Entity Framework Core

## Cómo crearla

Genera la migración:

```
dotnet ef migrations add <Nombre_Migracion>
```

Y a continuación, ejecútala

```
dotnet ef database update
```