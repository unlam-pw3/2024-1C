using Modelo2doParcial.Entidades.EF;

namespace Modelo2doParcial.Logica.Servicios;

public interface IEmpleadosServicio
{
    void CrearEmpleado(Empleado empleado);
    List<Empleado> Listar();
    List<Empleado> ListarPorSucursal(int idSucursal);
}

public class EmpleadosServicio : IEmpleadosServicio
{
    private Pw320241c2doParcialContext _ctx;
    public EmpleadosServicio(Pw320241c2doParcialContext context)
    {
        _ctx = context;
    }

    public void CrearEmpleado(Empleado empleado)
    {
        _ctx.Empleados.Add(empleado);
        _ctx.SaveChanges();
    }

    public List<Empleado> Listar()
    {
        return _ctx.Empleados
            .Where(e=> !e.IdSucursalNavigation.Eliminada)
            .ToList();
    }

    public List<Empleado> ListarPorSucursal(int idSucursal)
    {
        return _ctx.Empleados
            .Where(e => e.IdSucursal == idSucursal && 
                !e.IdSucursalNavigation.Eliminada)
            .ToList();
    }
}


