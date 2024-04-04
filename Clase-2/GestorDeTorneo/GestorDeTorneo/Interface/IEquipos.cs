
using GestorDeTorneo.Models;

namespace GestorDeTorneo.Interface
{
    public interface IEquipos
    {
        public Task<string> GetEquipos();
        public Task<List<Equipo>> GetEquiposConSuCancha();
        public Task<bool> PostAgregarEquipo(Equipo equipo);

    }
}
