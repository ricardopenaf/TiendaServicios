using MediatR;
using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.Libro.Aplicacion;

namespace TiendaServicios.Api.Libro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibroController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<LibroMaterialDto>>> GetLibros()
        {
            return await _mediator.Send(new Consulta.ListaLibro());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LibroMaterialDto>> GetLibroById(Guid id)
        {
            return await _mediator.Send(new ConsultaFiltro.LibroUnico { LibroId = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            await _mediator.Send(data);
            return NoContent();
        }
    }
}
