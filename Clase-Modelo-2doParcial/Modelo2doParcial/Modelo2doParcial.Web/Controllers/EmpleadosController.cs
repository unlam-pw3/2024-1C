using Microsoft.AspNetCore.Mvc;
using Modelo2doParcial.Entidades.EF;
using Modelo2doParcial.Logica.Servicios;

namespace Modelo2doParcial.Web.Controllers
{
    public class EmpleadosController : Controller
    {
        IEmpleadosServicio _empleadosServicio;
        ISucursalesServicio _sucursalesServicio;
        public EmpleadosController(IEmpleadosServicio empleadosServicio, ISucursalesServicio sucursalesServicio)
        {
            _empleadosServicio = empleadosServicio;
            _sucursalesServicio = sucursalesServicio;
        }
        public IActionResult Index(int? idSucursal)
        {
            ViewBag.Sucursales = _sucursalesServicio.Listar();
            ViewBag.IdSucursalElegida = idSucursal;
            
            if (idSucursal.HasValue)
            {
                var empleados = _empleadosServicio.ListarPorSucursal(idSucursal.Value);
                return View(empleados);
            }
            else
            {
                var empleados = _empleadosServicio.Listar();
                return View(empleados);
            }
        }

        //crear empleados

        [HttpGet]
        public IActionResult Crear()
        {
            ViewBag.Sucursales = _sucursalesServicio.Listar();
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Empleado empleado)
        {
            ViewBag.Sucursales = _sucursalesServicio.Listar();

            if (!ModelState.IsValid)
                return View(empleado);
            
            _empleadosServicio.CrearEmpleado(empleado);

            return RedirectToAction("Index");
        }


    }
}
