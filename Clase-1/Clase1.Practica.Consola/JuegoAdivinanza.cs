namespace Clase1.Practica.Consola;
public class JuegoAdivinanza
{
    private int _numeroAdivinar;
    private int _intentos;
    private int _numeroIngresado;
    private bool _adivino;
    private int _numeroMaximo;

    private IConsolaInput _consolaInput;
    private IConsolaOutput _consolaOutput;

    public JuegoAdivinanza(IConsolaInput consolaInput, 
        IConsolaOutput consolaOutput, 
        IGeneradorNumeroRandom generadorNumeroRandom)
    {
        _consolaInput = consolaInput;
        _consolaOutput = consolaOutput;

        _consolaOutput.WriteLine("Ingrese el numero maximo para adivinar");
        _numeroMaximo = int.Parse(_consolaInput.ReadLine());
        _numeroAdivinar = generadorNumeroRandom.GenerarNumero(_numeroMaximo);
        
        _intentos = 0;
        _adivino = false;
    }

    public void Jugar()
    {
        while (!_adivino)
        {
            _consolaOutput.WriteLine("Ingrese un numero");
            _numeroIngresado = int.Parse(_consolaInput.ReadLine());
            _intentos++;
            if (_numeroIngresado == _numeroAdivinar)
            {
                _adivino = true;
            }
            else
            {
                _consolaOutput.WriteLine($"Estas {ObtenerRespuesta()}");
            }
        }

        _consolaOutput.WriteLine($"Felicitaciones! Adivinaste el numero en {_intentos} intentos");
    }

    /// <summary>
    /// Retorna una respuesta basandose en cuan cerca esta de adivinar el numero.
    /// "helado", "frio", "tibio", "caliente", "ardiente".
    /// </summary>
    /// <returns></returns>
    private string ObtenerRespuesta()
    {
        var distancia = Math.Abs(_numeroIngresado - _numeroAdivinar);
        var porcentajeCercania = distancia * 100 / _numeroMaximo;

        if (porcentajeCercania <= 10)
        {
            return "ardiente";
        }
        else if (porcentajeCercania <= 20)
        {
            return "caliente";
        }
        else if (porcentajeCercania <= 30)
        {
            return "tibio";
        }
        else if (porcentajeCercania <= 40)
        {
            return "frio";
        }
        else
        {
            return "helado";
        }
    }
}
