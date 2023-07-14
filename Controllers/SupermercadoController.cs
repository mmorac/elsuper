using elsuper.DAL;
using elsuper.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace elsuper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupermercadoController : Controller
    {
        [HttpGet]
        [Route("/{nombre}")]
        // GET: SupermercadoController/Details/5
        public ActionResult Details(string nombre)
        {
            Supermercado super = SupermercadoDAL.getSupermercado(nombre);
            if(super != null) {
                return Ok(new { supermercado = super });
            }

            return BadRequest(new { mensaje = "No se encontró el supermercado consultado." });
        }

    }
}
