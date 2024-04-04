using Clase2.Entidades;

namespace Clase.Logica;
public interface IResultadoServicio
{
    void Agregar(Resultado resultado);
    List<Resultado> ObtenerTodos();
}
public class ResultadoServicio : IResultadoServicio
{
    private static List<Resultado> Items { get; set; } = new List<Resultado>();

    public void Agregar(Resultado resultado)
    {
        Items.Add(resultado);
    }

    public List<Resultado> ObtenerTodos()
    {
        return Items;
    }
}

