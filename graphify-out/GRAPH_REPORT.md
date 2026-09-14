# Graph Report - TiendaServicios  (2026-09-14)

## Corpus Check
- 19 files · ~3,390 words
- Verdict: corpus is large enough that graph structure adds value.

## Summary
- 278 nodes · 381 edges · 17 communities (16 shown, 1 thin omitted)
- Extraction: 96% EXTRACTED · 4% INFERRED · 0% AMBIGUOUS · INFERRED: 14 edges (avg confidence: 0.55)
- Token cost: 0 input · 0 output

## Community Hubs (Navigation)
- Autor Domain Core
- Carrito Domain Core
- Create/Validate Handlers
- EF Migration Snapshots
- API Controllers Scaffold
- Libro Query Filter
- EF Migration Scripts
- Libro Controller
- Project Dependencies
- Libro List Query
- Autor Controller
- Autor Launch Settings
- Carrito Launch Settings
- Libro Launch Settings
- Carrito Weather Scaffold
- Autor Weather Scaffold
- Misc IActionResult

## God Nodes (most connected - your core abstractions)
1. `TiendaServicios.Api.CarritoCompra` - 11 edges
2. `AutorDto` - 10 edges
3. `Manejador` - 10 edges
4. `Manejador` - 10 edges
5. `ContextoAutor` - 9 edges
6. `Manejador` - 9 edges
7. `TiendaServicio.Api.Autor.Modelo` - 9 edges
8. `Manejador` - 7 edges
9. `Manejador` - 7 edges
10. `TiendaServicio.Api.Autor.Persistencia` - 7 edges

## Surprising Connections (you probably didn't know these)
- `ContextoLibreria` --references--> `LibreriaMaterial`  [EXTRACTED]
  TiendaServicios.Api.Libro/Persistencia/ContextoLibreria.cs → TiendaServicios.Api.Libro/Modelo/LibreriaMaterial.cs
- `Manejador` --references--> `ContextoLibreria`  [EXTRACTED]
  TiendaServicios.Api.Libro/Aplicacion/Nuevo.cs → TiendaServicios.Api.Libro/Persistencia/ContextoLibreria.cs
- `AutorLibro` --references--> `GradoAcademico`  [EXTRACTED]
  TiendaServicio.Api.Autor/Modelo/AutorLibro.cs → TiendaServicio.Api.Autor/Modelo/GradoAcademico.cs
- `ContextoAutor` --references--> `AutorLibro`  [EXTRACTED]
  TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs → TiendaServicio.Api.Autor/Modelo/AutorLibro.cs
- `ContextoAutor` --references--> `GradoAcademico`  [EXTRACTED]
  TiendaServicio.Api.Autor/Persistencia/ContextoAutor.cs → TiendaServicio.Api.Autor/Modelo/GradoAcademico.cs

## Import Cycles
- None detected.

## Communities (17 total, 1 thin omitted)

### Community 0 - "Autor Domain Core"
Cohesion: 0.08
Nodes (33): AutorUnico, TiendaServicio.Api.Autor.Persistencia, TiendaServicio.Api.Autor.Modelo, TiendaServicio.Api.Autor.Aplicacion, TiendaServicio.Api.Autor.Migrations, IRequestHandler, ListaAutor, Profile (+25 more)

### Community 1 - "Carrito Domain Core"
Cohesion: 0.08
Nodes (24): TiendaServicios.Api.CarritoCompra.Persistencia, TiendaServicios.Api.CarritoCompra.Aplicacion, TiendaServicios.Api.CarritoCompra.Modelo, DbContext, DbSet, ICollection, CancellationToken, DateTime (+16 more)

### Community 2 - "Create/Validate Handlers"
Cohesion: 0.09
Nodes (22): AbstractValidator, TiendaServicios.Api.Libro.Modelo, TiendaServicios.Api.Libro.Persistencia, TiendaServicios.Api.Libro.Aplicacion, CancellationToken, Task, EjecutaValidacion, Ejecuta (+14 more)

### Community 3 - "EF Migration Snapshots"
Cohesion: 0.10
Nodes (11): TiendaServicios.Api.Libro.Migrations, ModelSnapshot, ModelBuilder, ContextoAutorModelSnapshot, ModelBuilder, CarritoContextoModelSnapshot, MigrationBuilder, ModelBuilder (+3 more)

