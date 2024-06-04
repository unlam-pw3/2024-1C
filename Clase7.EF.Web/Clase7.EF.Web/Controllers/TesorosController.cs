using Clase7.EF.Data.EF;
using Clase7.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase7.EF.Web.Controllers;

[ApiController]
[Route("[controller]")]

public class TesorosController : Controller
{
    private ITesoroService _tesoroService;

    public TesorosController(ITesoroService tesoroService)
    {
        this._tesoroService = tesoroService;
    }
    [HttpGet]
    public List<Tesoro> Get()
    {
        return this._tesoroService.ObtenerTodos();
    }

    [HttpGet("{id}")]
    public Tesoro Get(int id)
    { 
        return this._tesoroService.ObtenerPorId(id);
    }

    [HttpPost]
    public void Post([FromBody] Tesoro tesoro)
    {
        _tesoroService.Agregar(tesoro);
    }

    [HttpPut("{id}")]
    public void Put(int id,[FromBody] Tesoro tesoro)
    {   
        tesoro.Id = id;
        _tesoroService.Actualizar(tesoro);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    { 
        _tesoroService.Eliminar(id);
    }
}
