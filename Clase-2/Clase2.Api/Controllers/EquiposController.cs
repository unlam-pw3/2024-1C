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
        IEquiposServicio _equipoServicio;

        public EquiposController(IEquiposServicio equipoServicio) {
           _equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_equipoServicio.ObtenerEquipos());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Equipo equipo)
        {
            _equipoServicio.Agregar(equipo);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpDelete("{nombre_equipo}")]
        public IActionResult Delete(string nombre_equipo)
        {
            var equipoEncontrado = _equipoServicio.ObtenerEquipoPorNombre(nombre_equipo);
            if (equipoEncontrado == null)
            {
                return NotFound(); // Devolver 404 si el equipo no se encuentra
            }

            _equipoServicio.Eliminar(equipoEncontrado);
            return NoContent(); // Devolver 204 para indicar que el equipo se eliminó correctamente
        }


    }
}
