﻿using Clase4.MVC.Servicios;
using Clase4.MVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.MVC.Web.Controllers;

public class FeriadosController : Controller
{
    private readonly IFeriadosService _feriadosService;

    public FeriadosController(IFeriadosService feriadosService)
    {
        _feriadosService = feriadosService;
    }
    public IActionResult Index()
    {
        var feriados = _feriadosService.ObtenerFeriados();
        return View(FeriadoModel.MapToModel(feriados));
    }

    public IActionResult EsFeriado(int dia, int mes)
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
