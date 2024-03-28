namespace Clase1.Practica.Consola;

public interface IConsolaOutput
{
    public void WriteLine(string message);
}
internal class ConsolaOutput : IConsolaOutput
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}
