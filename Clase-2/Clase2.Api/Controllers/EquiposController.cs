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
            var equipoAgregado = _equipoServicio.Agregar(equipo);
            return StatusCode(StatusCodes.Status201Created, equipoAgregado);
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

        [HttpPut]
        public IActionResult Put([FromBody] Equipo equipo)
        {
            var equipoEncontrado = _equipoServicio.ObtenerEquipoPorId(equipo.Id);
            if (equipoEncontrado == null)
            {
                return NotFound(); // Devolver 404 si el equipo no se encuentra
            }

            _equipoServicio.Actualizar(equipo);
            return Ok(); // Devolver 200 para indicar que el equipo se actualizó correctamente
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var equipoEncontrado = _equipoServicio.ObtenerEquipoPorId(id);
            if (equipoEncontrado == null)
            {
                return NotFound(); // Devolver 404 si el equipo no se encuentra
            }

            return Ok(equipoEncontrado);
        }

    }
}
