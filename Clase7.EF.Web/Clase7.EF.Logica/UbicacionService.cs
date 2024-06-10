
using Clase7.EF.Data.EF;

namespace Clase7.EF.Logica
{
    public interface IUbicacionService
    {
        void Agregar(Ubicacion ubicacion);
        List<Ubicacion> ObtenerTodos();
        void Eliminar(int id);
        void Actualizar(Ubicacion ubicacion);
        Ubicacion ObtenerPorId(int id);
    }
    public class UbicacionService : IUbicacionService
    {
        private Pw31cIslaTesoroContext _context;

        public UbicacionService(Pw31cIslaTesoroContext context)
        {
            _context = context;
        }
        public void Actualizar(Ubicacion ubicacion)
        {
            this._context.Ubicacions.Update(ubicacion);
            this._context.SaveChanges();
        }

        public void Agregar(Ubicacion ubicacion)
        {
            this._context.Ubicacions.Add(ubicacion);
            this._context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var ubicacion = this._context.Ubicacions.Find(id);
            if (ubicacion == null)
                return;
            this._context.Ubicacions.Remove(ubicacion);
            this._context.SaveChanges();
        }

        public Ubicacion ObtenerPorId(int id)
        {
            return this._context.Ubicacions.Find(id);
        }

        public List<Ubicacion> ObtenerTodos()
        {
            return this._context.Ubicacions.ToList();
        }
    }
}
