# Graph Report - TiendaServicios  (2026-09-08)

## Corpus Check
- Corpus is ~8,576 words - fits in a single context window. You may not need a graph.

## Summary
- 87 nodes · 117 edges · 11 communities
- Extraction: 74% EXTRACTED · 26% INFERRED · 0% AMBIGUOUS · INFERRED: 30 edges (avg confidence: 0.8)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Domain Model & DbContext
- MediatR Request & Handler Contract
- Web API & WeatherForecast Sample
- EF Core Migrations (Postgres)
- Launch Settings
- NuGet Package References
- Request Pipeline & Composition Root

## God Nodes (most connected - your core abstractions)
1. `MigracionIncial` - 11 edges
2. `ContextoAutor` - 11 edges
3. `Manejador` - 10 edges
4. `AutorLibro` - 10 edges
5. `TiendaServicio.Api.Autor` - 9 edges
6. `AutorController` - 7 edges
7. `ContextoAutorModelSnapshot` - 7 edges
8. `Ejecuta` - 6 edges
9. `WeatherForecastController` - 6 edges
10. `GradoAcademico` - 6 edges

## Surprising Connections (you probably didn't know these)
- `WeatherForecastController` --semantically_similar_to--> `AutorController`  [INFERRED] [semantically similar]
  TiendaServicio.Api.Autor/Controllers/WeatherForecastController.cs → TiendaServicio.Api.Autor/Controllers/AutorController.cs
- `MigracionIncial` --semantically_similar_to--> `ContextoAutorModelSnapshot`  [INFERRED] [semantically similar]
  TiendaServicio.Api.Autor/Migrations/20260908165348_MigracionIncial.Designer.cs → TiendaServicio.Api.Autor/Migrations/ContextoAutorModelSnapshot.cs
- `Ejecuta` --shares_data_with--> `AutorLibro`  [INFERRED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Modelo/AutorLibro.cs
- `Manejador` --conceptually_related_to--> `AutorLibro`  [INFERRED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Modelo/AutorLibro.cs
- `Manejador` --conceptually_related_to--> `ContextoAutor`  [INFERRED]
  TiendaServicio.Api.Autor/Aplicacion/Nuevo.cs → TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs

## Import Cycles
- None detected.

## Hyperedges (group relationships)
- **Author creation request flow: Crear -> Ejecuta -> Manejador.Handle -> ContextoAutor -> AutorLibro** — tiendaservicio_api_autor_controllers_autorcontroller_tiendaservicio_api_autor_controllers_autorcontroller_crear, tiendaservicio_api_autor_aplicacion_nuevo_tiendaservicio_api_autor_aplicacion_ejecuta, tiendaservicio_api_autor_aplicacion_nuevo_tiendaservicio_api_autor_aplicacion_manejador, tiendaservicio_api_autor_aplicacion_nuevo_tiendaservicio_api_autor_aplicacion_manejador_handle, tiendaservicio_api_autor_persistencia_contextoautor_tiendaservicio_api_autor_persistencia_contextoautor, tiendaservicio_api_autor_modelo_autorlibro_tiendaservicio_api_autor_modelo_autorlibro [INFERRED 0.75]
- **MediatR DI wiring: Program.AddMediatR registers IMediator and IRequestHandler implementation Manejador** — tiendaservicio_api_autor_program, imediator, irequesthandler, tiendaservicio_api_autor_aplicacion_nuevo_tiendaservicio_api_autor_aplicacion_manejador [INFERRED 0.75]

## Communities (11 total, 0 thin omitted)

### Community 0 - "Domain Model & DbContext"
Cohesion: 0.17
Nodes (12): TiendaServicio.Api.Autor.Modelo, DbContext, DbSet, ICollection, ModelSnapshot, ModelBuilder, ContextoAutorModelSnapshot, DateTime (+4 more)

### Community 1 - "MediatR Request & Handler Contract"
Cohesion: 0.15
Nodes (12): ActionResult, CancellationToken, Ejecuta, HttpPost, IRequest, IRequestHandler, DateTime, Task (+4 more)

### Community 2 - "Web API & WeatherForecast Sample"
Cohesion: 0.15
Nodes (10): ControllerBase, TiendaServicio.Api.Autor, TiendaServicio.Api.Autor.Controllers, DateOnly, HttpGet, IEnumerable, string, WeatherForecastController (+2 more)

### Community 3 - "EF Core Migrations (Postgres)"
Cohesion: 0.19
Nodes (7): TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Migrations, Migration, MigrationBuilder, Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3), ModelBuilder, MigracionIncial

### Community 4 - "Launch Settings"
Cohesion: 0.20
Nodes (9): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, profiles, http (+1 more)

### Community 5 - "NuGet Package References"
Cohesion: 0.22
Nodes (8): net10.0, MediatR.Extensions.Microsoft.DependencyInjection (10.0.1), Microsoft.AspNetCore.OpenApi (10.0.11), Microsoft.EntityFrameworkCore (10.0.11), Microsoft.EntityFrameworkCore.Design (10.0.11), Microsoft.EntityFrameworkCore.Tools (10.0.11), Microsoft.NET.Sdk.Web, TiendaServicio.Api.Autor

### Community 6 - "Request Pipeline & Composition Root"
Cohesion: 0.43
Nodes (5): TiendaServicio.Api.Autor.Aplicacion, IMediator, Manejador, Nuevo, AutorController

## Knowledge Gaps
- **14 isolated node(s):** `$schema`, `commandName`, `dotnetRunMessages`, `launchBrowser`, `applicationUrl` (+9 more)
  These have ≤1 connection - possible missing edges or undocumented components.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `AutorController` connect `Request Pipeline & Composition Root` to `MediatR Request & Handler Contract`, `Web API & WeatherForecast Sample`?**
  _High betweenness centrality (0.221) - this node is a cross-community bridge._
- **Why does `ContextoAutor` connect `Domain Model & DbContext` to `MediatR Request & Handler Contract`, `EF Core Migrations (Postgres)`, `Request Pipeline & Composition Root`?**
  _High betweenness centrality (0.179) - this node is a cross-community bridge._
- **Why does `WeatherForecastController` connect `Web API & WeatherForecast Sample` to `Request Pipeline & Composition Root`?**
  _High betweenness centrality (0.177) - this node is a cross-community bridge._
- **Are the 5 inferred relationships involving `MigracionIncial` (e.g. with `Npgsql.EntityFrameworkCore.PostgreSQL (10.0.3)` and `ContextoAutorModelSnapshot`) actually correct?**
  _`MigracionIncial` has 5 INFERRED edges - model-reasoned connections that need verification._
- **Are the 6 inferred relationships involving `ContextoAutor` (e.g. with `Manejador` and `.Handle()`) actually correct?**
  _`ContextoAutor` has 6 INFERRED edges - model-reasoned connections that need verification._
- **Are the 7 inferred relationships involving `Manejador` (e.g. with `Ejecuta` and `IMediator`) actually correct?**
  _`Manejador` has 7 INFERRED edges - model-reasoned connections that need verification._
- **Are the 6 inferred relationships involving `AutorLibro` (e.g. with `Ejecuta` and `Manejador`) actually correct?**
  _`AutorLibro` has 6 INFERRED edges - model-reasoned connections that need verification._