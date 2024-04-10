using Clase2.Entidades;
using System.Linq;

namespace Clase.Logica
{
    public interface IEquiposServicio
    {
        void Agregar(Equipo equipo);
        List<Equipo> ObtenerEquipos();
        void Eliminar(Equipo equipo);
        Equipo ObtenerEquipoPorNombre(string nombre_equipo);
    }
    public class EquipoServicio : IEquiposServicio
    {

        private static List <Equipo> Lista { get; set; } = new List <Equipo> ();

        public void Agregar(Equipo equipo)
        {
            Lista.Add (equipo);
        }

        public void Eliminar(Equipo equipo)
        {
            Lista.Remove (equipo);
        }

        public Equipo ObtenerEquipoPorNombre(string nombre_equipo)
        {
            foreach (var equipo in Lista)
            {
                if (equipo.nombre_equipo.Equals(nombre_equipo, StringComparison.OrdinalIgnoreCase))
                {
                    return equipo;
                }
            }

            return null; // Si no se encuentra el equipo, devuelve null
        }

        public List<Equipo> ObtenerEquipos()
        {
            return Lista;
        }
    }
}
