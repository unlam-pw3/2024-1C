using Clase2.Entidades;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Forms;

namespace Clase2.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarEquipo_Click(object sender, EventArgs e)
        {
            AgregarEquiposApi();
        }


        private void btnObtenerEquipos_Click(object sender, EventArgs e)
        {
            ObtenerEquiposApi();
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            EliminarEquiposApi();
        }

        private async Task ObtenerEquiposApi()
        {
            // URL de destino
            string url = "https://localhost:7169/api/Equipos";

            try
            {
                // Crear cliente HTTP
                using (HttpClient client = new HttpClient())
                {
                    // Configurar encabezados si es necesario (por ejemplo, para indicar el tipo de contenido)
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                    // Realizar la solicitud GET
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verificar si la solicitud fue exitosa (código de estado 200 OK)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Aquí puedes manejar la respuesta, por ejemplo, deserializar el JSON si es necesario
                        // Supongamos que la respuesta es una lista de objetos de tipo Equipo en formato JSON
                        List<Equipo> equipos = JsonConvert.DeserializeObject<List<Equipo>>(responseBody);

                        gvEquipos.Rows.Clear();

                        // Puedes hacer lo que necesites con la lista de equipos, como mostrarla en un DataGridView
                        foreach (var equipo in equipos)
                        {
                            // Por ejemplo, agregar cada equipo a un DataGridView llamado gvEquipos
                            AgregarEquipoAGrilla(gvEquipos, equipo);
                        }
                    }
                    else
                    {
                        // Manejar errores de solicitud
                        Console.WriteLine($"La solicitud falló con el código de estado: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de red o de la solicitud
                Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
            }
        }

        private async Task RealizarSolicitudHttpAsync(string url, HttpMethod metodo, string jsonBody)
        {
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
                    // Realizar la solicitud HTTP
                    HttpResponseMessage response = null;
                    switch (metodo.Method)
                    {
                        case "POST":
                            response = await client.PostAsync(url, bodyContent);
                            break;
                        case "PUT":
                            response = await client.PutAsync(url, bodyContent);
                            break;
                            // Aquí puedes agregar más casos para otros métodos HTTP si es necesario
                    }

                    // Verificar si la solicitud fue exitosa (código de estado 200 OK)
                    if (response != null && response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Console.WriteLine("Respuesta del servidor:");
                        Console.WriteLine(responseBody);
                        await ObtenerEquiposApi();
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

        private async Task AgregarEquiposApi()
        {
            // URL de destino
            string url = "https://localhost:7169/api/Equipos";

            // Contenido del cuerpo (en este caso, un JSON)
            string jsonBody = $"{{\"nombre_equipo\": \"{txtEquipoACargar.Text}\"," +
                              $"\"pais\": \"{txtPais.Text}\"}}";

            // Realizar la solicitud POST
            await RealizarSolicitudHttpAsync(url, HttpMethod.Post, jsonBody);
        }

        private async Task EliminarEquiposApi()
        {
            string nombreEquipoAEliminar = ObtenerNombreEquipoSeleccionado();

            if (string.IsNullOrEmpty(nombreEquipoAEliminar))
            {
                MessageBox.Show("Por favor, seleccione un equipo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // URL de destino
                string url = $"https://localhost:7169/api/Equipos";

                // Crear cliente HTTP
                using (HttpClient client = new HttpClient())
                {
                    // Realizar la solicitud DELETE
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    // Verificar si la solicitud fue exitosa (código de estado 204 No Content)
                    if (response.IsSuccessStatusCode)
                    {
                        // Informar al usuario que el equipo se eliminó correctamente
                        MessageBox.Show("Equipo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Actualizar la lista de equipos después de eliminar
                        await ObtenerEquiposApi();
                    }
                    else
                    {
                        // Manejar errores de solicitud
                        MessageBox.Show($"La solicitud falló con el código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de red o de la solicitud
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task ActualizarEquipoApi(Equipo equipo)
        {
            // URL de destino para actualizar un equipo (por ejemplo, se puede usar PUT)
            string url = $"https://localhost:7169/api/Equipos";

            // Contenido del cuerpo (en este caso, un JSON)
            string jsonBody = $"{{\"nombre_equipo\": \"{equipo.nombre_equipo}\"," +
                                $"\"id\": \"{equipo.Id}\"," +
                              $"\"pais\": \"{equipo.pais}\"}}";

            // Realizar la solicitud PUT para actualizar el equipo
            await RealizarSolicitudHttpAsync(url, HttpMethod.Put, jsonBody);
        }


        private String ObtenerNombreEquipoSeleccionado()
        {
            if (gvEquipos.CurrentRow != null)
            {
                // Suponiendo que la primera columna de la grilla contiene el nombre del equipo
                return gvEquipos.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                // Si no hay una fila seleccionada, devuelve una cadena vacía o maneja la situación según tus necesidades
                return string.Empty;
            }
        }

        private void AgregarEquipoAGrilla(DataGridView gv, Equipo equipo)
        {
            // Crear una nueva fila
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gv);

            // Asignar valores a las celdas de la fila
            fila.Cells[0].Value = equipo.Id;
            fila.Cells[1].Value = equipo.nombre_equipo;
            fila.Cells[2].Value = equipo.pais;

            // Agregar la fila al DataGridView
            gv.Rows.Add(fila);
        }

        private async void btnGuardarEquipos_Click(object sender, EventArgs e)
        {
            //recorrer grilla y actualizar
            foreach (DataGridViewRow row in gvEquipos.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                // Obtener los valores de las celdas de la fila
                string id = row.Cells[0].Value.ToString();
                string nombre = row.Cells[1].Value.ToString();
                string pais = row.Cells[2].Value.ToString();

                // Crear un objeto Equipo con los valores de la fila
                Equipo equipo = new Equipo
                {
                    Id = Int32.Parse(id),
                    nombre_equipo = nombre,
                    pais = pais
                };

                // Llamar al método para actualizar el equipo en la API
                await ActualizarEquipoApi(equipo);
            }

            ObtenerEquiposApi();
        }




        // ACA EMPIEZA RESULTADOS





        private void btnCargarResultado_Click(object sender, EventArgs e)
        {
            AgregarResultadoALaApi();
        }

        private void btnObtenerResultados_Click(object sender, EventArgs e)
        {
            ObtenerResultadosApi();
        }

        private async void btnGuardarResultados_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gvResultados.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                string local = row.Cells[0].Value.ToString();
                string goles = row.Cells[1].Value.ToString();
                string visitante = row.Cells[2].Value.ToString();
                string id = row.Cells[3].Value.ToString();
                string[] partes = goles.Split('-');
                string golesLocal = partes[0];
                string golesVisitante = partes[1];

                Resultado resultado = new Resultado
                {
                    Id = Int32.Parse(id),
                    EquipoLocal = local,
                    EquipoVisitante = visitante,
                    GolesLocal = golesLocal,
                    GolesVisitante = golesVisitante
                };

                await ActualizarResultadoApi(resultado);
            }

            ObtenerResultadosApi();
        }

        private async Task ActualizarResultadoApi(Resultado resultado)
        {
            string url = $"https://localhost:7169/api/Resultados";

            string jsonBody = $"{{\"equipoLocal\": \"{resultado.EquipoLocal}\"," +
                      $"\"equipoVisitante\": \"{resultado.EquipoVisitante}\"," +
                      $"\"golesLocal\": \"{resultado.GolesLocal}\"," +
                      $"\"golesVisitante\": \"{resultado.GolesVisitante}\"," + 
                      $"\"id\": \"{resultado.Id}\"}}";

            await RealizarSolicitudHttpAsync(url, HttpMethod.Put, jsonBody);
        }

        private async Task ObtenerResultadosApi()
        {
            string url = "https://localhost:7169/api/Resultados";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        List<Resultado> resultados = JsonConvert.DeserializeObject<List<Resultado>>(responseBody);

                        gvResultados.Rows.Clear();

                        foreach (var resultado in resultados)
                        {
                            AgregarFila(gvResultados, resultado);
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
                Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
            }
        }


        private async Task AgregarResultadoALaApi()
        {
            string url = "https://localhost:7169/api/Resultados";
            string jsonBody = $"{{\"equipoLocal\": \"{txtEquipoLocal.Text}\"," +
                              $"\"equipoVisitante\": \"{txtEquipoVisitante.Text}\"," +
                              $"\"golesLocal\": \"{cboGolesLocal.Text}\"," +
                              $"\"golesVisitante\": \"{cboGolesVisitante.Text}\"}}";
            await RealizarSolicitudHttpAsync(url, HttpMethod.Post, jsonBody);
            ObtenerResultadosApi();
        }

        private async Task EliminarResultadoApi()
        {
            string resultadoId = ObtenerResultadoSeleccionadoId();

            if (string.IsNullOrEmpty(resultadoId))
            {
                MessageBox.Show("Por favor, seleccione un resultado para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string url = $"https://localhost:7169/api/Resultados/{resultadoId}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Resultado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await ObtenerResultadosApi();
                    }
                    else
                    {
                        MessageBox.Show($"La solicitud falló con el código de estado: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AgregarFila(DataGridView gv, Resultado resultado)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gv);

            fila.Cells[0].Value = resultado.EquipoLocal;
            fila.Cells[1].Value = $"{resultado.GolesLocal}-{resultado.GolesVisitante}";
            fila.Cells[2].Value = resultado.EquipoVisitante;
            fila.Cells[3].Value = resultado.Id;

            gv.Rows.Add(fila);
        }

        private String ObtenerResultadoSeleccionadoId()
        {
            if (gvResultados.CurrentRow != null)
            {
                return gvResultados.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private void btnEliminarResultado_Click(object sender, EventArgs e)
        {
            EliminarResultadoApi();
        }
    }
}
