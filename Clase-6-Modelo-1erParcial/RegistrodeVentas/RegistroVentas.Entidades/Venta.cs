namespace RegistroVentas.Entidades;

public class Venta
{
    public string Cliente { get; set; }
    public int CantidadVendida { get; set; }
    public decimal PrecioUnitario { get; set; }
}