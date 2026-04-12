var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { status = "ok", message = "Hello from ASP.NET!" });
app.MapGet("/health", () => new { status = "healthy" });

app.Run();
