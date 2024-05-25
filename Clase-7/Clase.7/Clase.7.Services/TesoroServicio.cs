using Clase._7.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase._7.Services;
public interface ITesoroServicio
{
    void Agregar(Tesoro tesoro);
    void Actualizar(Tesoro tesoro);
    void Eliminar(int id);
    List<Tesoro> ObtenerTodos();
}
public class TesoroServicio : ITesoroServicio
{
    private readonly TesoroContext _context;

    public TesoroServicio(TesoroContext context)
    {
        this._context = context;
    }

    public void Agregar(Tesoro tesoro)
    {
        _context.Tesoros.Add(tesoro);
        _context.SaveChanges();
    }

    public void Actualizar(Tesoro tesoro)
    {
        _context.Tesoros.Update(tesoro);
        _context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var tesoro = ObtenerPorId(id);

        if (tesoro == null)
            return;

        _context.Tesoros.Remove(tesoro);
        _context.SaveChanges();
    }

    public List<Tesoro> ObtenerTodos()
    {
        return _context.Tesoros.ToList();
    }

    private Tesoro ObtenerPorId(int id)
    {
        return _context.Tesoros.Find(id);
    }

}

