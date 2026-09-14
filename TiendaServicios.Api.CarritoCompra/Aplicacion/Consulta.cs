using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.CarritoCompra.Persistencia;
using TiendaServicios.Api.CarritoCompra.RemoteInterface;

namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class Consulta
    {
        public class Ejecuta : IRequest<CarritoDto>
        {
            public  int CarritoSessionId { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta, CarritoDto>
        {
            private readonly CarritoContexto _contexto;
            private readonly ILibroService _libroService;
            public Manejador(CarritoContexto contexto, ILibroService libroService)
            {
                _contexto = contexto;
                _libroService = libroService;
            }
            public async Task<CarritoDto> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var carrito = await _contexto.CarritoSesion.FindAsync(new object[] { request.CarritoSessionId }, cancellationToken);
                if (carrito == null)
                {
                    throw new Exception($"No se encontró el carrito de compras con id {request.CarritoSessionId}");
                }

                var carritoSesionDetalle = await _contexto.CarritoSesionDetalle
                    .Where(x => x.CarritoSesionId == request.CarritoSessionId)
                    .ToListAsync(cancellationToken);

                var listaProductos = new List<CarritoDetalletDto>();
                foreach (var detalle in carritoSesionDetalle)
                {
                    if (!Guid.TryParse(detalle.ProductoSeleccionado, out var libroId))
                    {
                        continue;
                    }

                    var (resultado, libro, mensaje) = await _libroService.GetLibro(libroId);
                    if (!resultado || libro == null)
                    {
                        continue;
                    }

                    listaProductos.Add(new CarritoDetalletDto
                    {
                        LibroId = libroId,
                        TituloLibro = libro.Titulo,
                        AutorLibro = libro.AutorLibro?.ToString() ?? string.Empty,
                        FechaPublicacion = libro.FechaPublicacion
                    });
                }

                return new CarritoDto
                {
                    CarritoId = request.CarritoSessionId,
                    FechaSession = carrito.FechaCreacion,
                    ListaProductos = listaProductos
                };
            }
        }
    }
}
