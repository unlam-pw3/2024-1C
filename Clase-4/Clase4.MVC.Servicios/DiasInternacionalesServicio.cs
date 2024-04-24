using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4.MVC.Entidades;

namespace Clase4.MVC.Servicios
{ 
    public interface IDiasInternacionalesServicio
{
    bool EsDiaInternacional(int dia, int mes);
    List<DiasInternacionales> ObtenerDiasInternacionales();


}

    public class DiasInternacionalesServicio : IDiasInternacionalesServicio
    {

        private static List<DiasInternacionales> Lista = new();
       

        public DiasInternacionalesServicio()
        {
            if (Lista.Count == 0)
            {
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 3, 8), Nombre = "Día Internacional de la Mujer", Descripcion = "Celebración de los logros sociales, económicos, culturales y políticos de las mujeres, así como la lucha continua por la igualdad de género." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 3, 22), Nombre = "Día Mundial del Agua", Descripcion = "Destinado a concienciar sobre la importancia del agua dulce y abogar por la gestión sostenible de los recursos hídricos." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 4, 7), Nombre = "Día Mundial de la Salud", Descripcion = "Celebración anual patrocinada por la Organización Mundial de la Salud (OMS) con el objetivo de crear conciencia sobre temas relacionados con la salud." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 4, 22), Nombre = "Día de la Tierra", Descripcion = "Dedicado a promover la conciencia sobre los problemas ambientales y fomentar acciones para proteger el medio ambiente." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 5, 1), Nombre = "Día Internacional de los Trabajadores (Día del Trabajo)", Descripcion = "Celebración internacional del movimiento obrero y la lucha por los derechos laborales." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 6, 5), Nombre = "Día Mundial del Medio Ambiente", Descripcion = "Destinado a promover la conciencia sobre la necesidad de proteger el medio ambiente y tomar medidas para su conservación." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 7, 30), Nombre = "Día Internacional de la Amistad", Descripcion = "Celebración dedicada a la amistad y la importancia de cultivar relaciones de amistad entre personas, países y culturas para promover la paz mundial." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 9, 21), Nombre = "Día Internacional de la Paz", Descripcion = "Día dedicado a fortalecer los ideales de paz, tanto dentro como entre todas las naciones y pueblos." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 11, 14), Nombre = "Día Mundial de la Diabetes", Descripcion = "Destinado a crear conciencia sobre la diabetes, sus causas, síntomas, tratamientos y complicaciones." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 1, 20), Nombre = "Día Mundial de la Nieve", Descripcion = "Celebración para disfrutar de la nieve y los deportes de invierno." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 2, 9), Nombre = "Día Internacional de la Pizza", Descripcion = "Día para disfrutar de una de las comidas más populares y versátiles del mundo: ¡la pizza!" });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 6, 21), Nombre = "Día Mundial del Selfie", Descripcion = "Día para celebrar la popularidad de los autorretratos digitales." });
                Lista.Add(new DiasInternacionales { Fecha = new DateTime(2024, 8, 8), Nombre = "Día Internacional del Gato", Descripcion = "Día para celebrar a los adorables compañeros felinos." });

            }

        }

        public List<DiasInternacionales> ObtenerDiasInternacionales()
        {
            return Lista;
        }


        public bool EsDiaInternacional(int dia, int mes)
        {
            return Lista.Any(f => f.Fecha.Day == dia && f.Fecha.Month == mes);
        }

    }

    


}
