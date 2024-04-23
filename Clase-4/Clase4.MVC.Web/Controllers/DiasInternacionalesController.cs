using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers;

public class DiasInternacionalesController : Controller
{
    private readonly IDiasInternacionalesService _diasInternacionalesService;

    public DiasInternacionalesController(IDiasInternacionalesService diasInternacionalesService)
    {
        _diasInternacionalesService = diasInternacionalesService;
    }
    public IActionResult Index()
    {
        var diasInternacionales = _diasInternacionalesService.ObtenerDiasInternacionales();
        return View(DiaInternacionalModel.MapToModel(diasInternacionales));
    }
}