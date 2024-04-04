using GestorDeTorneo.Interface;
using GestorDeTorneo.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeTorneo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartidosController : ControllerBase
    {

        private readonly IPartidos _service;

        public PartidosController(IPartidos partidos)
        {
            _service = partidos;
        }

        [HttpGet()]
        public async Task<IActionResult> GetPartidos()
        {
            try
            {
                List<Partido> Partidos = await _service.GetPartidos();
                return Ok(Partidos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener partidos: {ex.Message}");
            }
        }

        [HttpPost()]
        public async Task<IActionResult> PostAgregarPartido([FromBody] Partido partido)
        {
            try
            {
                var result = await _service.PostAgregarPartido(partido);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al agregar el partido: {ex.Message}");
            }
        }
    }
}