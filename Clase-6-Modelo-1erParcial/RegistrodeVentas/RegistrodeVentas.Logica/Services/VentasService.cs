using RegistrodeVentas.Entidades;

namespace RegistrodeVentas.Logica.Services;

public interface IVentasService
{
    void RegistrarVenta(Venta venta);
    List<Venta> ObtenerVentas();
}

public class VentasService: IVentasService
{
    private static List<Venta> _ventas = new List<Venta>();

    public void RegistrarVenta(Venta venta)
    {
        venta.TotalVenta = venta.CantidadVendida * venta.PrecioUnitario;
        venta.IdVenta = _ventas.Count == 0 
                        ? 1 : 
                        _ventas.Max(v => v.IdVenta) + 1;

        _ventas.Add(venta);
    }

    public List<Venta> ObtenerVentas()
    {
        return _ventas
            .OrderBy(v => v.IdVenta)
            .ToList();
    }

    //public List<Venta> VentasMayoristas()
    //{
    //    return _ventas
    //        .Where(v => v.CantidadVendida > 100)
    //        .OrderByDescending(v=> v.CantidadVendida)
    //        .ToList();
    //}
}

