# CodeFirstDB

Creaci�n de la Base de Datos con Entity Framework Core

## C�mo crearla

Genera la migraci�n:

```
dotnet ef migrations add <Nombre_Migracion>
```

Y a continuaci�n, ejec�tala

```
dotnet ef database update
```