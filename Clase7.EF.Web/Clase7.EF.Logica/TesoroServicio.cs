using Clase7.EF.Data.EF;

namespace Clase7.EF.Logica
{
    public class TesoroServicio : ITesoroServicio
    {
        private Pw31cIslaTesoroContext _context;

        public TesoroServicio(Pw31cIslaTesoroContext context)
        {
            this._context = context;
        }

        public void Agregar(Tesoro tesoro)
        {
            this._context.Tesoros.Add(tesoro);
            this._context.SaveChanges();
        }

        public List <Tesoro> obtenerTodos()
        {
            return this._context.Tesoros.ToList();
        }

        public Tesoro obtenerPorId(int id)
        {
            return this._context.Tesoros.Find(id);
        }

        public void Actualizar(Tesoro tesoro)
        {
            this._context.Tesoros.Update(tesoro);
            this._context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var tesoro = this.obtenerPorId(id);
            if(tesoro == null) {
                return;
            }
            this._context.Tesoros.Remove(tesoro);
            this._context.SaveChanges();
        }
    }

    public interface ITesoroServicio
    {
        void Agregar(Tesoro tesoro);
        List<Tesoro> obtenerTodos();
        Tesoro obtenerPorId(int id);
        void Actualizar(Tesoro tesoro);
        void Eliminar(int id);

    }
}