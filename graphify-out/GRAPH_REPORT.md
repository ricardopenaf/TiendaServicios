# Graph Report - TiendaServicios  (2026-09-17)

## Corpus Check
- Corpus is ~4,418 words - fits in a single context window. You may not need a graph.

## Summary
- 378 nodes · 501 edges · 19 communities
- Extraction: 100% EXTRACTED · 0% INFERRED · 0% AMBIGUOUS · INFERRED: 1 edges (avg confidence: 0.8)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Autor Service - App & Migrations
- CarritoCompra - App & Remote Libro
- Project Files & NuGet Deps
- Command Validation Handlers
- Libro Service - App Layer
- CarritoCompra - Domain & Migrations
- API Controllers (CarritoCompra)
- EF Core Async Mocking (Tests)
- EF Core Migration Snapshots
- Libro API Controller
- Domain Models & DbContexts
- Libro Service Tests
- Autor API Controller
- Autor Service - Project File
- Autor Service - Launch Settings
- CarritoCompra - Launch Settings
- Libro Service - Launch Settings
- CarritoCompra - WeatherForecast Model
- Autor - WeatherForecast Model

## God Nodes (most connected - your core abstractions)
1. `TiendaServicios.Api.Libro` - 12 edges
2. `TiendaServicio.Api.Autor` - 11 edges
3. `TiendaServicios.Api.CarritoCompra` - 11 edges
4. `TiendaServicios.Api.Libro.Test` - 11 edges
5. `AutorDto` - 10 edges
6. `TiendaServicio.Api.Autor.Modelo` - 9 edges
7. `LibroMaterialDto` - 9 edges
8. `Manejador` - 8 edges
9. `ContextoAutor` - 8 edges
10. `CarritoDto` - 8 edges

## Surprising Connections (you probably didn't know these)
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Consulta.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/ConsultaFiltro.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `CarritoContexto`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Consulta.cs → TiendaServicios.Api.CarritoCompra/Persistencia/CarritoContexto.cs
- `Manejador` --references--> `CarritoContexto`  [EXTRACTED]
  TiendaServicios.Api.CarritoCompra/Aplicacion/Nuevo.cs → TiendaServicios.Api.CarritoCompra/Persistencia/CarritoContexto.cs

## Import Cycles
- None detected.

## Communities (19 total, 0 thin omitted)

### Community 0 - "Autor Service - App & Migrations"
Cohesion: 0.07
Nodes (30): AutorUnico, TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Modelo, TiendaServicio.Api.Autor.Aplicacion, TiendaServicio.Api.Autor.Controllers, TiendaServicio.Api.Autor.Migrations, IRequest, ListaAutor (+22 more)

### Community 1 - "CarritoCompra - App & Remote Libro"
Cohesion: 0.06
Nodes (32): TiendaServicios.Api.CarritoCompra.RemoteInterface, TiendaServicios.Api.CarritoCompra.RemoteModel, TiendaServicios.Api.CarritoCompra.Aplicacion, TiendaServicios.Api.CarritoCompra.RemoteService, IHttpClientFactory, ILogger, DateTime, Guid (+24 more)

### Community 2 - "Project Files & NuGet Deps"
Cohesion: 0.06
Nodes (32): coverlet.collector (6.0.4), GenFu (1.6.0), Microsoft.EntityFrameworkCore.InMemory (10.0.12), Microsoft.EntityFrameworkCore.SqlServer (10.0.12), Microsoft.NET.Test.Sdk (17.14.1), Moq (4.20.72), Mysql.EntityFrameworkCore (10.0.9), xunit (2.9.3) (+24 more)

### Community 3 - "Command Validation Handlers"
Cohesion: 0.09
Nodes (24): AbstractValidator, IRequestHandler, CancellationToken, Task, EjecutaValidacion, Manejador, Ejecuta, CancellationToken (+16 more)

### Community 4 - "Libro Service - App Layer"
Cohesion: 0.10
Nodes (19): TiendaServicios.Api.Libro.Modelo, TiendaServicios.Api.Libro.Persistencia, TiendaServicios.Api.Libro.Aplicacion, LibroUnico, ListaLibro, Profile, CancellationToken, IMapper (+11 more)

### Community 5 - "CarritoCompra - Domain & Migrations"
Cohesion: 0.09
Nodes (18): TiendaServicios.Api.CarritoCompra.Migrations, TiendaServicios.Api.CarritoCompra.Persistencia, TiendaServicios.Api.CarritoCompra.Modelo, Migration, DateTime, List, Ejecuta, Nuevo (+10 more)

