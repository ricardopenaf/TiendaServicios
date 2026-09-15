# Graph Report - TiendaServicios  (2026-09-15)

## Corpus Check
- Corpus is ~4,046 words - fits in a single context window. You may not need a graph.

## Summary
- 351 nodes · 466 edges · 18 communities
- Extraction: 100% EXTRACTED · 0% INFERRED · 0% AMBIGUOUS · INFERRED: 1 edges (avg confidence: 0.8)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Libro Domain Core
- Autor Domain Core
- Project & Package Config
- CarritoCompra Domain Core
- API Controllers
- CarritoCompra-Libro Integration
- CQRS Command Handlers
- EF Migration Snapshots
- Libro Query & Create Logic
- Libro Controller Actions
- CarritoCompra DTOs & Query
- Autor Controller Actions
- Autor Project Config
- Autor Launch Settings
- CarritoCompra Launch Settings
- Libro Launch Settings
- CarritoCompra Sample WeatherForecast
- Autor Sample WeatherForecast

## God Nodes (most connected - your core abstractions)
1. `TiendaServicios.Api.Libro` - 12 edges
2. `TiendaServicio.Api.Autor` - 11 edges
3. `TiendaServicios.Api.CarritoCompra` - 11 edges
4. `AutorDto` - 10 edges
5. `TiendaServicios.Api.Libro.Test` - 10 edges
6. `LibroMaterialDto` - 10 edges
7. `TiendaServicio.Api.Autor.Modelo` - 9 edges
8. `Manejador` - 8 edges
9. `ContextoAutor` - 8 edges
10. `CarritoDto` - 8 edges

## Surprising Connections (you probably didn't know these)
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `CarritoDto`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Consulta.cs → TiendaServicios.Api.CarritoCompra/Aplicacion/CarritoDto.cs
- `Manejador` --references--> `CarritoContexto`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Consulta.cs → TiendaServicios.Api.CarritoCompra/Persistencia/CarritoContexto.cs
- `Manejador` --references--> `ILibroService`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Consulta.cs → TiendaServicios.Api.CarritoCompra/RemoteInterface/ILibroService.cs
- `Manejador` --references--> `CarritoContexto`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Nuevo.cs → TiendaServicios.Api.CarritoCompra/Persistencia/CarritoContexto.cs

## Import Cycles
- None detected.

## Communities (18 total, 0 thin omitted)

### Community 0 - "Libro Domain Core"
Cohesion: 0.05
Nodes (32): TiendaServicios.Api.Libro.Modelo, TiendaServicios.Api.Libro.Persistencia, TiendaServicios.Api.Libro.Test, TiendaServicios.Api.Libro.Migrations, TiendaServicios.Api.Libro.Controllers, TiendaServicios.Api.Libro.Aplicacion, DbContext, Fact (+24 more)

### Community 1 - "Autor Domain Core"
Cohesion: 0.08
Nodes (29): AutorUnico, TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Modelo, TiendaServicio.Api.Autor.Aplicacion, TiendaServicio.Api.Autor.Controllers, ListaAutor, DateTime, AutorDto (+21 more)

### Community 2 - "Project & Package Config"
Cohesion: 0.06
Nodes (31): coverlet.collector (6.0.4), GenFu (1.6.0), Microsoft.EntityFrameworkCore.SqlServer (10.0.12), Microsoft.NET.Test.Sdk (17.14.1), Moq (4.20.72), Mysql.EntityFrameworkCore (10.0.9), xunit (2.9.3), xunit.runner.visualstudio (3.1.4) (+23 more)

### Community 3 - "CarritoCompra Domain Core"
Cohesion: 0.09
Nodes (18): TiendaServicios.Api.CarritoCompra.Migrations, TiendaServicios.Api.CarritoCompra.Persistencia, TiendaServicios.Api.CarritoCompra.Modelo, Migration, DateTime, List, Ejecuta, Nuevo (+10 more)

### Community 4 - "API Controllers"
Cohesion: 0.08
Nodes (20): ControllerBase, TiendaServicios.Api.CarritoCompra.Controllers, HttpGet, IEnumerable, string, WeatherForecast, WeatherForecastController, ActionResult (+12 more)

