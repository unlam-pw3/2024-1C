using Modelo2doParcial.Entidades.EF;

namespace Modelo2doParcial.Logica.Servicios;

public interface ISucursalesServicio
{
    List<Sucursal> Listar();
}

public class SucursalesServicio : ISucursalesServicio
{
    private Pw320241c2doParcialContext _ctx;
    public SucursalesServicio(Pw320241c2doParcialContext context)
    {
        _ctx = context;
    }

    public List<Sucursal> Listar()
    {
        return _ctx.Sucursals
            .Where(s => !s.Eliminada)
            .OrderBy(s => s.Direccion)
            .ToList();
    }
}