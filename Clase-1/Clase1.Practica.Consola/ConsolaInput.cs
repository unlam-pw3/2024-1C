namespace Clase1.Practica.Consola;

public interface IConsolaInput
{
    string ReadLine();
}
internal class ConsolaInput : IConsolaInput
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}