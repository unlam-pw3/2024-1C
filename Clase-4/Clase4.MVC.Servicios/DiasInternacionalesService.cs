using Clase4.MVC.Entidades;

namespace Clase4.MVC.Servicios;

public interface IDiasInternacionalesService
{
    List<DiaInternacional> ObtenerDiasInternacionales();
    DiaInternacional ObtenerDiaInternacional(int dia, int mes);
    void CrearDiaInternacional(DateTime fecha, string nombre, string descripcion);
}
public class DiasInternacionalesService : IDiasInternacionalesService
{
    private static List<DiaInternacional> Lista = new();

    public DiasInternacionalesService()
    {
        if (Lista.Count == 0)
        {
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 1, 4), NombreDia = "Día del Braille", Descripcion = "Es una jornada conmemorativa que se celebra anualmente el 4 de enero desde 2019, establecida por la Asamblea General de las Naciones Unidas en 2018." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 3, 8), NombreDia = "Día de La Mujer", Descripcion = "Conmemora cada 8 de marzo la lucha de las mujeres por su participación en la sociedad y su desarrollo íntegro como persona, en pie de igualdad con el hombre." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 3, 22), NombreDia = "Día del Agua", Descripcion = " La Organización de las Naciones Unidas (ONU) instauró la celebración anual del Día Mundial del Agua en 1992, como un medio para concientizar acerca del cuidado de los recursos hídricos a nivel mundial." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 5, 1), NombreDia = "Día de Los trabajadores", Descripcion = "Es la conmemoración del movimiento obrero mundial." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 6, 29), NombreDia = "Día de La Esclerodermia", Descripcion = "Un día para reivindicar las necesidades del colectivo de personas afectadas." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 7, 20), NombreDia = "Día del Ajedrez", Descripcion = "El día internacional del ajedrez se celebra anualmente el 20 de julio, conmemorando el día en que se fundó la Federación Internacional de Ajedrez en París en 1924." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 7, 30), NombreDia = "Día de La Amistad", Descripcion = "Es un día festivo dedicado a la celebración de la amistad." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 9, 12), NombreDia = "Día de Los Programadores", Descripcion = "El Día de los Programadores se celebra en la jornada número 256 del calendario anual. Por eso, en la mayoría de los años el festejo es el 13 de septiembre, pero en años bisiestos cae el 12 de ese mes." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 10, 10), NombreDia = "Día de La Salud Mental", Descripcion = "El Día Mundial de la Salud Mental tiene como propósito crear un mayor conocimiento sobre la salud mental que concierne a todos y cada uno, y al mismo tiempo combatir el estigma y los falsos conceptos que rodean la salud mental." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 11, 19), NombreDia = "Día del Hombre", Descripcion = "Comenzó a conmemorarse internacionalmentenota 1con el objetivo de abordar temas como la salud masculina, resaltar el papel positivo y las contribuciones que realizan los hombres en su comunidad y en la sociedad, promover la igualdad de género, la paz, la no violencia, la equidad, la tolerancia y el entendimiento." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 11, 29), NombreDia = "Día del Jaguar", Descripcion = "Con el objetivo de celebrar al jaguar (Panthera onca) como un ícono del desarrollo sostenible, incrementar la concientización sobre su estado actual, apoyar públicamente la conservación de esta especie y consolidar los esfuerzos de los socios y de los países donde se distribuye el jaguar." });
            Lista.Add(new DiaInternacional { Fecha = new DateTime(2024, 12, 3), NombreDia = "Día de Las Personas con Discapacidad", Descripcion = "El objetivo es promover los derechos y el bienestar de las personas con discapacidades en todos los ámbitos de la sociedad y el desarrollo, así como concienciar sobre su situación en todos los aspectos de la vida política, social, económica y cultural." });
        }
    }
    public List<DiaInternacional> ObtenerDiasInternacionales()
    {
        return Lista.OrderBy(d => d.Fecha).ToList();
    }

    public DiaInternacional ObtenerDiaInternacional(int dia, int mes)
    {
        var diaInternacional = Lista.FirstOrDefault(d => d.Fecha.Day == dia && d.Fecha.Month == mes);

        return diaInternacional;
    }

    public void CrearDiaInternacional(DateTime fecha, string nombre, string descripcion)
    {
        Lista.Add(new DiaInternacional { Fecha = fecha, NombreDia = nombre, Descripcion = descripcion });
    }

}
