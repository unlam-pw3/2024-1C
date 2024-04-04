using GestorDeTorneo.Interface;
using GestorDeTorneo.Models;
using System.Text.Json;

namespace GestorDeTorneo.Repository
{
    public class PartidosRepository
    {
        private readonly string _partidos = "Assets/Partidos.json";

        public async Task<List<Partido>> GetPartidos()
        {
            if (File.Exists(_partidos))
            {
                string JsonPartidos = await File.ReadAllTextAsync(_partidos);
                if (!string.IsNullOrEmpty(JsonPartidos))
                {
                    List<Partido> Partidos = JsonSerializer.Deserialize<List<Partido>>(JsonPartidos);
                    return Partidos;
                }
            }
            return null;
        }

        public async Task<bool> PostAgregarPartido(string jsonPartidos)
        {
            try
            {
                await File.WriteAllTextAsync(_partidos, jsonPartidos);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el partido");
            }
        }
    }
}


