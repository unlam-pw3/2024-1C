using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeTorneo.View
{
    public partial class AgregarEquipo : Form
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            try { 
                string nombre = txtNombre.Text;
                string estadio = txtEstadio.Text;
                var response = ApiHelper.MakeApiRequest("/Equipos", HttpMethod.Post, new { nombre, estadio });
                MessageBox.Show("Equipo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
