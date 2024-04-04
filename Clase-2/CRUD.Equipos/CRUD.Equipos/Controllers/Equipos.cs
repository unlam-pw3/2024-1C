using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CRUD.Equipos.Services;
using CRUD.Equipos.Entidades;

namespace CRUD.Equipos.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoServicio _equipoServicio;

        public EquipoController(IEquipoServicio equipoServicio)
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
        [HttpDelete("{nombre}")]
        public IActionResult Delete(string nombre)
        {
            var equipo = _equipoServicio.ObtenerTodos().FirstOrDefault(e => e.Nombre == nombre);
            if (equipo == null)
            {
                return NotFound();
            }

            _equipoServicio.Eliminar(equipo);
            return NoContent();
        }

    }
}
