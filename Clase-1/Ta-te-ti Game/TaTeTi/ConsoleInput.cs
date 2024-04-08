namespace TaTeTi;

public interface IConsoleInput 
{
    public String ReadLine();
}

public class ConsoleInput : IConsoleInput
{
    public string ReadLine() => Console.ReadLine();
}
