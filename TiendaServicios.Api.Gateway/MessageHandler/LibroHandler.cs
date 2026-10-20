using System.Diagnostics;
using System.Text.Json;
using TiendaServicios.Api.Gateway.InterfaceRemote;
using TiendaServicios.Api.Gateway.LibroRemote;

namespace TiendaServicios.Api.Gateway.MessageHandler
{
    public class LibroHandler: DelegatingHandler
    {
        private readonly ILogger<LibroHandler> _logger;
        private readonly IAutorRemote _autorRemote;
        public LibroHandler(ILogger<LibroHandler> logger, IAutorRemote autorRemote)
        {
            _logger = logger;
            _autorRemote = autorRemote;
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var tiempoInicio = Stopwatch.StartNew();
            _logger.LogInformation("Iniciando la solicitud HTTP: {Method} {RequestUri}", request.Method, request.RequestUri);
            var response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var options  = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
               var  resultado = JsonSerializer.Deserialize<LibroModeloRemote>(content, options);
               var responseAutor = await _autorRemote.GetAutor(resultado.AutorLibro?? Guid.Empty);
                if(responseAutor.resultado)
                {
                    resultado.AutorData = responseAutor.autor;
                    response.Content = new StringContent(JsonSerializer.Serialize(resultado), System.Text.Encoding.UTF8, "application/json");
                    _logger.LogInformation("Autor encontrado: {AutorNombre}", responseAutor.autor.Nombre);
                }
               

            }
            
            _logger.LogInformation("Respuesta recibida: {StatusCode} {ResponseUri}", response.StatusCode, response.RequestMessage?.RequestUri);
            return response;
        }
    }
}
