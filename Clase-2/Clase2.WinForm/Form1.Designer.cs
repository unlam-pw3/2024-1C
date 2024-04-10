namespace Clase2.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboGolesLocal = new ComboBox();
            btnCargarResultado = new Button();
            label1 = new Label();
            txtEquipoLocal = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtEquipoVisitante = new TextBox();
            cboGolesVisitante = new ComboBox();
            gvResultados = new DataGridView();
            Local = new DataGridViewTextBoxColumn();
            Goles = new DataGridViewTextBoxColumn();
            Visitante = new DataGridViewTextBoxColumn();
            txtNombreEquipo = new TextBox();
            txtNombrePais = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAgregarEquipo = new Button();
            btnListarEquipos = new Button();
            gvEquipos = new DataGridView();
            Equipo = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnEliminarEquipo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvEquipos).BeginInit();
            SuspendLayout();
            // 
            // cboGolesLocal
            // 
            cboGolesLocal.FormattingEnabled = true;
            cboGolesLocal.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboGolesLocal.Location = new Point(73, 47);
            cboGolesLocal.Margin = new Padding(2);
            cboGolesLocal.Name = "cboGolesLocal";
            cboGolesLocal.Size = new Size(141, 23);
            cboGolesLocal.TabIndex = 0;
            // 
            // btnCargarResultado
            // 
            btnCargarResultado.Location = new Point(176, 106);
            btnCargarResultado.Margin = new Padding(2);
            btnCargarResultado.Name = "btnCargarResultado";
            btnCargarResultado.Size = new Size(148, 20);
            btnCargarResultado.TabIndex = 1;
            btnCargarResultado.Text = "Cargar Resultado";
            btnCargarResultado.UseVisualStyleBackColor = true;
            btnCargarResultado.Click += btnCargarResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Equipo:";
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(73, 21);
            txtEquipoLocal.Margin = new Padding(2);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(141, 23);
            txtEquipoLocal.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEquipoLocal);
            groupBox1.Controls.Add(cboGolesLocal);
            groupBox1.Location = new Point(8, 1);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(225, 93);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Goles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Equipo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtEquipoVisitante);
            groupBox2.Controls.Add(cboGolesVisitante);
            groupBox2.Location = new Point(266, 1);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(225, 93);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 49);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Goles:";
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(73, 21);
            txtEquipoVisitante.Margin = new Padding(2);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(141, 23);
            txtEquipoVisitante.TabIndex = 3;
            // 
            // cboGolesVisitante
            // 
            cboGolesVisitante.FormattingEnabled = true;
            cboGolesVisitante.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboGolesVisitante.Location = new Point(73, 47);
            cboGolesVisitante.Margin = new Padding(2);
            cboGolesVisitante.Name = "cboGolesVisitante";
            cboGolesVisitante.Size = new Size(141, 23);
            cboGolesVisitante.TabIndex = 0;
            // 
            // gvResultados
            // 
            gvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvResultados.Columns.AddRange(new DataGridViewColumn[] { Local, Goles, Visitante });
            gvResultados.Location = new Point(45, 128);
            gvResultados.Margin = new Padding(2);
            gvResultados.Name = "gvResultados";
            gvResultados.RowHeadersWidth = 62;
            gvResultados.RowTemplate.Height = 33;
            gvResultados.Size = new Size(446, 135);
            gvResultados.TabIndex = 7;
            // 
            // Local
            // 
            Local.HeaderText = "Local";
            Local.MinimumWidth = 8;
            Local.Name = "Local";
            Local.ReadOnly = true;
            Local.Width = 150;
            // 
            // Goles
            // 
            Goles.HeaderText = "Goles";
            Goles.MinimumWidth = 8;
            Goles.Name = "Goles";
            Goles.ReadOnly = true;
            Goles.Width = 150;
            // 
            // Visitante
            // 
            Visitante.HeaderText = "Visitante";
            Visitante.MinimumWidth = 8;
            Visitante.Name = "Visitante";
            Visitante.ReadOnly = true;
            Visitante.Width = 150;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(878, 42);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(100, 23);
            txtNombreEquipo.TabIndex = 8;
            // 
            // txtNombrePais
            // 
            txtNombrePais.Location = new Point(878, 71);
            txtNombrePais.Name = "txtNombrePais";
            txtNombrePais.Size = new Size(100, 23);
            txtNombrePais.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(878, 9);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 10;
            label5.Text = "ABM_EQUIPOS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(825, 45);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Equipo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(838, 74);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Pais:";
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(797, 115);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(75, 23);
            btnAgregarEquipo.TabIndex = 13;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // btnListarEquipos
            // 
            btnListarEquipos.Location = new Point(1008, 115);
            btnListarEquipos.Name = "btnListarEquipos";
            btnListarEquipos.Size = new Size(75, 23);
            btnListarEquipos.TabIndex = 15;
            btnListarEquipos.Text = "Listar";
            btnListarEquipos.UseVisualStyleBackColor = true;
            btnListarEquipos.Click += btnListarEquipos_Click;
            // 
            // gvEquipos
            // 
            gvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEquipos.Columns.AddRange(new DataGridViewColumn[] { Equipo, Pais });
            gvEquipos.Location = new Point(757, 144);
            gvEquipos.Name = "gvEquipos";
            gvEquipos.RowHeadersWidth = 62;
            gvEquipos.RowTemplate.Height = 25;
            gvEquipos.Size = new Size(441, 150);
            gvEquipos.TabIndex = 16;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.Name = "Pais";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(903, 115);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(75, 23);
            btnEliminarEquipo.TabIndex = 18;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1274, 401);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(button1);
            Controls.Add(gvEquipos);
            Controls.Add(btnListarEquipos);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombrePais);
            Controls.Add(txtNombreEquipo);
            Controls.Add(gvResultados);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(btnCargarResultado);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Admin de Resultados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGolesLocal;
        private Button btnCargarResultado;
        private Label label1;
        private TextBox txtEquipoLocal;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtEquipoVisitante;
        private ComboBox cboGolesVisitante;
        private DataGridView gvResultados;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn Goles;
        private DataGridViewTextBoxColumn Visitante;
        private TextBox txtNombreEquipo;
        private TextBox txtNombrePais;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAgregarEquipo;
        private Button btnListarEquipos;
        private DataGridView gvEquipos;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Pais;
        private Button button1;
        private Button btnEliminarEquipo;
    }
}