### Community 5 - "CarritoCompra-Libro Integration"
Cohesion: 0.09
Nodes (20): TiendaServicios.Api.CarritoCompra.RemoteInterface, TiendaServicios.Api.CarritoCompra.RemoteModel, TiendaServicios.Api.CarritoCompra.RemoteService, IHttpClientFactory, ILogger, Guid, Libro, mensaje (+12 more)

### Community 6 - "CQRS Command Handlers"
Cohesion: 0.12
Nodes (18): AbstractValidator, IRequestHandler, CancellationToken, Task, EjecutaValidacion, Manejador, Ejecuta, CancellationToken (+10 more)

### Community 7 - "EF Migration Snapshots"
Cohesion: 0.11
Nodes (11): TiendaServicio.Api.Autor.Migrations, ModelSnapshot, MigrationBuilder, ModelBuilder, MigracionIncial, ModelBuilder, ContextoAutorModelSnapshot, ModelBuilder (+3 more)

### Community 8 - "Libro Query & Create Logic"
Cohesion: 0.12
Nodes (15): IRequest, LibroUnico, DateTime, Ejecuta, CancellationToken, ContextoLibreria, Guid, IMapper (+7 more)

### Community 9 - "Libro Controller Actions"
Cohesion: 0.22
Nodes (10): ActionResult, Ejecuta, Guid, HttpGet, HttpPost, IMediator, List, Task (+2 more)

### Community 10 - "CarritoCompra DTOs & Query"
Cohesion: 0.20
Nodes (9): TiendaServicios.Api.CarritoCompra.Aplicacion, DateTime, Guid, CarritoDetalletDto, DateTime, List, CarritoDto, Consulta (+1 more)

### Community 11 - "Autor Controller Actions"
Cohesion: 0.25
Nodes (8): IActionResult, ActionResult, HttpGet, HttpPost, IMediator, List, Task, AutorController

### Community 12 - "Autor Project Config"
Cohesion: 0.18
Nodes (11): Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3), TiendaServicio.Api.Autor, net10.0, AutoMapper (16.2.0), FluentValidation.AspNetCore (11.3.1), MediatR (12.4.1), Microsoft.EntityFrameworkCore (10.0.12), Microsoft.EntityFrameworkCore.Design (10.0.12) (+3 more)

### Community 13 - "Autor Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 14 - "CarritoCompra Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 15 - "Libro Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 16 - "CarritoCompra Sample WeatherForecast"
Cohesion: 0.50
Nodes (3): TiendaServicios.Api.CarritoCompra, DateOnly, WeatherForecast

### Community 17 - "Autor Sample WeatherForecast"
Cohesion: 0.50
Nodes (3): TiendaServicio.Api.Autor, DateOnly, WeatherForecast

## Knowledge Gaps
- **63 isolated node(s):** `$schema`, `commandName`, `dotnetRunMessages`, `launchBrowser`, `launchUrl` (+58 more)
  These have ≤1 connection - possible missing edges or undocumented components.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `Manejador` connect `CQRS Command Handlers` to `CarritoCompra DTOs & Query`, `CarritoCompra Domain Core`, `CarritoCompra-Libro Integration`?**
  _High betweenness centrality (0.096) - this node is a cross-community bridge._
- **Why does `LibroMaterialDto` connect `Libro Domain Core` to `Libro Query & Create Logic`, `Libro Controller Actions`?**
  _High betweenness centrality (0.065) - this node is a cross-community bridge._
- **Why does `Manejador` connect `Libro Domain Core` to `CQRS Command Handlers`?**
  _High betweenness centrality (0.063) - this node is a cross-community bridge._
- **What connects `$schema`, `commandName`, `dotnetRunMessages` to the rest of the system?**
  _63 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Libro Domain Core` be split into smaller, more focused modules?**
  _Cohesion score 0.05442176870748299 - nodes in this community are weakly interconnected._
- **Should `Autor Domain Core` be split into smaller, more focused modules?**
  _Cohesion score 0.07804878048780488 - nodes in this community are weakly interconnected._
- **Should `Project & Package Config` be split into smaller, more focused modules?**
  _Cohesion score 0.06451612903225806 - nodes in this community are weakly interconnected._