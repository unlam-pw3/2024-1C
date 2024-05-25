using Clase._7.Data.Entidades;
using Clase._7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase._7.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class TesorosController : Controller
{
    private ITesoroServicio _tesoroServicio;

    public TesorosController(ITesoroServicio tesoroServicio)
    {
        _tesoroServicio = tesoroServicio;
    }
    [HttpGet]
    public List<Tesoro> GetTesoros()
    {
        return _tesoroServicio.ObtenerTodos();
    }
    [HttpPost]
    public void PostTesoro([FromBody] Tesoro tesoro)
    {
        _tesoroServicio.Agregar(tesoro);
    }

    [HttpPut("{id}")]
    public void PutTesoro(int id, [FromBody] Tesoro tesoro)
    {
        tesoro.Id = id;
        _tesoroServicio.Actualizar(tesoro);
    }

    [HttpDelete("{id}")]
    public void DeleteTesoro(int id)
    {
        _tesoroServicio.Eliminar(id);
    }
}
