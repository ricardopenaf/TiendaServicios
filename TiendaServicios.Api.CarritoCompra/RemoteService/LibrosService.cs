using TiendaServicios.Api.CarritoCompra.RemoteInterface;
using TiendaServicios.Api.CarritoCompra.RemoteModel;
using System.Text.Json;

namespace TiendaServicios.Api.CarritoCompra.RemoteService
{
    public class LibrosService : ILibroService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<LibrosService> _logger;
        public LibrosService(IHttpClientFactory httpClientFactory, ILogger<LibrosService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<(bool resultado, LibroRemote Libro, string mensaje)> GetLibro(Guid libroId)
        {
            try
            {
                var cliente = _httpClientFactory.CreateClient("Libros");
                var response = await cliente.GetAsync($"api/LibroMaterial/{libroId}");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    var resultado = JsonSerializer.Deserialize<LibroRemote>(contenido, options);
                    return (true, resultado, string.Empty);
                }
                return (false, null, response.ReasonPhrase);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el libro con ID {LibroId}", libroId);
                return (false, null, ex.Message);
            }
        }
    }
}
