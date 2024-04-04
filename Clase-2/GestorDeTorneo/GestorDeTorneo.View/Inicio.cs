namespace GestorDeTorneo.View
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void OpenChildrenForm(object childForm)
        {
            if (this.contenedorPrincipal.Controls.Count > 0)
                this.contenedorPrincipal.Controls.RemoveAt(0);
            Form form = childForm as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.contenedorPrincipal.Controls.Add(form);
            this.contenedorPrincipal.Tag = form;
            form.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            OpenChildrenForm(new AgregarEquipo());
        }

        private void AgregarEquipo_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new AgregarEquipo());
        }

        private void AgregarPartido_Click(object sender, EventArgs e)
        {
            OpenChildrenForm(new AgregarPartido());
        }

        private async void DescargarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                string equiposJson = await ApiHelper.MakeApiRequest("/Equipos", HttpMethod.Get);

                GuardarJson(equiposJson, "equipos.json");

                MessageBox.Show("Equipos descargados y guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar y guardar equipos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DescargarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                string partidosJson = await ApiHelper.MakeApiRequest("/Partidos", HttpMethod.Get);

                GuardarJson(partidosJson, "partidos.json");

                MessageBox.Show("Partidos descargados y guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al descargar y guardar partidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarJson(string jsonData, string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                File.WriteAllText(filePath, jsonData);
            }
        }

    }
}
