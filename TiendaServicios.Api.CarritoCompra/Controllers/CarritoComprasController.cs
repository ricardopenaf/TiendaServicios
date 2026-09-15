using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.CarritoCompra.Aplicacion;

namespace TiendaServicios.Api.CarritoCompra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoComprasController : ControllerBase
    {
        readonly IMediator _mediator;
        public CarritoComprasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            await _mediator.Send(data);        // Send devuelve Task (sin valor)
            return Ok(Unit.Value);             // devolver un Unit explícito
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<CarritoDto>> GetCarrito(int id)
        {
            var carrito = await _mediator.Send(new Consulta.Ejecuta { CarritoSessionId = id });
            return Ok(carrito);
        }
    }
}