### Community 4 - "API Controllers Scaffold"
Cohesion: 0.11
Nodes (15): ControllerBase, TiendaServicios.Api.CarritoCompra.Controllers, TiendaServicio.Api.Autor.Controllers, IEnumerable, string, HttpGet, IEnumerable, string (+7 more)

### Community 5 - "Libro Query Filter"
Cohesion: 0.11
Nodes (16): IRequest, LibroUnico, DateTime, Ejecuta, CancellationToken, ContextoLibreria, Guid, IMapper (+8 more)

### Community 6 - "EF Migration Scripts"
Cohesion: 0.14
Nodes (8): TiendaServicios.Api.CarritoCompra.Migrations, Migration, MigrationBuilder, MigrationBuilder, ModelBuilder, MigracionIncial, ModelBuilder, MigracionMysqlInicial

### Community 7 - "Libro Controller"
Cohesion: 0.17
Nodes (12): TiendaServicios.Api.Libro.Controllers, ActionResult, Ejecuta, Guid, HttpGet, HttpPost, IMediator, LibroMaterialDto (+4 more)

### Community 8 - "Project Dependencies"
Cohesion: 0.14
Nodes (13): net10.0, AutoMapper (16.2.0), FluentValidation.AspNetCore (11.3.1), MediatR (12.4.1), Microsoft.EntityFrameworkCore (10.0.12), Microsoft.EntityFrameworkCore.Design (10.0.12), Microsoft.EntityFrameworkCore.Tools (10.0.12), Mysql.EntityFrameworkCore (10.0.9) (+5 more)

### Community 9 - "Libro List Query"
Cohesion: 0.24
Nodes (10): ListaLibro, CancellationToken, ContextoLibreria, IMapper, LibroMaterialDto, List, Task, Consulta (+2 more)

### Community 10 - "Autor Controller"
Cohesion: 0.25
Nodes (7): ActionResult, HttpGet, HttpPost, IActionResult, List, Task, AutorController

### Community 11 - "Autor Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 12 - "Carrito Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 13 - "Libro Launch Settings"
Cohesion: 0.18
Nodes (10): ASPNETCORE_ENVIRONMENT, applicationUrl, commandName, dotnetRunMessages, environmentVariables, launchBrowser, launchUrl, profiles (+2 more)

### Community 14 - "Carrito Weather Scaffold"
Cohesion: 0.50
Nodes (3): TiendaServicios.Api.CarritoCompra, DateOnly, WeatherForecast

### Community 15 - "Autor Weather Scaffold"
Cohesion: 0.50
Nodes (3): TiendaServicio.Api.Autor, DateOnly, WeatherForecast

## Knowledge Gaps
- **36 isolated node(s):** `TiendaServicio.Api.Autor`, `ASPNETCORE_ENVIRONMENT`, `applicationUrl`, `commandName`, `dotnetRunMessages` (+31 more)
  These have ≤1 connection - possible missing edges or undocumented components.
- **1 thin communities (<3 nodes) omitted from report** — run `graphify query` to explore isolated nodes.

## Suggested Questions
_Questions this graph is uniquely positioned to answer:_

- **Why does `LibroController` connect `Libro Controller` to `API Controllers Scaffold`?**
  _High betweenness centrality (0.103) - this node is a cross-community bridge._
- **Why does `TiendaServicios.Api.Libro.Persistencia` connect `Create/Validate Handlers` to `EF Migration Snapshots`?**
  _High betweenness centrality (0.077) - this node is a cross-community bridge._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicio.Api.Autor/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **Are the 2 inferred relationships involving `Manejador` (e.g. with `IMediator` and `TiendaServicios.Api.Libro/Program.cs`) actually correct?**
  _`Manejador` has 2 INFERRED edges - model-reasoned connections that need verification._
- **What connects `TiendaServicio.Api.Autor`, `ASPNETCORE_ENVIRONMENT`, `applicationUrl` to the rest of the system?**
  _36 weakly-connected nodes found - possible documentation gaps or missing edges._
- **Should `Autor Domain Core` be split into smaller, more focused modules?**
  _Cohesion score 0.07729468599033816 - nodes in this community are weakly interconnected._
- **Should `Carrito Domain Core` be split into smaller, more focused modules?**
  _Cohesion score 0.07956989247311828 - nodes in this community are weakly interconnected._