namespace Clase1.Practica.Consola;

public interface IGeneradorNumeroRandom
{
    public int GenerarNumero(int max);
}
internal class GeneradorNumeroRandom : IGeneradorNumeroRandom
{
    public int GenerarNumero(int max)
    {
        Random random = new Random();
        return random.Next(1, max);
    }
}
