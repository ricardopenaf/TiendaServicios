var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TiendaServicio_Api_Autor>("tiendaservicio-api-autor");

builder.Build().Run();
