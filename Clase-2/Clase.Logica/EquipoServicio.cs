using Clase2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Logica
{

    public interface IEquipoServicio
    {
        public void Agregar(Equipo equipo);
        public void Eliminar(string nombreEquipo);
        List<Equipo> ObtenerTodos();

        public Equipo obtenerEquipoPorNombre(string nombreEquipo);
    }

    public class EquipoServicio : IEquipoServicio
    {
        private static List<Equipo> Equipos { get; set; } = new List<Equipo>();

        public void Agregar(Equipo equipo)
        {
            Equipos.Add(equipo);
        }

        public List<Equipo> ObtenerTodos()
        {
            return Equipos;
        }

        public void Eliminar(string nombreEquipo)
        {
            var equipo = obtenerEquipoPorNombre(nombreEquipo);
            if (equipo != null)
            {
                Equipos.Remove(equipo);
            }
        }

        public Equipo obtenerEquipoPorNombre(string nombreEquipo)
        {
            return Equipos.FirstOrDefault(e => e.Nombre == nombreEquipo);
        }
    }
}
