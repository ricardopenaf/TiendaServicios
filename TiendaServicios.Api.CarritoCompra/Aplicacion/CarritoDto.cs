namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class CarritoDto
    {
        public int CarritoId { get; set; }
        public DateTime? FechaSession { get; set; }
        public List<CarritoDetalletDto> ListaProductos { get; set; }
    }
}
