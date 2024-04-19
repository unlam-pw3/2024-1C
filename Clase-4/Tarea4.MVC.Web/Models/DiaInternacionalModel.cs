using Tarea4.MVC.Entidades;

namespace Tarea4.MVC.Web.Models;

public class DiaInternacionalModel
{
    public DateTime Fecha { get; set; }
    public string Descripcion { get; set; }

    public DiaInternacionalModel(DiaInternacional diaInternacional)
    {
        Fecha = diaInternacional.Fecha;
        Descripcion = diaInternacional.Descripcion;
    }

    public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
    {
        return diasInternacionales.Select(f => new DiaInternacionalModel(f)).ToList();
    }
}
