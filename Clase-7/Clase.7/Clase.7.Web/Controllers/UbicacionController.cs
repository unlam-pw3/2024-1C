using Clase._7.Data.Entidades;
using Clase._7.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clase._7.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UbicacionController : Controller
{
    IServicioUbicacion _servicioUbicacion;

    public UbicacionController(IServicioUbicacion servicioUbicacion)
    {
        _servicioUbicacion = servicioUbicacion;
    }

    [HttpGet]
    public List<Ubicacion> GetUbicaciones()
    {
        return _servicioUbicacion.ObtenerTodos();
    }

    [HttpPost]
    public void PostUbicacion([FromBody] Ubicacion ubicacion)
    {
        _servicioUbicacion.Agregar(ubicacion);
    }

    [HttpPut("{id}")]
    public void PutUbicacion(int id, [FromBody] Ubicacion ubicacion)
    {
        ubicacion.Id = id;
        _servicioUbicacion.Actualizar(ubicacion);
    }

    [HttpDelete("{id}")]
    public void DeleteUbicacion(int id)
    {
        _servicioUbicacion.Eliminar(id);
    }
}
