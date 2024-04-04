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
    }
}