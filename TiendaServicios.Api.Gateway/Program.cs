using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using TiendaServicios.Api.Gateway.ImplementRemote;
using TiendaServicios.Api.Gateway.InterfaceRemote;
using TiendaServicios.Api.Gateway.MessageHandler;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddOcelot(builder.Configuration).AddDelegatingHandler<LibroHandler>();
builder.Services.AddSingleton<IAutorRemote, AutorRemote>();
builder.Services.AddHttpClient("AutorService", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:Autor"]!);
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

await app.UseOcelot();

app.Run();
