using Clase2.Entidades;

namespace Clase.Logica;

public interface IEquiposServicio
{
    void Actualizar(Equipo equipo);
    Equipo Agregar(Equipo equipo);
    List<Equipo> ObtenerEquipos();
    void Eliminar(Equipo equipo);
    Equipo ObtenerEquipoPorNombre(string nombre_equipo);
    Equipo ObtenerEquipoPorId(int id);
}
public class EquipoServicio : IEquiposServicio
{

    private static List <Equipo> Lista { get; set; } = new List <Equipo> ();

    public Equipo Agregar(Equipo equipo)
    {
        equipo.Id = Lista.Count == 0 ? 1 : Lista.Max(i => i.Id) + 1;
        Lista.Add (equipo);

        return equipo;
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

    public Equipo ObtenerEquipoPorId(int id)
    {
        return Lista.FirstOrDefault(x => x.Id == id);
    }

    public List<Equipo> ObtenerEquipos()
    {
        return Lista;
    }

    public void Actualizar(Equipo equipo)
    {
        var item = Lista.FirstOrDefault(x => x.Id == equipo.Id);
        if (item != null)
        {
            item.nombre_equipo = equipo.nombre_equipo;
            item.pais = equipo.pais;
        }
    }

}
