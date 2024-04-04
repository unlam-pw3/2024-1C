using GestorDeTorneo.Interface;
using GestorDeTorneo.Models;
using GestorDeTorneo.Repository;
using System.Text.Json;
namespace GestorDeTorneo.Service
{
    public class PartidosService : IPartidos
    {
        private readonly PartidosRepository _repo;
        public PartidosService(PartidosRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Partido>> GetPartidos()
        {
            try { 
                List<Partido> jsonPartidos = await _repo.GetPartidos();
                return jsonPartidos;
                
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontraron partidos");
            }
        }

        public async Task<bool> PostAgregarPartido(Partido partido)
        {
            try
            {
                List<Partido> jsonPartidos = await _repo.GetPartidos() ?? new List<Partido>();
                jsonPartidos.Add(partido);
                string jsonPartidosString = JsonSerializer.Serialize(jsonPartidos);
                var response = await _repo.PostAgregarPartido(jsonPartidosString);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el partido");
            }

        }

    }

}
