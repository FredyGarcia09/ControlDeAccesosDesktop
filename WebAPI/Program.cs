using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Agrega la conexión a MySQL
var connectionString = "server=localhost;database=controlaccesos;user=root;password=root;";
builder.Services.AddDbContext<ControlDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Agrega controladores
builder.Services.AddControllers();

// Swagger (documentación de prueba)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
