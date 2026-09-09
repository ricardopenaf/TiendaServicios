# Graph Report - TiendaServicios  (2026-09-09)

## Corpus Check
- Corpus is ~2,363 words - fits in a single context window. You may not need a graph.

## Summary
- 211 nodes · 296 edges · 13 communities
- Extraction: 95% EXTRACTED · 5% INFERRED · 0% AMBIGUOUS · INFERRED: 14 edges (avg confidence: 0.5)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Libro & WeatherForecast Controllers
- EF Core Migrations (both APIs)
- Autor Query Handlers & Persistence
- Libro Domain, Persistence & DI Root
- NuGet Dependencies & Build
- Autor Models & Namespaces
- Create Commands & Validation (both APIs)
- Libro Query Handler & DTO
- Autor Launch Settings
- Autor Controller Endpoints
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
- `ContextoAutor` --references--> `AutorLibro`  [EXTRACTED]
  TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs → TiendaServicio.Api.Autor/Modelo/AutorLibro.cs
- `ContextoAutor` --references--> `GradoAcademico`  [EXTRACTED]
  TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs → TiendaServicio.Api.Autor/Modelo/GradoAcademico.cs
- `Manejador` --references--> `ContextoLibreria`  [EXTRACTED]
  TiendaServicios.Api.Libro/Aplicacion/Consulta.cs → TiendaServicios.Api.Libro/Persistencia/ContextoLibreria.cs
- `ListaAutor` --references--> `AutorDto`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Consulta.cs → TiendaServicio.Api.Autor/Aplicacion/AutorDto.cs
- `Manejador` --references--> `AutorDto`  [EXTRACTED]
  TiendaServicio.Api.Autor/Aplicacion/Consulta.cs → TiendaServicio.Api.Autor/Aplicacion/AutorDto.cs

## Import Cycles
- None detected.

## Communities (13 total, 0 thin omitted)

### Community 0 - "Libro & WeatherForecast Controllers"
Cohesion: 0.08
Nodes (21): ControllerBase, TiendaServicio.Api.Autor.Controllers, TiendaServicios.Api.Libro.Controllers, HttpGet, IEnumerable, string, WeatherForecast, WeatherForecastController (+13 more)

### Community 1 - "EF Core Migrations (both APIs)"
Cohesion: 0.08
Nodes (14): TiendaServicios.Api.Libro.Migrations, TiendaServicio.Api.Autor.Migrations, Migration, ModelSnapshot, MigrationBuilder, ModelBuilder, MigracionIncial, ModelBuilder (+6 more)

### Community 2 - "Autor Query Handlers & Persistence"
Cohesion: 0.13
Nodes (23): AutorUnico, IRequest, IRequestHandler, ListaAutor, DateTime, AutorDto, CancellationToken, IMapper (+15 more)

### Community 3 - "Libro Domain, Persistence & DI Root"
Cohesion: 0.12
Nodes (18): TiendaServicios.Api.Libro.Modelo, TiendaServicios.Api.Libro.Persistencia, TiendaServicios.Api.Libro.Aplicacion, DbContext, Profile, MappingProfile, MappingProfile, DateTime (+10 more)

### Community 4 - "NuGet Dependencies & Build"
Cohesion: 0.09
Nodes (22): Microsoft.EntityFrameworkCore.SqlServer (10.0.12), Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3), TiendaServicio.Api.Autor, net10.0, AutoMapper (16.2.0), FluentValidation.AspNetCore (11.3.1), MediatR (12.4.1), Microsoft.EntityFrameworkCore (10.0.12) (+14 more)

### Community 5 - "Autor Models & Namespaces"
Cohesion: 0.18
Nodes (8): TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Modelo, TiendaServicio.Api.Autor.Aplicacion, ICollection, DateTime, AutorLibro, DateTime, GradoAcademico

### Community 6 - "Create Commands & Validation (both APIs)"
Cohesion: 0.17
Nodes (11): AbstractValidator, CancellationToken, DateTime, Task, Ejecuta, EjecutaValidacion, Nuevo, Ejecuta (+3 more)

### Community 7 - "Libro Query Handler & DTO"
Cohesion: 0.22
Nodes (11): ListaLibro, CancellationToken, IMapper, List, Task, Consulta, ListaLibro, Manejador (+3 more)

### Community 8 - "Autor Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 9 - "Autor Controller Endpoints"
Cohesion: 0.29
Nodes (7): ActionResult, HttpGet, HttpPost, IActionResult, List, Task, AutorController

### Community 10 - "Libro Launch Settings"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, http (+1 more)

### Community 11 - "Libro WeatherForecast Record"
Cohesion: 0.50
Nodes (3): TiendaServicios.Api.Libro, DateOnly, WeatherForecast

### Community 12 - "Autor WeatherForecast Record"
Cohesion: 0.50
Nodes (3): TiendaServicio.Api.Autor, DateOnly, WeatherForecast

## Knowledge Gaps
- **35 isolated node(s):** `$schema`, `commandName`, `dotnetRunMessages`, `launchBrowser`, `launchUrl` (+30 more)
  These have ≤1 connection - possible missing edges or undocumented components.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `TiendaServicio.Api.Autor.Persistencia` connect `Autor Models & Namespaces` to `EF Core Migrations (both APIs)`, `Autor Query Handlers & Persistence`?**
  _High betweenness centrality (0.088) - this node is a cross-community bridge._
- **Why does `Manejador` connect `Libro Query Handler & DTO` to `Autor Query Handlers & Persistence`, `Libro Domain, Persistence & DI Root`?**
  _High betweenness centrality (0.087) - this node is a cross-community bridge._
- **Why does `AutorController` connect `Autor Controller Endpoints` to `Libro & WeatherForecast Controllers`, `Autor Query Handlers & Persistence`, `Autor Models & Namespaces`?**
  _High betweenness centrality (0.085) - this node is a cross-community bridge._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicio.Api.Autor/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicios.Api.Libro/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `$schema`, `commandName`, `dotnetRunMessages` to the rest of the system?**
  _35 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Libro & WeatherForecast Controllers` be split into smaller, more focused modules?**
  _Cohesion score 0.07671957671957672 - nodes in this community are weakly interconnected._