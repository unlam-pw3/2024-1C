using Clase4.MVC.Web.Models;

namespace Clase4.MVC.Web.Servicios;

public interface IFeriadosService
{
    List<Feriado> ObtenerFeriados();
}
public class FeriadosService : IFeriadosService
{
    private static List<Feriado> Lista = new();

    public FeriadosService()
    {
        if (Lista.Count == 0)
        {
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 1, 1), Descripcion = "Año Nuevo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 2, 15), Descripcion = "Carnaval", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 2, 16), Descripcion = "Carnaval", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 3, 24), Descripcion = "Día Nacional de la Memoria por la Verdad y la Justicia", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 4, 2), Descripcion = "Viernes Santo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 5, 1), Descripcion = "Día del Trabajador", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 5, 25), Descripcion = "Día de la Revolución de Mayo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 6, 20), Descripcion = "Paso a la Inmortalidad del General Manuel Belgrano", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 7, 9), Descripcion = "Día de la Independencia", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 7, 19), Descripcion = "Paso a la Inmortalidad del General José de San Martín", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 10, 11), Descripcion = "Día del Respeto a la Diversidad Cultural", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 11, 20), Descripcion = "Día de la Soberanía Nacional", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 12, 8), Descripcion = "Inmaculada Concepción de María", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 12, 25), Descripcion = "Navidad", EsInamovible = true });
        }
    }
    public List<Feriado> ObtenerFeriados()
    {
        return Lista;
    }
}


