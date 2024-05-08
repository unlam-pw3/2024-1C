namespace RegistrodeVentas.Entidades;

public class Venta
{
    public int IdVenta { get; set; }
    public string Cliente { get; set; }
    public int CantidadVendida { get; set; }
    public int PrecioUnitario { get; set; }
    public int TotalVenta { get; set; }
}