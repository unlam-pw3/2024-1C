using System.ComponentModel.DataAnnotations;
using RegistrodeVentas.Entidades;

namespace RegistrodeVentas.Web.Models;

public class VentaModel
{
    //- Cliente: Hasta 50 caracteres. Campo requerido
    // - Cantidad Vendida: Numérico, Campo Obligatorio.
    // La cantidad vendida debe ser mayor a 1 y menor a 300. -
    // Precio unitario: Numérico, campo obligatorio.
    // El precio unitario debe ser mayor o igual a 10 y menor a 1000
    
    public int IdVenta { get; set; }
    [StringLength(50), Required]
    public string Cliente { get; set; }
    [Range(2, 299), Required]
    public int CantidadVendida { get; set; }
    [Range(10, 999), Required]
    public int PrecioUnitario { get; set; }
    public int TotalVenta { get; set; }

    public VentaModel()
    {
        
    }

    public VentaModel(Venta entidad)
    {
        IdVenta = entidad.IdVenta;
        Cliente = entidad.Cliente;
        CantidadVendida = entidad.CantidadVendida;
        PrecioUnitario = entidad.PrecioUnitario;
        TotalVenta = entidad.TotalVenta;
    }

    public static List<VentaModel> MapearAListaModel(List<Venta> ventas)
    {
        return ventas.Select(v => new VentaModel(v)).ToList();
    }

    public Venta MapearAEntidad()
    {
        return new Venta
        {
            IdVenta = IdVenta,
            Cliente = Cliente,
            CantidadVendida = CantidadVendida,
            PrecioUnitario = PrecioUnitario,
            TotalVenta = TotalVenta
        };
    }
}
