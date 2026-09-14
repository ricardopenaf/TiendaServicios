using MediatR;
using TiendaServicios.Api.CarritoCompra.Modelo;
using TiendaServicios.Api.CarritoCompra.Persistencia;

namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public DateTime FechaCreacionSesion { get; set; }
            public List<string> ProductoLista { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecuta>
        {
            private readonly CarritoContexto _contexto;
            public Manejador(CarritoContexto carritoContexto)
            {
                _contexto = carritoContexto;
            }
            public async Task Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var carritoSesion = new CarritoSesion
                {
                    FechaCreacion = request.FechaCreacionSesion
                };
                _contexto.CarritoSesion.Add(carritoSesion);
                var value = await _contexto.SaveChangesAsync();

                if(value == 0)
                {
                    throw new Exception("Errores en la inserción del carrito de compras");
                }   
               
                int carritoSesionId = carritoSesion.CarritoSesionId;

                foreach (var item in request.ProductoLista)
                {
                    var detalleSesion = new CarritoSesionDetalle
                    {
                        CarritoSesionId = carritoSesionId,
                        FechaCreacion = DateTime.Now,
                        ProductoSeleccionado = item
                    };
                    _contexto.CarritoSesionDetalle.Add(detalleSesion);
                }
                value =await _contexto.SaveChangesAsync();

                if(value > 0)
                {
                    return;
                }
                throw new Exception("Errores en la inserción del detalle del carrito de compras");

            }
        }
    }
}
