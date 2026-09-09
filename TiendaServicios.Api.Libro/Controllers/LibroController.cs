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

        [HttpPost]
        public async Task<IActionResult> Crear(Nuevo.Ejecuta data)
        {
            await _mediator.Send(data);
            return NoContent();
        }
    }
}
