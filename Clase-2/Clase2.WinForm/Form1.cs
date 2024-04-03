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
    }
}