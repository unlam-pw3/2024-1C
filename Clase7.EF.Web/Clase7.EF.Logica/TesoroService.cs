using Clase7.EF.Data.EF;

namespace Clase7.EF.Logica
{   
    public interface ITesoroService
    {
        void Agregar(Tesoro tesoro);
        List<Tesoro> ObtenerTodos();
        void Eliminar(int id);
        void Actualizar(Tesoro tesoro);

        Tesoro ObtenerPorId(int id);

    }

    public class TesoroService : ITesoroService
    {
        private Pw31cIslaTesoroContext _context;

        public TesoroService(Pw31cIslaTesoroContext context)
        {
            this._context = context;
        }

        public void Agregar(Tesoro tesoro)
        { 
            this._context.Tesoros.Add(tesoro);
            this._context.SaveChanges();
        }

        public List<Tesoro> ObtenerTodos()
        { 
            return this._context.Tesoros.ToList();
        }

        public Tesoro ObtenerPorId(int id)
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
            var tesoro = this._context.Tesoros.Find(id);
            if (tesoro == null)
                return;   
            
            this._context.Tesoros.Remove(tesoro);
            this._context.SaveChanges();
        }
    }
}
