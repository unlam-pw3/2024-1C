using System;
using Ta_te_ti_Game;
using Ta_te_tiGame.UnitTests;

class Program
{
    static void Main(string[] args)
    {
        var consoleInput = new ConsoleInput();
        var consoleOutput = new ConsoleOutput();

        var game = new TatetiGame(consoleInput, consoleOutput);

        game.StartGame();

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
