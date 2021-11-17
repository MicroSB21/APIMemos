using Aplicacion.Acciones;
using AutoMapper;
using Dominio;

namespace Infraestructura.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Accion, AccionDTO>().ForMember(x=> x.Usuario, y=> y.MapFrom(z => z.SistemaUsuario));
            CreateMap<AccionDTO, Accion>().ForMember(x=> x.SistemaUsuario, y=> y.MapFrom(z=> z.Usuario));

        }
    }
}