using Clase1.Practica.Consola;
using Moq;

namespace Clase1.Practica.UnitTesting;

public class JuegoAdivinanzaTest
{
    [Theory]
    [InlineData(100, 95)]
    [InlineData(102, 95)]
    public void IngresaMaximo_AdivinaEnCincoIntentos(int numeroMaximo, int numeroElegido)
    {
        // Arrange
        var consolaInput = new Mock<IConsolaInput>();
        var consolaOutput = new Mock<IConsolaOutput>();
        var generadorNumeroRandomMock = new Mock<IGeneradorNumeroRandom>();

        consolaInput.SetupSequence(x => x.ReadLine())
            .Returns(numeroMaximo.ToString())
            .Returns("50")
            .Returns("70")
            .Returns("80")
            .Returns("90")
            .Returns(numeroElegido.ToString());


        //si el numero ingresado es 100, generadorNumeroRandomMock retorna 95
        generadorNumeroRandomMock.Setup(x => x.GenerarNumero(numeroMaximo)).Returns(numeroElegido);

        var generadorNumeroMaximoMock = new Mock<IGeneradorNumeroRandom>();
        var juegoAdivinanza = new JuegoAdivinanza(consolaInput.Object, 
            consolaOutput.Object, 
            generadorNumeroRandomMock.Object);

        // Act
        juegoAdivinanza.Jugar();

        // Assert
        consolaOutput.Verify(x => x.WriteLine("Ingrese el numero maximo para adivinar"), Times.Once);
        consolaOutput.Verify(x => x.WriteLine("Ingrese un numero"), Times.Exactly(5));
        consolaOutput.Verify(x => x.WriteLine("Estas helado"), Times.Exactly(1));
        consolaOutput.Verify(x => x.WriteLine("Estas tibio"), Times.Exactly(1));
        consolaOutput.Verify(x => x.WriteLine("Estas caliente"), Times.Exactly(1));
        consolaOutput.Verify(x => x.WriteLine("Estas ardiente"), Times.Exactly(1));
        consolaOutput.Verify(x => x.WriteLine("Felicitaciones! Adivinaste el numero en 5 intentos"), Times.Once);
    }
}