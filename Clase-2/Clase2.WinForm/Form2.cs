using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2.WinForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async  void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            await AgregarEquipo(txtNombreEquipo.Text, txtPaisEquipo.Text);
        }

        private async void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            await ModificarEquipo(txtNombreEquipo.Text, txtPaisEquipo.Text);
        }

        private async void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            await EliminarEquipo(txtNombreEquipo.Text);
        }

        private async Task AgregarEquipo(string nombreEquipo, string paisEquipo)
        {
            // URL de destino
            string url = "https://localhost:7169/api/Equipos";

            // Contenido del cuerpo (en este caso, un JSON)
            string jsonBody = $"{{\"Nombre\": \"{nombreEquipo}\", \"Pais\": \"{paisEquipo}\"}}";

            await EnviarSolicitudHttp(url, HttpMethod.Post, jsonBody);
        }

        private async Task ModificarEquipo(string nombreEquipo, string paisEquipo)
        {
            // URL de destino
            string url = $"https://localhost:7169/api/Equipos/{nombreEquipo}";

            // Contenido del cuerpo (en este caso, un JSON)
            string jsonBody = $"{{\"Nombre\": \"{nombreEquipo}\", \"Pais\": \"{paisEquipo}\"}}";

            await EnviarSolicitudHttp(url, HttpMethod.Put, jsonBody);
        }

        private async Task EliminarEquipo(string nombreEquipo)
        {
            // URL de destino
            string url = $"https://localhost:7169/api/Equipos/{nombreEquipo}";

            await EnviarSolicitudHttp(url, HttpMethod.Delete, null);
        }

        private async Task EnviarSolicitudHttp(string url, HttpMethod metodo, string jsonBody)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                HttpContent bodyContent = null;
                if (jsonBody != null)
                {
                    bodyContent = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");
                }

                try
                {
                    HttpResponseMessage response;
                    if (metodo == HttpMethod.Post)
                    {
                        response = await client.PostAsync(url, bodyContent);
                    }
                    else if (metodo == HttpMethod.Put)
                    {
                        response = await client.PutAsync(url, bodyContent);
                    }
                    else if (metodo == HttpMethod.Delete)
                    {
                        response = await client.DeleteAsync(url);
                    }
                    else
                    {
                        throw new ArgumentException("Método HTTP no válido");
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Operación realizada exitosamente");
                    }
                    else
                    {
                        MessageBox.Show($"La solicitud falló con el código de estado: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar la solicitud: {ex.Message}");
                }
            }
        }
    }
}
