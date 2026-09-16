using Fiorini.Datos;
using Fiorini.Datos.Repositorios;
using Fiorini.Dominio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Acceso a datos: EF Core + SQL Server (LocalDB) y patrón repositorio
builder.Services.AddDbContext<AlquilerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAlquilerRepositorio, AlquilerRepositorio>();

// Swagger para documentar y testear los servicios
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Creación de la base de datos dbAlquiler usando los mecanismos de EF
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AlquilerContext>();
    context.Database.EnsureCreated();
}

app.UseSwagger();
app.UseSwaggerUI();

// ---------------------------------------------------------------
// Endpoints de Alquiler
// ---------------------------------------------------------------

// Recuperar todos los alquileres
app.MapGet("/alquileres", async (IAlquilerRepositorio repositorio) =>
{
    var alquileres = await repositorio.ObtenerTodosAsync();
    return Results.Ok(alquileres);
})
.WithName("ObtenerAlquileres")
.WithTags("Alquileres")
.Produces<List<Alquiler>>(StatusCodes.Status200OK);

// a. Recuperar registros según el estado del Alquiler
app.MapGet("/alquileres/estado/{estado}", async (string estado, IAlquilerRepositorio repositorio) =>
{
    if (!EstadoAlquiler.Todos.Contains(estado))
        return Results.BadRequest(new List<string> { $"El estado '{estado}' no es válido. Valores permitidos: {string.Join(", ", EstadoAlquiler.Todos)}." });

    var alquileres = await repositorio.ObtenerPorEstadoAsync(estado);
    return Results.Ok(alquileres);
})
.WithName("ObtenerAlquileresPorEstado")
.WithTags("Alquileres")
.Produces<List<Alquiler>>(StatusCodes.Status200OK)
.Produces<List<string>>(StatusCodes.Status400BadRequest);

// Recuperar un alquiler por Id
app.MapGet("/alquileres/{id:int}", async (int id, IAlquilerRepositorio repositorio) =>
{
    var alquiler = await repositorio.ObtenerPorIdAsync(id);
    return alquiler is null ? Results.NotFound() : Results.Ok(alquiler);
})
.WithName("ObtenerAlquilerPorId")
.WithTags("Alquileres")
.Produces<Alquiler>(StatusCodes.Status200OK)
.Produces(StatusCodes.Status404NotFound);

// b. Agregar nuevo registro (siempre se crea como "Activo")
app.MapPost("/alquileres", async (Alquiler alquiler, IAlquilerRepositorio repositorio) =>
{
    alquiler.Id = 0;
    alquiler.Estado = EstadoAlquiler.Activo;

    var errores = alquiler.Validar();
    if (errores.Count > 0)
        return Results.BadRequest(errores);

    var creado = await repositorio.AgregarAsync(alquiler);
    return Results.Created($"/alquileres/{creado.Id}", creado);
})
.WithName("AgregarAlquiler")
.WithTags("Alquileres")
.Produces<Alquiler>(StatusCodes.Status201Created)
.Produces<List<string>>(StatusCodes.Status400BadRequest);

// c. Finalizar un Alquiler
app.MapPut("/alquileres/{id:int}/finalizar", async (int id, IAlquilerRepositorio repositorio) =>
{
    var alquiler = await repositorio.ObtenerPorIdAsync(id);
    if (alquiler is null)
        return Results.NotFound();

    if (alquiler.Estado == EstadoAlquiler.Finalizado)
        return Results.BadRequest(new List<string> { $"El alquiler {id} ya se encuentra finalizado." });

    alquiler.Estado = EstadoAlquiler.Finalizado;
    await repositorio.ActualizarAsync(alquiler);

    return Results.Ok(alquiler);
})
.WithName("FinalizarAlquiler")
.WithTags("Alquileres")
.Produces<Alquiler>(StatusCodes.Status200OK)
.Produces<List<string>>(StatusCodes.Status400BadRequest)
.Produces(StatusCodes.Status404NotFound);

app.Run();
