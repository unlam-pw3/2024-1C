using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models;

public class FeriadoModel : DiaEspecialModel
{
    public bool EsInamovible { get; set; }

    public FeriadoModel()
    {
        
    }
    public FeriadoModel(Feriado feriado)
    {
        Fecha = feriado.Fecha;
        Nombre = feriado.Nombre;
        EsInamovible = feriado.EsInamovible;
    }

    public static List<FeriadoModel> MapToModel(List<Feriado> feriados)
    {
        return feriados.Select(f => new FeriadoModel(f)).ToList();
    }
}
