using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models
{
    public class DiasInternacionalesModel
    {
        public DateTime Fecha { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    

    public DiasInternacionalesModel(DiasInternacionales diasInternacionales)
    {
        Fecha = diasInternacionales.Fecha;
        Nombre = diasInternacionales.Nombre;
        Descripcion = diasInternacionales.Descripcion;

    }
     
    public static List<DiasInternacionalesModel> MapModel(List<DiasInternacionales> diasInternacionales)
        {
            return diasInternacionales.Select(f => new DiasInternacionalesModel(f)).ToList();
        }

    }
}
