using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Libro.Persistencia;

namespace TiendaServicios.Api.Libro.Aplicacion
{
    public class Consulta
    {
        public class ListaLibro : IRequest<List<LibroMaterialDto>>
        {
        }
        /// <summary>
        /// Manejador de la consulta para obtener la lista de libros.
        /// </summary>
        public class Manejador : IRequestHandler<ListaLibro, List<LibroMaterialDto>>
        {
            private readonly ContextoLibreria _contexto;
            private readonly IMapper _mapper;

            public Manejador(ContextoLibreria contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<LibroMaterialDto>> Handle(ListaLibro request, CancellationToken cancellationToken)
            {
                var libros = await _contexto.LibreriaMaterial.ToListAsync(cancellationToken);
                return _mapper.Map<List<LibroMaterialDto>>(libros);
            }
        }

    }
}
