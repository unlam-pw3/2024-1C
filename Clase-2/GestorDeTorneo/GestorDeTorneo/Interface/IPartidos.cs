using GestorDeTorneo.Models;

namespace GestorDeTorneo.Interface
{
    public interface IPartidos
    {
        public Task<List<Partido>> GetPartidos();
        public Task<bool> PostAgregarPartido(Partido Partido);
    }
}