namespace TiendaServicios.Api.Libro.Aplicacion
{
    public class ConsultaFiltro
    {
        public class LibroUnico : MediatR.IRequest<LibroMaterialDto>
        {
            public Guid? LibroId { get; set; }
        }

        public class Manejador : MediatR.IRequestHandler<LibroUnico, LibroMaterialDto>
        {
            private readonly Persistencia.ContextoLibreria _contexto;
            private readonly AutoMapper.IMapper _mapper;
            public Manejador(Persistencia.ContextoLibreria contexto, AutoMapper.IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<LibroMaterialDto> Handle(LibroUnico request, CancellationToken cancellationToken)
            {
                var libro = await _contexto.LibreriaMaterial.FindAsync(new object[] { request.LibroId }, cancellationToken);
                if (libro == null)
                {
                    throw new Exception("No se encontró el libro");
                }
                return _mapper.Map<LibroMaterialDto>(libro);
            }
        }
    }
}
