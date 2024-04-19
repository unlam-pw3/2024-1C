using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea4.MVC.Servicios;
using Tarea4.MVC.Web.Models;

namespace Tarea4.MVC.Web.Controllers
{
    public class DiasInternacionalesController : Controller
    {
        private readonly IDiasInternacionalesService _diasInternacionalesService;
        public DiasInternacionalesController(IDiasInternacionalesService diasInternacionalesService)
        {
            _diasInternacionalesService = diasInternacionalesService;
        }

        public ActionResult Index()
        {
            var diasInternacionales = _diasInternacionalesService.ObtenerDiasInternacionales();
            return View(DiaInternacionalModel.MapToModel(diasInternacionales));
        }
        public IActionResult QueDiaEs(int dia, int mes)
        {
            string descripcionDiaInternacional = _diasInternacionalesService.QueDiaEs(dia, mes);
            QueDiaInternacionalEsModel queDiaInternacionalEs = new QueDiaInternacionalEsModel
            {
                Dia = dia,
                Mes = mes,
                QueDiaEs = descripcionDiaInternacional
            };
            return View(queDiaInternacionalEs);
        }
    }
}
