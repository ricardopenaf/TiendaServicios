using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using TiendaServicio.Api.Autor.Aplicacion;
using TiendaServicio.Api.Autor.Persistencia;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<Nuevo>();

// Swagger / OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TiendaServicio.Api.Autor",
        Version = "v1",
        Description = "API del microservicio de autores"
    });
});

builder.Services.AddDbContext<ContextoAutor>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConexionDatabase"));
});

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Nuevo.Manejador).Assembly));
// Registrar AutoMapper (escanea los perfiles en el assembly de Aplicacion)
builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(Consulta).Assembly));

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TiendaServicios.Api.Autor v1");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();
