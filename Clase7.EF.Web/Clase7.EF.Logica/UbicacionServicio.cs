using Clase7.EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase7.EF.Logica
{
    public class UbicacionServicio : IUbicacionServicio
    {
        private Pw31cIslaTesoroContext _context;

        public UbicacionServicio (Pw31cIslaTesoroContext context)
        {
            _context = context;
        }

        public void Actualizar(Ubicacion ubicacion)
        {
            _context.Ubicacions.Update(ubicacion);
            _context.SaveChanges();
        }

        public void Agregar(Ubicacion ubicacion)
        {
            _context.Ubicacions.Add(ubicacion);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var ubicacion = this.obtenerPorId(id);
            if (ubicacion == null)
            {
                return;
            }
            _context.Ubicacions.Remove(ubicacion);
            _context.SaveChanges();
        }

        public Ubicacion obtenerPorId(int id)
        {
            return _context.Ubicacions.Find(id);
        }

        public List<Ubicacion> obtenerTodos()
        {
            return _context.Ubicacions.ToList();
        }
    }

    public interface IUbicacionServicio
    {
        void Agregar(Ubicacion ubicacion);
        List<Ubicacion> obtenerTodos();
        Ubicacion obtenerPorId(int id);
        void Actualizar(Ubicacion ubicacion);
        void Eliminar(int id);
    }
}
