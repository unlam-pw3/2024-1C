using Clase2.Entidades;
namespace Clase.Logica;

    public interface IEquipoServicio
    {
        void Agregar(Equipo equipo);
        void Modificar(string nombre, Equipo equipo);
        void Eliminar(string nombre);
        List<Equipo> ObtenerTodos();
    }

    public class EquipoServicio : IEquipoServicio
    {
        private static List<Equipo> Equipos { get; set; } = new List<Equipo>();

        public void Agregar(Equipo equipo)
        {
            Equipos.Add(equipo);
        }

        public void Modificar(string nombre, Equipo equipo)
        {
            var equipoExistente = Equipos.FindIndex(e => e.Nombre == nombre);
            if (equipoExistente != -1)
            {
                Equipos[equipoExistente] = equipo;
            }
        }

        public void Eliminar(string nombre)
        {
            var equipoExistente = Equipos.Find(e => e.Nombre == nombre);
            if (equipoExistente != null)
            {
                Equipos.Remove(equipoExistente);
            }
        }

        public List<Equipo> ObtenerTodos()
        {
            return Equipos;
        }
    }

