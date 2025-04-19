var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

//app.UseHttpsRedirection();

app.MapGet("/api/values", () => "Hello from ASP.NET Core Self-Hosting!");
app.MapGet("/api/values/{id}", (int id) => $"You requested ID: {id}");

app.Run("http://localhost:9000");
