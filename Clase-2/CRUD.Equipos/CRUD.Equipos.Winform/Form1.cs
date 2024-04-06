using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CRUD.Equipos.Winform
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private async Task AgregarFila(DataGridView gv, string nombre, string pais)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(gv);

            fila.Cells[0].Value = nombre;  
            fila.Cells[1].Value = pais;    

            gv.Rows.Add(fila);
        }


        private async Task MandarALaApi()
        {
            string url = "https://localhost:7027/api/Equipo";

            string jsonBody = $"{{\"Nombre\": \"{txtEquipo.Text}\"," +
                $"\"Pais\": \"{txtPais.Text}\"}}";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

                HttpContent bodyContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, bodyContent);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //Console.WriteLine("Respuesta del servidor:");
                        //Console.WriteLine(responseBody);
                    }
                    else
                    {
                        Console.WriteLine($"La solicitud falló con el código de estado: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al realizar la solicitud: {ex.Message}");
                }
            }
        }

        private async void btnEnviar_Click_1(object sender, EventArgs e)
        {
            await MandarALaApi();
            AgregarFila(gvEquipo, txtEquipo.Text, txtPais.Text);
            txtEquipo.Text = txtPais.Text = "";
        }
    }
}
