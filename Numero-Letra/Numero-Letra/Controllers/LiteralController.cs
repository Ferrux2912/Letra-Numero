using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Numero_Letra.Helpers;

namespace Numero_Letra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string LiteralGet(int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
        [HttpPost]
        public string LiteralPost([FromHeader]int numero)
        {
            return Conversores.NumeroALetras(numero);
        }
    }
}
