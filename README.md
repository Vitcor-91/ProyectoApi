# ProyectoApi

API desarrollada con **ASP.NET Core** siguiendo buenas prácticas de arquitectura, separación de responsabilidades y diseño orientado a servicios.

## Descripción

**ProyectoApi** es una API REST desarrollada con .NET que permite gestionar y exponer información mediante endpoints HTTP.

El proyecto está pensado para ser **escalable, mantenible y fácil de extender**, aplicando principios de desarrollo limpio y buenas prácticas.

## 🛠️ Tecnologías

* **.NET / ASP.NET Core**
* **C#**
* **REST API**
* **Entity Framework Core**
* **SQL Server**
* **Swagger / OpenAPI**
* **Git / GitHub**
* **Unit**

## 📁 Estructura del proyecto (Hezagonal)

```text
ProyectoApi/Api
│
├── Controllers/
│   └── ...
│
├── Services/
│   └── ...
│
├── Models/
│   └── ...
│
├── Data/
│   └── ...
│
├── DTOs/
│   └── ...
│
├── Properties/
│
├── appsettings.json
├── Program.cs
└── ProyectoApi.csproj
ProyectoApi/Infrastructure
│
├── Conexion/
│
├── Models/
│
├── DTOs/
```

## Requisitos

Antes de ejecutar el proyecto necesitas tener instalado:

* [.NET SDK](https://dotnet.microsoft.com/download)
* SQL Server
* Git

Puedes comprobar la versión de .NET instalada:

```bash
dotnet --version
```

## Instalación

Clona el repositorio:

```bash
git clone https://github.com/Vitcor-91/ProyectoApi.git
```

Entra al proyecto:

```bash
cd ProyectoApi
```

Restaura las dependencias:

```bash
dotnet restore
```

Compila el proyecto:

```bash
dotnet build
```

Ejecuta la aplicación:

```bash
dotnet run
```

## Swagger

Una vez iniciada la aplicación, puedes utilizar **Swagger** para consultar y probar los endpoints disponibles.

```text
https://localhost:<puerto>/swagger
```

Swagger permite visualizar la documentación de la API y realizar pruebas directamente desde el navegador.

## JSON

Una vez iniciada la aplicación, puedes visualizar la estructura en **JSON** para consultar y probar los endpoints disponibles.

```text
https://localhost:<puerto>/openapi/v1.json
```

## Scalar

Una vez iniciada la aplicación, puedes utilizar **Scalar** para consultar los endpoints disponibles.

```text
https://localhost:<puerto>/scalar/#tag/<endpoint>
```

Scalar permite visualizar la documentación de la API.


## Configuración

Antes de ejecutar el proyecto en un entorno local, configura los valores necesarios en `appsettings.json` o mediante variables de entorno.

Ejemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=ProyectoApi;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> ⚠️ No subas contraseñas, tokens, claves API u otras credenciales al repositorio.

## Endpoints

| Método   | Endpoint        | Descripción                |
| -------- | --------------- | -------------------------- |
| `GET`    | `/api/...`      | Obtener información        |
| `GET`    | `/api/.../{id}` | Obtener información por ID |
| `POST`   | `/api/...`      | Crear un registro          |
| `PUT`    | `/api/.../{id}` | Actualizar un registro     |
| `DELETE` | `/api/.../{id}` | Eliminar un registro       |

## 🧪 Pruebas

Para ejecutar las pruebas del proyecto:

```bash
dotnet test
```

## 📦 Build para producción

Para generar una versión preparada para despliegue:

```bash
dotnet publish -c Release
```

## 👨‍💻 Autor

**Victor Solis**

Desarrollador de software especializado en desarrollo de aplicaciones y APIs.

---

Si este proyecto te resulta útil, considera darle una estrella al repositorio.
