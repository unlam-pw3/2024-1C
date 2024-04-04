using GestorDeTorneo.Models;
using System.Text.Json;

namespace GestorDeTorneo.Repository
{
    public class EquiposRepository
    {
        private readonly string _equipos = "Assets/Equipos.json";

        public async Task<List<Equipo>> GetEquipos()
        {
            if (File.Exists(_equipos))
            {
                string JsonEquipos = await File.ReadAllTextAsync(_equipos);
                if (!string.IsNullOrEmpty(JsonEquipos))
                {
                    List<Equipo> Equipos = JsonSerializer.Deserialize<List<Equipo>>(JsonEquipos);
                    return Equipos;
                }
            }
            return null;
        }

        public async Task<bool> PostAgregarEquipo(string jsonEquiposConSuCanchaString)
        {
            try
            {
                await File.WriteAllTextAsync(_equipos, jsonEquiposConSuCanchaString);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el equipo");
            }
        }
    }
}


