using Clase2.Entidades;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Clase2.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarResultado_Click(object sender, EventArgs e)
        {
            //ResultadoServicio resultadoServicio = new ResultadoServicio();
            //resultadoServicio.Agregar(new Resultado
            //{
            //    EquipoLocal = txtEquipoLocal.Text,
            //    EquipoVisitante = txtEquipoVisitante.Text,
            //    GolesLocal = cboGolesLocal.Text,
            //    GolesVisitante = cboGolesVisitante.Text
            //});

            EnviarResultadoAApi();


            AgregarFila(gvResultados, txtEquipoLocal.Text, $"{cboGolesLocal.Text}-{cboGolesVisitante.Text}", txtEquipoVisitante.Text);
            txtEquipoLocal.Text = txtEquipoVisitante.Text = "";
        }

        private void AgregarFila(DataGridView gv, string equipoLocal, string goles, string equipoVisitante)
        {
            // Crear una nueva fila
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gv);

            // Asignar valores a las celdas de la fila
            fila.Cells[0].Value = equipoLocal;
            fila.Cells[1].Value = goles;
            fila.Cells[2].Value = equipoVisitante;

            // Agregar la fila al DataGridView
            gv.Rows.Add(fila);
        }

        private async Task EnviarResultadoAApi()
        {
            // URL de destino
            string url = "https://localhost:7169/api/Resultados";

            // Contenido del cuerpo (en este caso, un JSON)
            string jsonBody = $"{{\"equipoLocal\": \"{txtEquipoLocal.Text}\"," +
                $"\"equipoVisitante\": \"{txtEquipoVisitante.Text}\"," +
                $"\"golesLocal\": \"{cboGolesLocal.Text}\"," +
                $"\"golesVisitante\": \"{cboGolesVisitante.Text}\"}}";

            // Crear cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                // Configurar encabezados si es necesario (por ejemplo, para indicar el tipo de contenido)
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                // Crear el contenido del cuerpo
                HttpContent bodyContent = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                try
                {
                    // Realizar la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(url, bodyContent);

                    // Verificar si la solicitud fue exitosa (código de estado 200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Respuesta del servidor:");
                        Console.WriteLine(responseBody);
                    }
                    else
                    {
                        // Manejar errores de solicitud
                        Console.WriteLine($"La solicitud falló con el código de estado: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    // Manejar errores de red o de la solicitud
                    Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
                }
            }
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {

            string nombreEquipo = txtNombreEquipo.Text;
            string nombrePais = txtNombrePais.Text;

            // Si es nulo, muestro un mensaje para completar los datos
            if (string.IsNullOrEmpty(nombreEquipo) || string.IsNullOrEmpty(nombrePais))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            Equipo nuevoEquipo = new Equipo { Nombre = nombreEquipo, Pais = nombrePais };

            try
            {
                EnviarEquipoAApi(nuevoEquipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar equipo: {ex.Message}");
            }

        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {

            if (gvEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un equipo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow filaSeleccionada = gvEquipos.SelectedRows[0];
            string nombreEquipo = filaSeleccionada.Cells["Equipo"].Value.ToString();

            if (string.IsNullOrEmpty(nombreEquipo))
            {
                MessageBox.Show("Por favor, seleccione un equipo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                EliminarEquipoApi(nombreEquipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnListarEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarGrillaEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la lista de equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task EnviarEquipoAApi(Equipo equipo)
        {
            string url = "https://localhost:7169/api/Equipos";

            string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(equipo);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                HttpContent bodyContent = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, bodyContent);

                    if (response.IsSuccessStatusCode)
                    {
                        ActualizarGrillaEquipos();

                        txtNombreEquipo.Text = txtNombrePais.Text = "";
                    }
                    else
                    {
                        Console.WriteLine($"La solicitud falló con el código de estado: {response.StatusCode}");
                        MessageBox.Show("Error al agregar equipo.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
                    MessageBox.Show($"Error al agregar equipo: {ex.Message}");
                }
            }
        }

        private async Task ActualizarGrillaEquipos()
        {
            try
            {
                string url = "https://localhost:7169/api/Equipos";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        List<Equipo> equipos = JsonConvert.DeserializeObject<List<Equipo>>(json);

                        gvEquipos.Rows.Clear();

                        foreach (var equipo in equipos)
                        {
                            AgregarFilaEquipo(gvEquipos, equipo.Nombre, equipo.Pais);

                        }
                    }
                    else
                    {
                        Console.WriteLine($"La solicitud falló con el código de estado: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener la lista de equipos: {ex.Message}");
            }
        }

        private void AgregarFilaEquipo(DataGridView gv, string nombreEquipo, string nombrePais)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gv);

            fila.Cells[0].Value = nombreEquipo;
            fila.Cells[1].Value = nombrePais;

            gv.Rows.Add(fila);
        }


        private async Task EliminarEquipoApi(string nombreEquipo)
        {
            string url = $"https://localhost:7169/api/Equipos/{nombreEquipo}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    await ActualizarGrillaEquipos();
                    MessageBox.Show("Equipo eliminado correctamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMessage = $"La solicitud para eliminar el equipo '{nombreEquipo}' falló con el código de estado: {response.StatusCode}";
                    throw new Exception(errorMessage);
                }
            }
        }

    }
}