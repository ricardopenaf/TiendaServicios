using AutoMapper;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Moq;
using TiendaServicios.Api.Libro.Aplicacion;
using TiendaServicios.Api.Libro.Modelo;
using TiendaServicios.Api.Libro.Persistencia;


namespace TiendaServicios.Api.Libro.Test
{
    public class LibrosServicesTest
    {

        private List<LibreriaMaterial> ObtenerDataPrueba()
        {
            A.Configure<LibreriaMaterial>()
                .Fill(x => x.Titulo).AsArticleTitle()
                .Fill(x => x.LibreriaMaterialId, () => Guid.NewGuid());

            var lista = A.ListOf<LibreriaMaterial>(30);
            lista[0].LibreriaMaterialId = Guid.Empty;
            return lista;
        }

        [Fact]
        public async Task GetLibros()
        {
            // Que metodo dentro de mi microservice libro se esta encargando de realizar
            // la consulta de libros de la bf? (GET api/Libro/{id})
            //1. instancia de Entity Framework Core - ContextoLibreria respaldada por
            // una base de datos en memoria, sembrada con datos generados por GenFu
            var libreriaMaterial = ObtenerDataPrueba();

            var opciones = new DbContextOptionsBuilder<ContextoLibreria>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using var contexto = new ContextoLibreria(opciones);
            contexto.LibreriaMaterial.AddRange(libreriaMaterial);
            contexto.SaveChanges();

            //2. Emular el objeto mapping IMapper

            var librosEsperados = libreriaMaterial
                .Select(x => new LibroMaterialDto
                {
                    LibreriaMaterialId = x.LibreriaMaterialId,
                    Titulo = x.Titulo,
                    FechaPublicacion = x.FechaPublicacion,
                    AutorLibro = x.AutorLibro
                })
                .ToList();

            var mockmapper = new Mock<IMapper>();
            mockmapper
                .Setup(m => m.Map<List<LibroMaterialDto>>(It.IsAny<List<LibreriaMaterial>>()))
                .Returns(librosEsperados);

            //3. Instanciar la clase manejador y pasar como parametros el contexto y el mock del mapper

            Consulta.Manejador manejador = new Consulta.Manejador(contexto, mockmapper.Object);

            // Act
            var resultado = await manejador.Handle(new Consulta.ListaLibro(), CancellationToken.None);

            // Assert
            Assert.Equal(libreriaMaterial.Count, resultado.Count);
            Assert.Equal(librosEsperados.Select(x => x.LibreriaMaterialId), resultado.Select(x => x.LibreriaMaterialId));
            Assert.Contains(resultado, x => x.LibreriaMaterialId == Guid.Empty);
        }
    }
}
