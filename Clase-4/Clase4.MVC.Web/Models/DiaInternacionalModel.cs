using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models
{
    public class DiaInternacionalModel
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

        public DiaInternacionalModel(DiaInternacional dia)
        {
            Fecha = dia.Fecha;
            Descripcion = dia.Descripcion;
        }

        public static List<DiaInternacionalModel> MapToModel(List<DiaInternacional> diasInternacionales)
        {
            return diasInternacionales.Select(f => new DiaInternacionalModel(f)).ToList();
        }
  
    }
}
