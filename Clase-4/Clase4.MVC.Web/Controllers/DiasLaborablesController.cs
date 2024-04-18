using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers
{
    public class DiasLaborablesController : Controller
    {
        private readonly IFeriadosService _feriadosService;

        public DiasLaborablesController(IFeriadosService feriadosService)
        {
            _feriadosService = feriadosService;
        }
        
        public IActionResult EsLaborable(int dia, int mes)
        {
            EsFeriadoModel esFeriadoModel = new EsFeriadoModel
            {
                Dia = dia,
                Mes = mes,
                EsFeriado = _feriadosService.EsFeriado(dia, mes)
            };
            return View(esFeriadoModel);
        }
    }
}
