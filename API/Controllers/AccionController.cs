using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("accion")]
    public class AccionController: ControllerBase
    {
        [HttpGet]
        public List<string> GetListado()
        {
            List<string> listado = new(){"Mario", "Luigi", "Zelda", "Link"};
            return listado;
        }
    }
}