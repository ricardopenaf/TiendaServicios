using AutoMapper;
using GenFu;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
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

        private Mock<ContextoLibreria> CrearContexto()
        {
            var libro = new LibreriaMaterial
            {
                LibreriaMaterialId = Guid.Empty,
                Titulo = "Libro de prueba",
                FechaPublicacion = DateTime.Now
            };

            var mockSet = new Mock<DbSet<LibreriaMaterial>>();
            mockSet
                .Setup(m => m.FindAsync(It.IsAny<object[]>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(libro);

            var mockContexto = new Mock<ContextoLibreria>();
            mockContexto.Setup(c => c.LibreriaMaterial).Returns(mockSet.Object);

            return mockContexto;
        }

        [Fact]
        public async Task GetLibroPorId()
        {
            var mockupConexto = CrearContexto();
            var mapConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, NullLoggerFactory.Instance);

            var mapper = mapConfig.CreateMapper();
            var request = new ConsultaFiltro.LibroUnico();
            request.LibroId = Guid.Empty;

            var manejador = new ConsultaFiltro.Manejador(mockupConexto.Object, mapper);
            var libro = await manejador.Handle(request, new System.Threading.CancellationToken());
            Assert.NotNull(libro);
            Assert.True(libro.LibreriaMaterialId == Guid.Empty);

        }


        [Fact]
        public async Task GetLibros()
        {
            //System.Diagnostics.Debugger.Launch();
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

        [Fact]
        public async Task GuardarLibro()
        {
            //System.Diagnostics.Debugger.Launch();
            var options = new DbContextOptionsBuilder<ContextoLibreria>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var contexto = new ContextoLibreria(options);
            var request = new Nuevo.Ejecuta();
            request.Titulo = "Libro de prueba";
            request.AutorLibro = Guid.Empty;
            request.FechaPublicacion = DateTime.Now;

            var manejador = new Nuevo.Manejador(contexto);

            await manejador.Handle(request, new System.Threading.CancellationToken());

            var libro = await contexto.LibreriaMaterial.FirstOrDefaultAsync(x => x.Titulo == request.Titulo);
            Assert.True(libro != null);

        }

    }
}
