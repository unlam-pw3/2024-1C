using GestorDeTorneo.Interface;
using GestorDeTorneo.Models;
using GestorDeTorneo.Repository;
using System.Text.Json;
namespace GestorDeTorneo.Service
{
    public class EquiposService : IEquipos
    {
        private readonly EquiposRepository _repo;
        public EquiposService(EquiposRepository repo)
        {
            _repo = repo;
        }

        public async Task<string> GetEquipos()
        {
            List<Equipo> jsonEquipos = await _repo.GetEquipos();
            if (jsonEquipos != null)
            {
                List<string> nombresEquipos = new List<string>();
                foreach (var equipo in jsonEquipos)
                {
                    nombresEquipos.Add(equipo.nombre);
                }
                string jsonNombresEquipos = JsonSerializer.Serialize(nombresEquipos);
                return jsonNombresEquipos;
            }
            throw new Exception("No se encontraron equipos");            
        }

        public async Task<List<Equipo>> GetEquiposConSuCancha()
        {
            List<Equipo> jsonEquiposConSuCancha = await _repo.GetEquipos();
            if (jsonEquiposConSuCancha != null)
            {
                return jsonEquiposConSuCancha;
            }
            throw new Exception("No se encontraron equipos");
        }

        public async Task<bool> PostAgregarEquipo(Equipo equipo)
        {
            List<Equipo> jsonEquiposConSuCancha = await _repo.GetEquipos() ?? new List<Equipo>();

            jsonEquiposConSuCancha.Add(equipo);

            string jsonEquiposConSuCanchaString = JsonSerializer.Serialize(jsonEquiposConSuCancha);
            var response = await _repo.PostAgregarEquipo(jsonEquiposConSuCanchaString);
            return response;

        }

    }

}
