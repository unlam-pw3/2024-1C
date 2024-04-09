namespace Clase2.WinForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titulo = new Label();
            txtEquipoNombre = new TextBox();
            etiquetaNombre = new Label();
            labelPais = new Label();
            txtPaís = new TextBox();
            btnCargarDatos = new Button();
            btnMod = new Button();
            cboEquiposExistentes = new ComboBox();
            btnEliminarEquipo = new Button();
            tituilo2 = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Location = new Point(12, 23);
            titulo.Name = "titulo";
            titulo.Size = new Size(158, 20);
            titulo.TabIndex = 0;
            titulo.Text = "Agregar nuevo Equipo";
           
            // 
            // txtEquipoNombre
            // 
            txtEquipoNombre.Location = new Point(193, 67);
            txtEquipoNombre.Margin = new Padding(2);
            txtEquipoNombre.Name = "txtEquipoNombre";
            txtEquipoNombre.Size = new Size(161, 27);
            txtEquipoNombre.TabIndex = 4;
        
            // 
            // etiquetaNombre
            // 
            etiquetaNombre.AutoSize = true;
            etiquetaNombre.Location = new Point(27, 70);
            etiquetaNombre.Margin = new Padding(2, 0, 2, 0);
            etiquetaNombre.Name = "etiquetaNombre";
            etiquetaNombre.Size = new Size(143, 20);
            etiquetaNombre.TabIndex = 5;
            etiquetaNombre.Text = "Nombre del equipo:";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(27, 126);
            labelPais.Margin = new Padding(2, 0, 2, 0);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(113, 20);
            labelPais.TabIndex = 6;
            labelPais.Text = "País del equipo:";
            // 
            // txtPaís
            // 
            txtPaís.Location = new Point(193, 119);
            txtPaís.Margin = new Padding(2);
            txtPaís.Name = "txtPaís";
            txtPaís.Size = new Size(161, 27);
            txtPaís.TabIndex = 7;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Location = new Point(27, 179);
            btnCargarDatos.Margin = new Padding(2);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(169, 27);
            btnCargarDatos.TabIndex = 8;
            btnCargarDatos.Text = "Cargar Nuevo Equipo";
            btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(27, 380);
            btnMod.Margin = new Padding(2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(169, 27);
            btnMod.TabIndex = 9;
            btnMod.Text = "Modificar Equipo";
            btnMod.UseVisualStyleBackColor = true;
            // 
            // cboEquiposExistentes
            // 
            cboEquiposExistentes.FormattingEnabled = true;
            cboEquiposExistentes.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboEquiposExistentes.Location = new Point(35, 294);
            cboEquiposExistentes.Margin = new Padding(2);
            cboEquiposExistentes.Name = "cboEquiposExistentes";
            cboEquiposExistentes.Size = new Size(161, 28);
            cboEquiposExistentes.TabIndex = 10;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(234, 380);
            btnEliminarEquipo.Margin = new Padding(2);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(169, 27);
            btnEliminarEquipo.TabIndex = 11;
            btnEliminarEquipo.Text = "Eliminar Equipo";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            // 
            // tituilo2
            // 
            tituilo2.AutoSize = true;
            tituilo2.BackColor = Color.Transparent;
            tituilo2.Location = new Point(27, 242);
            tituilo2.Name = "tituilo2";
            tituilo2.Size = new Size(105, 20);
            tituilo2.TabIndex = 12;
            tituilo2.Text = "Editar Equipos";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(tituilo2);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(cboEquiposExistentes);
            Controls.Add(btnMod);
            Controls.Add(btnCargarDatos);
            Controls.Add(txtPaís);
            Controls.Add(labelPais);
            Controls.Add(etiquetaNombre);
            Controls.Add(txtEquipoNombre);
            Controls.Add(titulo);
            Name = "Form2";
            Text = "agregarEquipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        public TextBox txtEquipoNombre;
        private Label etiquetaNombre;
        private Label labelPais;
        public TextBox txtPaís;
        public Button btnCargarDatos;
        public Button btnMod;
        public ComboBox cboEquiposExistentes;
        public Button btnEliminarEquipo;
        private Label tituilo2;
    }
}