using Clase4.MVC.Entidades;
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

    public IActionResult DiaInternacional(int dia, int mes)
    {
        var diaInternacional = _diasInternacionalesService.ObtenerDiaInternacional(dia, mes);

        return View(DiaInternacionalModel.MapOneToModel(diaInternacional));
    }
}