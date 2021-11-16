using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/estado")]
    public class EstadoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetListado()
        {
           var data = new[]{
               new{ Id = 1, Descripcion = "Activo", estaActivo = true },
               new{ Id = 2, Descripcion = "Inactivo", estaActivo = true },
               new{ Id = 3, Descripcion = "Pendiente", estaActivo = true },
           };
           return Ok(data);
        }
    }
}