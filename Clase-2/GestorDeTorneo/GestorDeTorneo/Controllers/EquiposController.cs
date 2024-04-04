using GestorDeTorneo.Interface;
using Microsoft.AspNetCore.Mvc;
using GestorDeTorneo.Models;

namespace GestorDeTorneo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquiposController : ControllerBase
    {

        private readonly IEquipos _service;

        public EquiposController(IEquipos equipos)
        {
            _service = equipos;
        }

        [HttpGet()]
        public async Task<IActionResult> GetEquipos()
        {
            try
            {
                string nombresEquipos = await _service.GetEquipos();
                return Ok(nombresEquipos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener los nombres de los equipos: {ex.Message}");
            }
        }
        [HttpGet("GetEquiposConSuCancha")]
        public async Task<IActionResult> GetEquiposConSuCancha()
        {
            try
            {
                List<Equipo> EquiposYCanchas = await _service.GetEquiposConSuCancha();
                return Ok(EquiposYCanchas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener los nombres de los equipos y sus canchas: {ex.Message}");
            }
        }

        [HttpPost()]
        public async Task<IActionResult> AgregarEquipo([FromBody] Equipo equipo)
        {
            try
            {
                var result = await _service.PostAgregarEquipo(equipo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar un equipo: {ex.Message}");
            }
        }
    }
}