using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models;

public class DiaInternacionalModel : DiaEspecialModel
{

    public DiaInternacionalModel()
    {

    }

    public DiaInternacionalModel(DiaInternacional diaInternacional)
    {
        if (diaInternacional != null)
        {
            Fecha = diaInternacional.Fecha;
            Nombre = diaInternacional.NombreDia;
            Descripcion = diaInternacional.Descripcion;
        }
        else
        {
            Fecha = DateTime.MinValue;
            Nombre = null;
            Descripcion = null;
        }
    }

    public DiaInternacionalModel()
    {

    }

    public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
    {
        return diasInternacionales.Select(d => new DiaInternacionalModel(d)).ToList();
    }
}