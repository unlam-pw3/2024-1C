using Clase7.EF.Data.EF;
using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesoroController : ControllerBase
    {
        private ITesoroServicio _tesoroServicio;

        public TesoroController(ITesoroServicio tesoroServicio)
        {
            this._tesoroServicio = tesoroServicio;
        }

        [HttpGet]
        public List<Tesoro> Get()
        {
            return _tesoroServicio.obtenerTodos();
        }

        [HttpGet("id")]
        public Tesoro Get(int id)
        {
            return _tesoroServicio.obtenerPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] Tesoro tesoro)
        {
            _tesoroServicio.Agregar(tesoro);
        }

        [HttpPut("id")]
        public void Put(int id, [FromBody] Tesoro tesoro)
        {
            tesoro.Id = id;
            _tesoroServicio.Actualizar(tesoro);
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            _tesoroServicio.Eliminar(id);
        }
    }
}
