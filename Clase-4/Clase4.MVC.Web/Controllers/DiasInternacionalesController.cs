using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers
{
    public class DiasInternacionalesController : Controller
    {
        private readonly IDiasInternacionalesServicio _diasInternacionalesServicio;

        public DiasInternacionalesController(IDiasInternacionalesServicio diasInternacionalesServicio)
        {

            _diasInternacionalesServicio = diasInternacionalesServicio;


        }
        public IActionResult Index()
        {
            var diasInternacionales = _diasInternacionalesServicio.ObtenerDiasInternacionales();
            return View(DiasInternacionalesModel.MapModel(diasInternacionales));
        }

        public IActionResult EsDiaInternacional(int dia, int mes)
        {
            EsDiaInternacionalModel esdiaInternacionalModel = new EsDiaInternacionalModel
            {
                Dia = dia,
                Mes = mes,
                EsDiaInternacional = _diasInternacionalesServicio.EsDiaInternacional(dia, mes)
            };
            return View(esdiaInternacionalModel);
        }
    }
}
