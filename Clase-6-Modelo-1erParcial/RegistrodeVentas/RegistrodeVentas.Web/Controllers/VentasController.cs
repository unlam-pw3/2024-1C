using Microsoft.AspNetCore.Mvc;
using RegistrodeVentas.Logica.Services;
using RegistrodeVentas.Web.Models;

namespace RegistrodeVentas.Web.Controllers
{
    public class VentasController : Controller
    {
        private readonly IVentasService _ventasService;

        public VentasController(IVentasService ventasService)
        {
            _ventasService = ventasService;
        }
        public IActionResult RegistrarVenta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarVenta(VentaModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _ventasService.RegistrarVenta(model.MapearAEntidad());

            return RedirectToAction("Resultados");
        }

        public IActionResult Resultados()
        {
            var ventas = _ventasService.ObtenerVentas();

            var VentasModelLista = VentaModel.MapearAListaModel(ventas);
            
            return View(VentasModelLista);
        }
    }
}
