using Clase4.MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase4.MVC.Servicios
{
    public interface IDiaInternacionalService
    {
        List<DiaInternacional> ObtenerDiasInternacionales();
        List<DiaInternacional> FiltrarPorCategoria(string categoria);

    }

    public class DiasInternacionalesService : IDiaInternacionalService
    {
        private static List<DiaInternacional> Lista = new();

        public DiasInternacionalesService()
        {
            if (Lista.Count == 0)
            {
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 2, 14), Titulo = "Día del Amor y la Amistad", Descripcion = "Día en honor a San Valentín, reconocido por el amor que entrega", Categoria = "Social" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 3, 8), Titulo = "Día Internacional de la Mujer", Descripcion = "Día en honor a la lucha de las mujeres por la igualdad de género", Categoria = "Social" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 4, 22), Titulo = "Día Internacional de la Tierra", Descripcion = "Día en honor a la conciencia sobre los problemas de la contaminación, conservación de la biodiversidad y otras preocupaciones ambientales", Categoria = "Ambiental" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 6, 5), Titulo = "Día Mundial del Medio Ambiente", Descripcion = "Día dedicado a la conciencia sobre los temas ambientales y la protección del medio ambiente", Categoria = "Ambiental" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 10, 16), Titulo = "Día Mundial de la Alimentación", Descripcion = "Día dedicado a concienciar sobre la importancia de la alimentación y la lucha contra el hambre en el mundo", Categoria = "Alimentación" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 11, 20), Titulo = "Día Internacional de los Derechos de la Infancia", Descripcion = "Día en honor a la promoción y protección de los derechos de los niños en todo el mundo", Categoria = "Social" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 6, 15), Titulo = "Día del Libro", Descripcion = "Día para promover la lectura, la industria editorial y los derechos de autor", Categoria = "Cultural" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 11, 15), Titulo = "Día del Chocolate", Descripcion = "Día para celebrar el chocolate en todas sus formas y sabores", Categoria = "Gastronomía" });
                Lista.Add(new DiaInternacional { Fecha = new DateTime(2021, 9, 12), Titulo = "Día del Programador", Descripcion = "Día en honor a los programadores y desarrolladores de software", Categoria = "Tecnología" });
            }
        }

        public List<DiaInternacional> ObtenerDiasInternacionales()
        {
            return Lista;
        }

        public List<DiaInternacional> FiltrarPorCategoria(string categoria)
        {
            return Lista.Where(d => d.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
        }

    }
}
