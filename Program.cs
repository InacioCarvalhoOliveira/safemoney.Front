var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Adiciona o middleware para servir arquivos estáticos (HTML, CSS, JS)
app.UseStaticFiles();

// Configura o roteamento
app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/index.html");
    return Task.CompletedTask;
});

app.MapGet("/login", (HttpContext context) =>
{
    context.Response.Redirect("/login.html");
    return Task.CompletedTask;
});

app.Run();
