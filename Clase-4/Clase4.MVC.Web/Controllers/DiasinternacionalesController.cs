using Clase4.MVC.Web.Models;
using Clase4.MVC.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers
{
    public class DiasinternacionalesController : Controller
    {
        private readonly IDiaInternacionalService _diaInternacionalService;

        public DiasinternacionalesController(IDiaInternacionalService diaInternacionalService)
        {
            _diaInternacionalService = diaInternacionalService;
        }

        public IActionResult Index()
        {
            var diasInternacionales = _diaInternacionalService.ObtenerDiasInternacionales();
            return View(DiaInternacionalModel.MapToModel(diasInternacionales));
        }

        public IActionResult EsDiaInternacional(int dia, int mes)
        {
            DiaDescripcionModel diaDescripcionModel = new DiaDescripcionModel
            {
                Dia = dia,

                Mes = mes,

                Verificacion = _diaInternacionalService.VerificarDia(dia, mes),

                Descripcion = _diaInternacionalService.obtenerDescripcion(dia, mes)

            };

            return View(diaDescripcionModel);
        }
    }
}
