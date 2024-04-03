using Moq;
using TaTeTi;

namespace TaTeTi.Tests;

public class TaTeTiTest
{
    [Fact]
    public void QueSePuedaCrearUnTableroDe3Por3()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();

        // Act
        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        // Assert
        var board = tateti.GetBoard();
        Assert.Equal(9, board.Length);
    }

    [Fact]
    public void QueSePuedaMarcarUnaPosicion()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();
        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        // Act
        tateti.MakeMove(1);

        // Assert
        var board = tateti.GetBoard();
        Assert.Equal('X', board[0]);
    }

    [Fact]
    public void QueNoSePuedaMarcarUnaPosicionYaMarcada()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();
        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        // Act
        tateti.MakeMove(1);
        tateti.MakeMove(1);

        // Assert
        var board = tateti.GetBoard();
        Assert.Equal('X', board[0]);
    }

    [Fact]
    public void QueElJuegoManejeEntradasInvalidas()
    {
        // Arrange
        var consoleInputMock = new Mock<IConsoleInput>();
        var consoleOutputMock = new Mock<IConsoleOutput>();

        var tateti = new TatetiGame(consoleInputMock.Object, consoleOutputMock.Object);

        // Act & Assert
        Assert.False(tateti.IsValidMove(-1));
        Assert.False(tateti.IsValidMove(0));
        Assert.False(tateti.IsValidMove(10));
    }

    [Fact]
    public void QueUnJugadorGaneElJuegoPorFila()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();

        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        inputMock.SetupSequence(m => m.ReadLine())
                 .Returns("1")
                 .Returns("4")
                 .Returns("2")
                 .Returns("5")
                 .Returns("3");

        // Act
        tateti.StartGame();

        // Assert
        outputMock.Verify(m => m.WriteLine("¡El jugador 1 ha ganado!"), Times.Once());
    }

    [Fact]
    public void QueUnJugadorGaneElJuegoPorColumna()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();

        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        inputMock.SetupSequence(m => m.ReadLine())
                 .Returns("1")
                 .Returns("2")
                 .Returns("3") 
                 .Returns("5")
                 .Returns("7")
                 .Returns("8");

        // Act
        tateti.StartGame();

        // Assert
        outputMock.Verify(m => m.WriteLine("¡El jugador 2 ha ganado!"), Times.Once());
    }

    [Fact]
    public void QueUnJugadorGaneElJuegoPorDiagonal()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();

        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        inputMock.SetupSequence(m => m.ReadLine())
                 .Returns("1")
                 .Returns("2")
                 .Returns("9")
                 .Returns("6")
                 .Returns("5");

        // Act
        tateti.StartGame();

        // Assert
        outputMock.Verify(m => m.WriteLine("¡El jugador 1 ha ganado!"), Times.Once());
    }

    [Fact]
    public void QueElJuegoTermineEnEmpate()
    {
        // Arrange
        var inputMock = new Mock<IConsoleInput>();
        var outputMock = new Mock<IConsoleOutput>();

        var tateti = new TatetiGame(inputMock.Object, outputMock.Object);

        inputMock.SetupSequence(m => m.ReadLine())
                 .Returns("1")
                 .Returns("2")
                 .Returns("3")
                 .Returns("5")
                 .Returns("8")
                 .Returns("6")
                 .Returns("4")
                 .Returns("7")
                 .Returns("9");

        // Act
        tateti.StartGame();

        // Assert
        outputMock.Verify(m => m.WriteLine("¡Empate!"), Times.Once());
    }

}