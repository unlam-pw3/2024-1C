using Clase2.Entidades;

namespace Clase.Logica;
public interface IResultadoServicio
{
    void Agregar(Resultado resultado);
    void Actualizar(Resultado resultado);
    void Eliminar(int id);
    Resultado ObtenerPorId(int id);
    List<Resultado> ObtenerTodos();
}
public class ResultadoServicio : IResultadoServicio
{
    private static List<Resultado> Items { get; set; } = new List<Resultado>();

    public void Agregar(Resultado resultado)
    {
        resultado.Id = Items.Count == 0 ? 1 : Items.Max(i => i.Id) + 1;
        Items.Add(resultado);
    }

    public List<Resultado> ObtenerTodos()
    {
        return Items;
    }
    public Resultado ObtenerPorId(int id)
    {
        return Items.FirstOrDefault(x => x.Id == id);
    }

    public void Eliminar(int id)
    {
        var item = Items.FirstOrDefault(x => x.Id == id);
        if (item != null)
        {
            Items.Remove(item);
        }
    }
    public void Actualizar(Resultado resultado)
    {
        var item = Items.FirstOrDefault(x => x.Id == resultado.Id);
        if (item != null)
        {
            item.EquipoLocal = resultado.EquipoLocal;
            item.EquipoVisitante = resultado.EquipoVisitante;
            item.GolesLocal = resultado.GolesLocal;
            item.GolesVisitante = resultado.GolesVisitante;
        }
    }
}

