using GestorDeTorneo.Interface;
using GestorDeTorneo.Repository;
using GestorDeTorneo.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyeccion de dependencias
builder.Services.AddSingleton<EquiposRepository>();
builder.Services.AddSingleton<IEquipos, EquiposService>();

builder.Services.AddSingleton<PartidosRepository>();
builder.Services.AddSingleton<IPartidos, PartidosService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
