using Clase4.MVC.Entidades;

namespace Clase4.MVC.Servicios
{
    public interface IDiaInternacionalService
    {
        List<DiaInternacional> ObtenerDiasInternacionales();
        bool VerificarDia(int dia, int mes);

        string obtenerDescripcion(int dia, int mes);
    }
    public class DiaInternacionalService : IDiaInternacionalService
    {
        private static List<DiaInternacional> diaInternacionalLista = new();


        public DiaInternacionalService()
        {
            if (diaInternacionalLista.Count == 0)
            {
                // Enero
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 1, 27), Descripcion = "Día Internacional de Conmemoración en Memoria de las Víctimas del Holocausto. Se recuerda a las víctimas del Holocausto, el genocidio perpetrado por el régimen nazi durante la Segunda Guerra Mundial." });

                // Febrero
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 2, 14), Descripcion = "Día de San Valentín. Celebrado como el día del amor y la amistad en muchos países, es una ocasión para expresar afecto hacia las personas queridas." });

                // Marzo
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 3, 8), Descripcion = "Día Internacional de la Mujer. Se conmemora la lucha de las mujeres por la igualdad de género y los derechos humanos." });

                // Abril
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 4, 22), Descripcion = "Día Internacional de la Madre Tierra. Se celebra para concienciar sobre la importancia de proteger nuestro planeta y promover la sostenibilidad ambiental." });

                // Mayo
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 5, 1), Descripcion = "Día Internacional del Trabajador. Se conmemora la lucha por los derechos laborales y se reconoce la contribución de los trabajadores al desarrollo de la sociedad." });

                // Junio
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 6, 5), Descripcion = "Día Mundial del Medio Ambiente. Se celebra para promover la conciencia y la acción global en la protección del medio ambiente y la biodiversidad." });

                // Julio
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 7, 18), Descripcion = "Día Internacional de Nelson Mandela. Se conmemora el legado del líder sudafricano Nelson Mandela y su lucha por la justicia, la paz y la reconciliación." });

                // Agosto
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 8, 9), Descripcion = "Día Internacional de los Pueblos Indígenas. Se reconoce la diversidad cultural y los derechos de los pueblos indígenas en todo el mundo." });

                // Septiembre
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 9, 21), Descripcion = "Día Internacional de la Paz. Se celebra para promover la paz en todo el mundo y resolver los conflictos mediante el diálogo y la cooperación." });

                // Octubre
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 10, 16), Descripcion = "Día Mundial de la Alimentación. Se destaca la importancia de la seguridad alimentaria y la nutrición para erradicar el hambre en el mundo." });

                // Noviembre
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 11, 20), Descripcion = "Día Universal del Niño. Se conmemora la Declaración de los Derechos del Niño y se promueve el bienestar y los derechos de los niños en todo el mundo." });

                // Diciembre
                diaInternacionalLista.Add(new DiaInternacional { Fecha = new DateTime(2024, 12, 10), Descripcion = "Día de los Derechos Humanos. Se celebra la adopción de la Declaración Universal de Derechos Humanos y se promueve la igualdad, la justicia y la dignidad para todas las personas." });

            }
        }


        public bool VerificarDia(int dia, int mes)
        {
            return diaInternacionalLista.Any(f => f.Fecha.Day == dia && f.Fecha.Month == mes);
        }

        public string obtenerDescripcion(int dia, int mes)
        {
            DiaInternacional diaInternacional = diaInternacionalLista.FirstOrDefault(f => f.Fecha.Day == dia && f.Fecha.Month == mes);
            if (diaInternacional != null)
            {
                return diaInternacional.Descripcion;
            }
            else
            {
                return "No hay descripción disponible para este día internacional.";
            }
        }

        public List<DiaInternacional> ObtenerDiasInternacionales()
        {
            return diaInternacionalLista;
        }
    }
}
