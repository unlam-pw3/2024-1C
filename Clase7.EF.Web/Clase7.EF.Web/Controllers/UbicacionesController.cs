using Clase7.EF.Data.EF;
using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UbicacionesController : Controller
    {
        private IUbicacionService _ubicacionService;

        public UbicacionesController(IUbicacionService ubicacionService)
        {
            _ubicacionService = ubicacionService;
        }

        [HttpGet]
        public List<Ubicacion> Get()
        {
            return this._ubicacionService.ObtenerTodos();
        }

        [HttpGet("{id}")]
        public Ubicacion Get(int id)
        {
            return _ubicacionService.ObtenerPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] Ubicacion ubicacion)
        {
            _ubicacionService.Agregar(ubicacion);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ubicacion ubicacion)
        {
            ubicacion.Id = id;
            _ubicacionService.Actualizar(ubicacion);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ubicacionService.Eliminar(id);
        }
    }
}
