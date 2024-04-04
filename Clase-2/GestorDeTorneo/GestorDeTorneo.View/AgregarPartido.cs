using GestorDeTorneo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTorneo.View
{
    public partial class AgregarPartido : Form
    {
        private List<Equipo> equiposListLocal;
        private List<Equipo> equiposListVisitante;

        public AgregarPartido()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                var equiposJson = await ApiHelper.MakeApiRequest("/Equipos/GetEquiposConSuCancha", HttpMethod.Get);
                var equiposList = JsonSerializer.Deserialize<List<Equipo>>(equiposJson);

                equiposListLocal = equiposList.ToList();
                equiposListVisitante = equiposList.ToList();

                cboLocal.BeginInvoke(new Action(() =>
                {
                    cboLocal.DataSource = equiposListLocal;
                    cboLocal.DisplayMember = "Nombre";
                    cboLocal.ValueMember = "Estadio";
                }));
                cboVisitante.BeginInvoke(new Action(() =>
                {
                    cboVisitante.DataSource = equiposListVisitante;
                    cboVisitante.DisplayMember = "Nombre";
                    cboVisitante.ValueMember = "Estadio";
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            try
            {
               
                Equipo local = (Equipo)cboLocal.SelectedItem;
                Equipo visitante = (Equipo)cboVisitante.SelectedItem;

                string estadio = local.estadio;

                int[] goles = { Convert.ToInt32(imptGolesLocal.Text), Convert.ToInt32(imptGolesVisitante.Text) };

                Partido nuevoPartido = new Partido
                {
                    EquipoLocal = local.nombre,
                    EquipoVisitante = visitante.nombre,
                    Goles = goles,
                    Estadio = estadio
                };
                
                await ApiHelper.MakeApiRequest("/Partidos", HttpMethod.Post, nuevoPartido);

                MessageBox.Show("Partido guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el partido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
