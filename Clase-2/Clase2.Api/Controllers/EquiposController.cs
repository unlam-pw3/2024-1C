using Clase.Logica;
using Clase2.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        IEquipoServicio _equipoServicio;

        public EquiposController(IEquipoServicio equipoServicio)
        {
            _equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_equipoServicio.ObtenerTodos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Equipo equipo)
        {
            _equipoServicio.Agregar(equipo);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _equipoServicio.Eliminar(id);
            return Ok();
        }

    }
}
