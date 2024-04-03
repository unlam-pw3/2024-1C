namespace TaTeTi;

public interface IConsoleOutput
{
    public void WriteLine(string message);
    public void Write(string message);
}

public class ConsoleOutput : IConsoleOutput
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
    public void Write(string message)
    {
        Console.Write(message);
    }
}
