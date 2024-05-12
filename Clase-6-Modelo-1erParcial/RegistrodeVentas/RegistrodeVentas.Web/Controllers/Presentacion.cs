using Microsoft.AspNetCore.Mvc;

namespace RegistrodeVentas.Web.Controllers
{
    public class Presentacion : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
