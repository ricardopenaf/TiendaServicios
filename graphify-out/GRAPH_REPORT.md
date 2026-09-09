# Graph Report - TiendaServicios  (2026-09-09)

## Corpus Check
- Corpus is ~2,365 words - fits in a single context window. You may not need a graph.

## Summary
- 212 nodes · 297 edges · 12 communities
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 14 edges (avg confidence: 0.5)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Libro Domain, Persistence & Query
- EF Core Migrations (both APIs)
- Libro & WeatherForecast Controllers
- Autor Models, Persistence & Namespaces
- NuGet Dependencies & Build
- Create Commands & Validation (both APIs)
- Autor Query Handlers
- Autor Controller Endpoints
- Autor Launch Settings
- Libro Launch Settings
- Libro WeatherForecast Record
- Autor WeatherForecast Record

## God Nodes (most connected - your core abstractions)
1. `TiendaServicio.Api.Autor` - 11 edges
2. `TiendaServicios.Api.Libro` - 11 edges
3. `AutorDto` - 10 edges
4. `Manejador` - 10 edges
5. `Manejador` - 10 edges
6. `Manejador` - 9 edges
7. `TiendaServicio.Api.Autor.Modelo` - 9 edges
8. `ContextoAutor` - 9 edges
9. `TiendaServicio.Api.Autor.Aplicacion` - 7 edges
10. `Manejador` - 7 edges

## Surprising Connections (you probably didn't know these)
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Consulta.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/ConsultaFiltro.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `ContextoAutor`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs
- `Manejador` --references--> `ContextoLibreria`  [EXTRACTED]
  TiendaServicios.Api.Libro/Aplicacion/Nuevo.cs → TiendaServicios.Api.Libro/Persistencia/ContextoLibreria.cs
- `ListaAutor` --references--> `AutorDto`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Consulta.cs → TiendaServicio.Api.Autor/Aplicacion/AutorDto.cs

## Import Cycles
- None detected.

## Communities (12 total, 0 thin omitted)

### Community 0 - "Libro Domain, Persistence & Query"
Cohesion: 0.10
Nodes (22): TiendaServicios.Api.Libro.Modelo, TiendaServicios.Api.Libro.Persistencia, TiendaServicios.Api.Libro.Aplicacion, DbContext, ListaLibro, Profile, CancellationToken, IMapper (+14 more)

### Community 1 - "EF Core Migrations (both APIs)"
Cohesion: 0.08
Nodes (14): TiendaServicios.Api.Libro.Migrations, TiendaServicio.Api.Autor.Migrations, Migration, ModelSnapshot, MigrationBuilder, ModelBuilder, MigracionIncial, ModelBuilder (+6 more)

### Community 2 - "Libro & WeatherForecast Controllers"
Cohesion: 0.08
Nodes (21): ControllerBase, TiendaServicios.Api.Libro.Controllers, HttpGet, IEnumerable, string, WeatherForecast, WeatherForecastController, ActionResult (+13 more)

### Community 3 - "Autor Models, Persistence & Namespaces"
Cohesion: 0.14
Nodes (12): TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Modelo, TiendaServicio.Api.Autor.Aplicacion, TiendaServicio.Api.Autor.Controllers, ICollection, MappingProfile, DateTime, AutorLibro (+4 more)

### Community 4 - "NuGet Dependencies & Build"
Cohesion: 0.09
Nodes (22): Microsoft.EntityFrameworkCore.SqlServer (10.0.12), Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3), TiendaServicio.Api.Autor, net10.0, AutoMapper (16.2.0), FluentValidation.AspNetCore (11.3.1), MediatR (12.4.1), Microsoft.EntityFrameworkCore (10.0.12) (+14 more)

### Community 5 - "Create Commands & Validation (both APIs)"
Cohesion: 0.13
Nodes (18): AbstractValidator, IRequest, CancellationToken, DateTime, Task, Ejecuta, EjecutaValidacion, Manejador (+10 more)

### Community 6 - "Autor Query Handlers"
Cohesion: 0.15
Nodes (18): AutorUnico, IRequestHandler, ListaAutor, DateTime, AutorDto, CancellationToken, IMapper, List (+10 more)

### Community 7 - "Autor Controller Endpoints"
Cohesion: 0.25
Nodes (8): ActionResult, HttpGet, HttpPost, IActionResult, IMediator, List, Task, AutorController

### Community 8 - "Autor Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 9 - "Libro Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 10 - "Libro WeatherForecast Record"
Cohesion: 0.50
Nodes (3): TiendaServicios.Api.Libro, DateOnly, WeatherForecast

### Community 11 - "Autor WeatherForecast Record"
Cohesion: 0.50
Nodes (3): TiendaServicio.Api.Autor, DateOnly, WeatherForecast

## Knowledge Gaps
- **36 isolated node(s):** `$schema`, `commandName`, `dotnetRunMessages`, `launchBrowser`, `launchUrl` (+31 more)
  These have ≤1 connection - possible missing edges or undocumented components.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `TiendaServicio.Api.Autor.Persistencia` connect `Autor Models, Persistence & Namespaces` to `EF Core Migrations (both APIs)`?**
  _High betweenness centrality (0.087) - this node is a cross-community bridge._
- **Why does `Manejador` connect `Libro Domain, Persistence & Query` to `Libro & WeatherForecast Controllers`, `Autor Query Handlers`?**
  _High betweenness centrality (0.086) - this node is a cross-community bridge._
- **Why does `AutorController` connect `Autor Controller Endpoints` to `Libro & WeatherForecast Controllers`, `Autor Models, Persistence & Namespaces`?**
  _High betweenness centrality (0.084) - this node is a cross-community bridge._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicio.Api.Autor/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicios.Api.Libro/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `$schema`, `commandName`, `dotnetRunMessages` to the rest of the system?**
  _36 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Libro Domain, Persistence & Query` be split into smaller, more focused modules?**
  _Cohesion score 0.10114942528735632 - nodes in this community are weakly interconnected._