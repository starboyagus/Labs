using Fiorini.Negocio;
using Fiorini.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Blazor Web App con interactividad del lado del servidor (Interactive Server)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Capa de negocio que consume la API Rest (Fiorini.Servicios) mediante HttpClient
builder.Services.AddScoped<AlquilerNegocio>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
