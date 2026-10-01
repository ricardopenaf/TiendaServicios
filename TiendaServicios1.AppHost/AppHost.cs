var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.TiendaServicios_Api_Libro>("tiendaservicios-api-libro");

builder.Build().Run();
