using Clase._7.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._7.Services;

public interface IServicioUbicacion
{
    void Agregar(Ubicacion ubicacion);
    void Actualizar(Ubicacion ubicacion);
    void Eliminar(int id);
    List<Ubicacion> ObtenerTodos();
    Ubicacion ObtenerPorId(int id);
}

public class UbicacionServicio: IServicioUbicacion
{
    private readonly TesoroContext _contexto;

    public UbicacionServicio(TesoroContext contexto)
    {
        _contexto = contexto;
    }

    public void Agregar(Ubicacion ubicacion)
    {
        _contexto.Ubicacions.Add(ubicacion);
        _contexto.SaveChanges();
    }

    public void Actualizar(Ubicacion ubicacion)
    {
        _contexto.Ubicacions.Update(ubicacion);
        _contexto.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var ubicacion = ObtenerPorId(id);

        if (ubicacion == null)
            return;

        _contexto.Ubicacions.Remove(ubicacion);
        _contexto.SaveChanges();
    }

    public Ubicacion ObtenerPorId(int id)
    {
        return _contexto.Ubicacions.Find(id);
    }

    public List<Ubicacion> ObtenerTodos()
    {
        return _contexto.Ubicacions.ToList();
    }
}

