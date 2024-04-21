using System.Collections.Generic;
using System.Linq;
using Clase4.MVC.Entidades;

namespace Clase4.MVC.Web.Models
{
    public class FeriadoModel
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public bool EsInamovible { get; set; }

        public FeriadoModel(Feriado feriado)
        {
            Fecha = feriado.Fecha;
            Descripcion = feriado.Descripcion;
            EsInamovible = feriado.EsInamovible;
        }

        public static List<FeriadoModel> MapToModel(List<Feriado> feriados)
        {
            return feriados.Select(f => new FeriadoModel(f)).ToList();
        }
    }
}