### Community 6 - "API Controllers (CarritoCompra)"
Cohesion: 0.08
Nodes (20): ControllerBase, TiendaServicios.Api.CarritoCompra.Controllers, HttpGet, IEnumerable, string, WeatherForecast, WeatherForecastController, ActionResult (+12 more)

### Community 7 - "EF Core Async Mocking (Tests)"
Cohesion: 0.09
Nodes (17): TiendaServicios.Api.Libro.Test, EnumerableQuery, Expression, IAsyncEnumerable, IAsyncEnumerator, IAsyncQueryProvider, IEnumerator, IQueryable (+9 more)

### Community 8 - "EF Core Migration Snapshots"
Cohesion: 0.11
Nodes (11): TiendaServicios.Api.Libro.Migrations, ModelSnapshot, ModelBuilder, ContextoAutorModelSnapshot, ModelBuilder, CarritoContextoModelSnapshot, MigrationBuilder, ModelBuilder (+3 more)

### Community 9 - "Libro API Controller"
Cohesion: 0.18
Nodes (11): TiendaServicios.Api.Libro.Controllers, ActionResult, Ejecuta, Guid, HttpGet, HttpPost, IMediator, List (+3 more)

### Community 10 - "Domain Models & DbContexts"
Cohesion: 0.18
Nodes (10): DbContext, DateTime, ICollection, AutorLibro, DateTime, GradoAcademico, DbSet, ContextoAutor (+2 more)

### Community 11 - "Libro Service Tests"
Cohesion: 0.25
Nodes (7): Fact, DateTime, Guid, LibreriaMaterial, List, Task, LibrosServicesTest

### Community 12 - "Autor API Controller"
Cohesion: 0.25
Nodes (8): IActionResult, ActionResult, HttpGet, HttpPost, IMediator, List, Task, AutorController

### Community 13 - "Autor Service - Project File"
Cohesion: 0.18
Nodes (11): Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3), TiendaServicio.Api.Autor, net10.0, AutoMapper (16.2.0), FluentValidation.AspNetCore (11.3.1), MediatR (12.4.1), Microsoft.EntityFrameworkCore (10.0.12), Microsoft.EntityFrameworkCore.Design (10.0.12) (+3 more)

### Community 14 - "Autor Service - Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 15 - "CarritoCompra - Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 16 - "Libro Service - Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 17 - "CarritoCompra - WeatherForecast Model"
Cohesion: 0.50
Nodes (3): TiendaServicios.Api.CarritoCompra, DateOnly, WeatherForecast

### Community 18 - "Autor - WeatherForecast Model"
Cohesion: 0.50
Nodes (3): TiendaServicio.Api.Autor, DateOnly, WeatherForecast

## Knowledge Gaps
- **63 isolated node(s):** `$schema`, `commandName`, `dotnetRunMessages`, `launchBrowser`, `launchUrl` (+58 more)
  These have ≤1 connection - possible missing edges or undocumented components.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `TiendaServicios.Api.Libro.Test` connect `EF Core Async Mocking (Tests)` to `Libro Service - App Layer`?**
  _High betweenness centrality (0.093) - this node is a cross-community bridge._
- **Why does `Manejador` connect `CarritoCompra - App & Remote Libro` to `Command Validation Handlers`, `CarritoCompra - Domain & Migrations`?**
  _High betweenness centrality (0.089) - this node is a cross-community bridge._
- **Why does `TiendaServicios.Api.Libro.Persistencia` connect `Libro Service - App Layer` to `EF Core Migration Snapshots`?**
  _High betweenness centrality (0.080) - this node is a cross-community bridge._
- **What connects `$schema`, `commandName`, `dotnetRunMessages` to the rest of the system?**
  _63 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Autor Service - App & Migrations` be split into smaller, more focused modules?**
  _Cohesion score 0.06666666666666667 - nodes in this community are weakly interconnected._
- **Should `CarritoCompra - App & Remote Libro` be split into smaller, more focused modules?**
  _Cohesion score 0.06155632984901278 - nodes in this community are weakly interconnected._
- **Should `Project Files & NuGet Deps` be split into smaller, more focused modules?**
  _Cohesion score 0.0625 - nodes in this community are weakly interconnected._