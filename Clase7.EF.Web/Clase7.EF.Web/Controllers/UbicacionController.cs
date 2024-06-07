using Clase7.EF.Data.EF;
using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UbicacionController : ControllerBase
    {
        private IUbicacionServicio _ubicacionServicio;

        public UbicacionController(IUbicacionServicio ubicacionServicio)
        {
            _ubicacionServicio = ubicacionServicio;
        }

        [HttpGet]
        public List<Ubicacion> Get()
        {
            return _ubicacionServicio.obtenerTodos();
        }

        [HttpGet("id")]
        public Ubicacion Get(int id)
        {
            return _ubicacionServicio.obtenerPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] Ubicacion ubicacion)
        {
            _ubicacionServicio.Agregar(ubicacion);
        }

        [HttpPut("id")]
        public void Put(int id, [FromBody] Ubicacion ubicacion)
        {
            ubicacion.Id = id;
            _ubicacionServicio.Actualizar(ubicacion);
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            _ubicacionServicio.Eliminar(id);
        }
    }
}
