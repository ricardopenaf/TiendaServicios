using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaServicio.Api.Autor.Aplicacion;
using TiendaServicio.Api.Autor.Modelo;

namespace TiendaServicio.Api.Autor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AutorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Nuevo.Ejecuta data)
        {
            await _mediator.Send(data);
            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<List<AutorDto>>> GetAutores()
        {
            var request = new Consulta.ListaAutor();
            var autores = await _mediator.Send(request);
            return autores;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AutorDto>> GetAutorLibro(string id)
        {
            var request = new ConsultaFiltro.AutorUnico { AutorGuid = id };
            var autor = await _mediator.Send(request);
            return autor;
        }
    }
}
