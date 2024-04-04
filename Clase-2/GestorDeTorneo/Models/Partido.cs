namespace GestorDeTorneo.Models
{
    public class Partido
    {
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public string Estadio { get; set; }
        public int[] Goles { get; set; }
       
    }
}
