using Microsoft.EntityFrameworkCore;
using MediatR;
using TiendaServicio.Api.Autor.Modelo;
using TiendaServicio.Api.Autor.Persistencia;
using AutoMapper;

namespace TiendaServicio.Api.Autor.Aplicacion
{
    public class ConsultaFiltro
    {
        public class AutorUnico : IRequest<AutorDto>
        {
            public string AutorGuid { get; set; }
        }

        public class Manejador : IRequestHandler<AutorUnico, AutorDto>
        {
            private readonly ContextoAutor _contexto;
            private readonly IMapper _mapper;
            public Manejador(ContextoAutor contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }
            public async Task<AutorDto> Handle(AutorUnico request, CancellationToken cancellationToken)
            {
                var autor = await _contexto.AutorLibro.Where(x => x.AutorLibroGuid == request.AutorGuid).FirstOrDefaultAsync();
                if (autor == null)
                {
                    throw new Exception("No se encontró el autor");
                }
                var autorDto = _mapper.Map<AutorDto>(autor);
                return autorDto;
            }
        }   
    }
}
