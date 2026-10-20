var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TiendaServicio_Api_Autor>("tiendaservicio-api-autor");

builder.AddProject<Projects.TiendaServicios_Api_Gateway>("tiendaservicios-api-gateway");

builder.Build().Run();
