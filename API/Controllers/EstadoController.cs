using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Acciones;
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
            return Ok();
        }
    }
}