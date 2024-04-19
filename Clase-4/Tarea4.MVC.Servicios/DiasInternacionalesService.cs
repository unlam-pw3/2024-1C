using Tarea4.MVC.Entidades;

namespace Tarea4.MVC.Servicios;


public interface IDiasInternacionalesService
{
    List<DiaInternacional> ObtenerDiasInternacionales();
    string QueDiaEs(int dia, int mes);
}

public class DiasInternacionalesService : IDiasInternacionalesService
{
    private static List<DiaInternacional> Lista = new();

    public DiasInternacionalesService()
    {
        if (Lista.Count == 0)
        {
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 1, 24), Descripcion = "Día Internacional de la Educación" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 2, 2), Descripcion = "Día de la Marmota" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 2, 4), Descripcion = "Día Mundial contra el Cáncer" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 3, 8), Descripcion = "Día Internacional de la Mujer" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 3, 20), Descripcion = "Día Internacional de la Felicidad" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 4, 7), Descripcion = "Día Mundial de la Salud" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 4, 22), Descripcion = "Día Internacional de la Madre Tierra" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 5, 3), Descripcion = "Día Mundial de la Libertad de Prensa" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 5, 15), Descripcion = "Día Internacional de las Familias" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 6, 5), Descripcion = "Día Mundial del Medio Ambiente" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 6, 20), Descripcion = "Día Mundial del Refugiado" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 7, 11), Descripcion = "Día Mundial de la Población" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 8, 9), Descripcion = "Día Internacional de los Pueblos Indígenas" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 9, 8), Descripcion = "Día Internacional de la Alfabetización" });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 10, 10), Descripcion = "Día Mundial de la Salud Mental" });
        }
    }

    List<DiaInternacional> IDiasInternacionalesService.ObtenerDiasInternacionales()
    {
        return Lista;
    }

    public string QueDiaEs(int dia, int mes)
    {
        var diaInternacional = Lista.FirstOrDefault(d => d.Fecha.Day == dia && d.Fecha.Month == mes);
        return diaInternacional != null ? diaInternacional.Descripcion : "No es un dia Internacional";
    }
}

