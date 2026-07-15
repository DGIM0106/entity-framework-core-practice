# Entity Framework Core Practice

> **Proyecto práctico para el aprendizaje y dominio de Entity Framework Core utilizando un enfoque Database-First con SQL Server.**

Este repositorio contiene la implementación de operaciones CRUD y consultas avanzadas con LINQ, conectándose a una base de datos SQL Server preestablecida mediante scripts.

---

## Tecnologías y Herramientas

| Tecnología / Herramienta | Uso en el Proyecto |
| :--- | :--- |
| **C# / .NET 10** | Lenguaje de programación principal de la aplicación de consola. |
| **Entity Framework Core** | ORM para mapear la base de datos y gestionar las consultas mediante LINQ. |
| **SQL Server** | Motor de base de datos relacional para el almacenamiento de datos. |
| **Visual Studio** | Entorno de desarrollo utilizado para escribir el flujo de las operaciones CRUD. |
| **Visual Studio Code** | Editor ligero utilizado para la gestión de scripts SQL y documentación. |

> **Enfoque de Desarrollo:** Se aplicó la filosofía **Database-First** (Scaffolding). La cadena de conexión a la base de datos se administra de forma segura a través de un archivo `appsettings.json`.

---

## Cómo Ejecutar el Proyecto

Sigue estos pasos detallados para configurar la base de datos y ejecutar la aplicación en tu entorno local:

### 1. Clonar el Repositorio
Abre tu terminal y clona el proyecto con el siguiente comando:
```bash
git clone [https://github.com/DGIM0106/entity-framework-core-practice.git](https://github.com/DGIM0106/entity-framework-core-practice.git)
```

### 2. Configurar la Base de Datos 🗄️
Antes de iniciar la aplicación, debes estructurar la base de datos en tu servidor local de SQL Server:
1. Abre tu gestor de base de datos (SQL Server Management Studio o VS Code con la extensión SQL Server).
2. Conéctate a tu servidor local.
3. Ejecuta los archivos SQL ubicados en la carpeta de scripts en este orden estricto:
   * **`CreateDatabase.sql`**: Crea la base de datos en el servidor.
   * **`CreateTables.sql`**: Crea las tablas `Categorias` y `Productos` con sus respectivas llaves primarias y foráneas.
   * *(Opcional)* **`ViewData.sql`**: Úsalo para verificar que las tablas se hayan creado y consultar los datos iniciales.

### 3. Configurar la Cadena de Conexión 🔌
1. Abre la carpeta del proyecto `EFCorePractice.Solution` en Visual Studio o VS Code.
2. Localiza el archivo `appsettings.json` en la raíz del proyecto de consola.
3. Asegúrate de que la propiedad `ConnectionString` apunte a tu servidor local de SQL Server. Debería verse similar a esto:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=TU_SERVIDOR_LOCAL;Database=EfcorePracticeDb;Trusted_Connection=True;TrustServerCertificate=True;"
     }
   }
   ```
   *Nota: Reemplaza `TU_SERVIDOR_LOCAL` por el nombre de tu instancia de SQL Server (por ejemplo, `localhost` o `(localdb)\MSSQLLocalDB`).*

### 4. Ejecutar la Aplicación 🚀
1. Abre la solución en **Visual Studio**.
2. Restaura los paquetes NuGet necesarios si el IDE no lo hace automáticamente.
3. Presiona el botón **Iniciar** o la tecla `F5` para correr la aplicación de consola.
4. En la consola podrás visualizar en tiempo real el flujo del CRUD:
   * Creación de nuevas categorías.
   * Consulta filtrada con LINQ.
   * Inserción de nuevos productos relacionados.
   * Actualización de precios y eliminación de registros.

git clone [https://github.com/DGIM0106/entity-framework-core-practice.git](https://github.com/DGIM0106/entity-framework-core-practice.git)