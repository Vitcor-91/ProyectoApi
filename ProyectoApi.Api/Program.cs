

using Scalar.AspNetCore;
using ProyectoApi.Infrastructure;
using ProyectoApi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add los servicios al contenedor.
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();

// Visualizar el contenido del swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Agregar Cors
builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

//inicializar la base de datos en el contendor si no existe
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();

    try
    {
        await context.Database.OpenConnectionAsync();

        Console.WriteLine(
            "La base de datos existe. No se ejecutarán migraciones.");

        await context.Database.CloseConnectionAsync();
    }
    catch (MySqlException ex) when (ex.Number == 1049)
    {
        Console.WriteLine(
            "La base de datos no existe. Ejecutando migraciones...");

        context.Database.Migrate();
    }

}

// Apliar los cors en los endpoints
app.UseRouting();
app.UseCors("CorsPolicy");
app.UseStaticFiles();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.MapOpenApi();
app.MapScalarApiReference();

app.UseSwagger();
app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
