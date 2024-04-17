using Clase4.MVC.Web.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers;

public class FeriadosController : Controller
{
    private readonly IFeriadosService _feriadosService;

    public FeriadosController(IFeriadosService feriadosService)
    {
        _feriadosService = feriadosService;
    }
    public IActionResult Index()
    {
        var feriados = _feriadosService.ObtenerFeriados();
        return View(feriados);
    }
}
