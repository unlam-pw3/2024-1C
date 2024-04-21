using Clase4.MVC.Entidades;
using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase4.MVC.Web.Controllers
{
    public class DiasInternacionalesController : Controller
    {
        private readonly IDiaInternacionalService _diaInternacionalService;

        public DiasInternacionalesController(IDiaInternacionalService diaInternacionalService)
        {
            _diaInternacionalService = diaInternacionalService;
        }

        public IActionResult Index()
        {
            var diasInternacionales = _diaInternacionalService.ObtenerDiasInternacionales();
            var model = DiaInternacionalModel.MapToModel(diasInternacionales);
            return View(model);
        }

        [HttpPost]
        public IActionResult FiltrarPorCategoria(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                return RedirectToAction("Index");
            }

            var diasInternacionalesFiltrados = _diaInternacionalService.FiltrarPorCategoria(categoria);
            var model = DiaInternacionalModel.MapToModel(diasInternacionalesFiltrados);
            return View("Index", model);
        }
    }
}
