using System;
using Clase4.MVC.Entidades;
namespace Clase4.MVC.Web.Models
{
   

    public class DiaInternacionalModel
    {
        public DateTime Fecha { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

        public DiaInternacionalModel(DiaInternacional diaInternacional)
        {
            Fecha = diaInternacional.Fecha;
            Descripcion = diaInternacional.Descripcion;
            Categoria = diaInternacional.Categoria;
            Titulo = diaInternacional.Titulo; 
        }

        public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
        {
            return diasInternacionales.Select(d => new DiaInternacionalModel(d)).ToList();
        }
    }
}

