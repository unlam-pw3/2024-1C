using Clase.Logica;
using Clase2.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Clase2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        private readonly IEquipoServicio _equipoServicio;

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

        [HttpPut("{nombre}")]
        public IActionResult Put(string nombre, [FromBody] Equipo equipo)
        {
            _equipoServicio.Modificar(nombre, equipo);
            return Ok();
        }

        [HttpDelete("{nombre}")]
        public IActionResult Delete(string nombre)
        {
            _equipoServicio.Eliminar(nombre);
            return Ok();
        }
    }
}
