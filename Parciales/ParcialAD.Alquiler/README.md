# Evaluación Aprobación Directa - Tema: Alquiler

| Proyecto               | Tipo                 | Responsabilidad                                                                 |
|------------------------|----------------------|---------------------------------------------------------------------------------|
| `Fiorini.Dominio`      | Biblioteca de clases | Entidad `Alquiler` + reglas de validación (`Validar()`) y constantes de estado.  |
| `Fiorini.Datos`        | Biblioteca de clases | `AlquilerContext` (EF Core, SQL Server LocalDB) y patrón repositorio.           |
| `Fiorini.Servicios`    | ASP.NET Core (API)   | API Rest asíncrona con Swagger. Crea la base `dbAlquiler` con `EnsureCreated()`.|
| `Fiorini.Negocio`      | Biblioteca de clases | Cliente `HttpClient` (Singleton) que consume la API.                            |
| `Fiorini.Presentacion` | Windows Forms        | `FormListado` y `FormAlta`.                                                     |
| `Fiorini.Web`          | **Blazor Web App**   | Páginas `Alquileres.razor` (listado) y `AlquilerAlta.razor` (alta).             |

## Cómo ejecutar

1. Ejecutar `Fiorini.Servicios` (Swagger en `http://localhost:5100/swagger`).
2. Con la API corriendo, ejecutar `Fiorini.Web` (`http://localhost:5200`) y/o `Fiorini.Presentacion`.

## Puntos clave de la capa Blazor (para estudiar)

- Plantilla **Blazor Web App** (.NET 8) con `AddInteractiveServerComponents()` / `AddInteractiveServerRenderMode()`
  en `Program.cs`, igual que el Lab de la Unidad 5.
- Las páginas que tienen eventos (`@onclick`, `@bind`, `EditForm`) declaran `@rendermode InteractiveServer`.
- `AlquilerNegocio` se registra en el contenedor de dependencias (`builder.Services.AddScoped<AlquilerNegocio>()`)
  y se inyecta en las páginas con `@inject`.
- `Alquileres.razor`: `<select @bind>` con los estados pre-seteados, botón **Buscar**, tabla Bootstrap,
  botón **Agregar** (navega con `NavigationManager`) y botón **Finalizar** por fila (confirma con `IJSRuntime` → `confirm`).
- `AlquilerAlta.razor`: `EditForm` con `InputText`, `InputNumber` e `InputDate`. El usuario no elige el Estado:
  lo fuerza el servicio a `"Activo"`. Las validaciones se muestran como lista antes de llamar a la API.
- Ciclo de vida: la carga inicial del listado se hace en `OnInitializedAsync()`.
