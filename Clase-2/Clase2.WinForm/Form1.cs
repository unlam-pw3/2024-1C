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

        private void btnGuardarEquipos_Click(object sender, EventArgs e)
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
                ActualizarEquipoApi(equipo);
            }

            ObtenerEquiposApi();
        }
    }
}