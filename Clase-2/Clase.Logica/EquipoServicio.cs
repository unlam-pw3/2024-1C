using Clase2.Entidades;

namespace Clase.Logica;

public interface IEquipoServicio
{
    void Agregar(Equipo equipo);

    List<Equipo> ObtenerTodos();

    void Eliminar(int id);

}
public class EquipoServicio : IEquipoServicio
{
    private static List<Equipo> Items {  get; set; }

    public void Agregar(Equipo equipo)
    {
        Items.Add(equipo);
    }

    public List<Equipo> ObtenerTodos()
    {
        return Items;
    }

    public void Eliminar(int id)
    {
        var equipo = Items.FirstOrDefault(e => e.Id == id);
        if (equipo != null)
        {
            Items.Remove(equipo);
        }
    }

}
