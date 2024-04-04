using Clase.Logica;
using Clase2.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadosController : ControllerBase
    {
        IResultadoServicio _resultadoServicio;
        public ResultadosController(IResultadoServicio resultadoServicio)
        {
            _resultadoServicio = resultadoServicio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_resultadoServicio.ObtenerTodos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Resultado resultado)
        {
            _resultadoServicio.Agregar(resultado);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
