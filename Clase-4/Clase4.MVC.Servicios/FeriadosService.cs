using Clase4.MVC.Entidades;

namespace Clase4.MVC.Servicios;

public interface IFeriadosService
{
    List<Feriado> ObtenerFeriados();
    bool EsFeriado(int dia, int mes);
    void CrearFeriado(DateTime feriadoModelFecha, string feriadoModelNombre, bool feriadoModelEsInamovible);
}
public class FeriadosService : IFeriadosService
{
    private static List<Feriado> Lista = new();

    public FeriadosService()
    {
        if (Lista.Count == 0)
        {
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 1, 1), Nombre = "Año Nuevo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 2, 15), Nombre = "Carnaval", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 2, 16), Nombre = "Carnaval", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 3, 24), Nombre = "Día Nacional de la Memoria por la Verdad y la Justicia", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 4, 2), Nombre = "Viernes Santo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 5, 1), Nombre = "Día del Trabajador", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 5, 25), Nombre = "Día de la Revolución de Mayo", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 6, 20), Nombre = "Paso a la Inmortalidad del General Manuel Belgrano", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 7, 9), Nombre = "Día de la Independencia", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 7, 19), Nombre = "Paso a la Inmortalidad del General José de San Martín", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 10, 11), Nombre = "Día del Respeto a la Diversidad Cultural", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 11, 20), Nombre = "Día de la Soberanía Nacional", EsInamovible = false });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 12, 8), Nombre = "Inmaculada Concepción de María", EsInamovible = true });
            Lista.Add(new Feriado { Fecha = new DateTime(2021, 12, 25), Nombre = "Navidad", EsInamovible = true });
        }
    }
    public List<Feriado> ObtenerFeriados()
    {
        return Lista;
    }

    public bool EsFeriado(int dia, int mes)
    {
        return Lista.Any(f => f.Fecha.Day == dia && f.Fecha.Month == mes);
    }

    public void CrearFeriado(DateTime feriadoModelFecha, string feriadoModelNombre, bool feriadoModelEsInamovible)
    {
        Lista.Add(new Feriado { Fecha = feriadoModelFecha, Nombre = feriadoModelNombre, EsInamovible = feriadoModelEsInamovible });
    }
}
