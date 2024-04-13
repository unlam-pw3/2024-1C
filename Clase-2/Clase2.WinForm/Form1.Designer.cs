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
            btnCargarResultado = new Button();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            txtEquipoVisitante = new TextBox();
            cboGolesVisitante = new ComboBox();
            gvResultados = new DataGridView();
            cboGolesLocal = new ComboBox();
            txtEquipoLocal = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtEquipoACargar = new TextBox();
            btnCargarEquipo = new Button();
            btnEliminarEquipo = new Button();
            btnObtenerEquipos = new Button();
            gvEquipos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Equipo = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            txtPais = new TextBox();
            btnGuardarEquipos = new Button();
            btnGuardarResultados = new Button();
            IdRes = new DataGridViewTextBoxColumn();
            Local = new DataGridViewTextBoxColumn();
            gLocal = new DataGridViewTextBoxColumn();
            gVisitante = new DataGridViewTextBoxColumn();
            Visitante = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvEquipos).BeginInit();
            SuspendLayout();
            // 
            // btnCargarResultado
            // 
            btnCargarResultado.Location = new Point(211, 301);
            btnCargarResultado.Margin = new Padding(2);
            btnCargarResultado.Name = "btnCargarResultado";
            btnCargarResultado.Size = new Size(148, 23);
            btnCargarResultado.TabIndex = 1;
            btnCargarResultado.Text = "Cargar Resultado";
            btnCargarResultado.UseVisualStyleBackColor = true;
            btnCargarResultado.Click += btnCargarResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 217);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Equipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 217);
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
            groupBox2.Location = new Point(301, 196);
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
            gvResultados.Columns.AddRange(new DataGridViewColumn[] { IdRes, Local, gLocal, gVisitante, Visitante });
            gvResultados.Location = new Point(103, 340);
            gvResultados.Margin = new Padding(2);
            gvResultados.Name = "gvResultados";
            gvResultados.RowHeadersWidth = 62;
            gvResultados.RowTemplate.Height = 33;
            gvResultados.Size = new Size(389, 135);
            gvResultados.TabIndex = 7;
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
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(73, 21);
            txtEquipoLocal.Margin = new Padding(2);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(141, 23);
            txtEquipoLocal.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEquipoLocal);
            groupBox1.Controls.Add(cboGolesLocal);
            groupBox1.Location = new Point(43, 196);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(225, 93);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // txtEquipoACargar
            // 
            txtEquipoACargar.Location = new Point(103, 33);
            txtEquipoACargar.Name = "txtEquipoACargar";
            txtEquipoACargar.Size = new Size(127, 23);
            txtEquipoACargar.TabIndex = 8;
            // 
            // btnCargarEquipo
            // 
            btnCargarEquipo.Location = new Point(104, 115);
            btnCargarEquipo.Name = "btnCargarEquipo";
            btnCargarEquipo.Size = new Size(57, 23);
            btnCargarEquipo.TabIndex = 9;
            btnCargarEquipo.Text = "Agregar";
            btnCargarEquipo.UseVisualStyleBackColor = true;
            btnCargarEquipo.Click += btnCargarEquipo_Click;
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(169, 115);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(61, 23);
            btnEliminarEquipo.TabIndex = 10;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnObtenerEquipos
            // 
            btnObtenerEquipos.Location = new Point(133, 144);
            btnObtenerEquipos.Name = "btnObtenerEquipos";
            btnObtenerEquipos.Size = new Size(61, 23);
            btnObtenerEquipos.TabIndex = 11;
            btnObtenerEquipos.Text = "Obtener";
            btnObtenerEquipos.UseVisualStyleBackColor = true;
            btnObtenerEquipos.Click += btnObtenerEquipos_Click;
            // 
            // gvEquipos
            // 
            gvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvEquipos.Columns.AddRange(new DataGridViewColumn[] { Id, Equipo, Pais });
            gvEquipos.Location = new Point(301, 33);
            gvEquipos.Name = "gvEquipos";
            gvEquipos.RowHeadersWidth = 62;
            gvEquipos.RowTemplate.Height = 25;
            gvEquipos.Size = new Size(255, 105);
            gvEquipos.TabIndex = 12;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.MinimumWidth = 8;
            Equipo.Name = "Equipo";
            Equipo.Width = 150;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.MinimumWidth = 8;
            Pais.Name = "Pais";
            Pais.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 36);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 13;
            label5.Text = "Equipo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 67);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 14;
            label6.Text = "Pais:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(103, 68);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(127, 23);
            txtPais.TabIndex = 15;
            // 
            // btnGuardarEquipos
            // 
            btnGuardarEquipos.Location = new Point(207, 145);
            btnGuardarEquipos.Margin = new Padding(2);
            btnGuardarEquipos.Name = "btnGuardarEquipos";
            btnGuardarEquipos.Size = new Size(78, 20);
            btnGuardarEquipos.TabIndex = 16;
            btnGuardarEquipos.Text = "Guardar Equipos";
            btnGuardarEquipos.UseVisualStyleBackColor = true;
            btnGuardarEquipos.Click += btnGuardarEquipos_Click;
            // 
            // btnGuardarResultados
            // 
            btnGuardarResultados.Location = new Point(207, 491);
            btnGuardarResultados.Name = "btnGuardarResultados";
            btnGuardarResultados.Size = new Size(156, 23);
            btnGuardarResultados.TabIndex = 17;
            btnGuardarResultados.Text = "Guardar resultados";
            btnGuardarResultados.UseVisualStyleBackColor = true;
            btnGuardarResultados.Click += btnGuardarResultados_Click;
            // 
            // IdRes
            // 
            IdRes.HeaderText = "IdRes";
            IdRes.Name = "IdRes";
            IdRes.Visible = false;
            // 
            // Local
            // 
            Local.FillWeight = 60F;
            Local.HeaderText = "Local";
            Local.MinimumWidth = 8;
            Local.Name = "Local";
            Local.ReadOnly = true;
            // 
            // gLocal
            // 
            gLocal.FillWeight = 60F;
            gLocal.HeaderText = "gLocal";
            gLocal.Name = "gLocal";
            gLocal.Width = 60;
            // 
            // gVisitante
            // 
            gVisitante.FillWeight = 60F;
            gVisitante.HeaderText = "gVisitante";
            gVisitante.MinimumWidth = 8;
            gVisitante.Name = "gVisitante";
            gVisitante.ReadOnly = true;
            gVisitante.Width = 65;
            // 
            // Visitante
            // 
            Visitante.FillWeight = 60F;
            Visitante.HeaderText = "Visitante";
            Visitante.MinimumWidth = 8;
            Visitante.Name = "Visitante";
            Visitante.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(609, 560);
            Controls.Add(btnGuardarResultados);
            Controls.Add(btnGuardarEquipos);
            Controls.Add(txtPais);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(gvEquipos);
            Controls.Add(btnObtenerEquipos);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnCargarEquipo);
            Controls.Add(txtEquipoACargar);
            Controls.Add(gvResultados);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(btnCargarResultado);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Admin de Resultados";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCargarResultado;
        private Label label1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtEquipoVisitante;
        private ComboBox cboGolesVisitante;
        private DataGridView gvResultados;
        private ComboBox cboGolesLocal;
        private TextBox txtEquipoLocal;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtEquipoACargar;
        private Button btnCargarEquipo;
        private Button btnEliminarEquipo;
        private Button btnObtenerEquipos;
        private DataGridView gvEquipos;
        private Label label5;
        private Label label6;
        private TextBox txtPais;
        private Button btnGuardarEquipos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Equipo;
        private DataGridViewTextBoxColumn Pais;
        private Button btnGuardarResultados;
        private DataGridViewTextBoxColumn IdRes;
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn gLocal;
        private DataGridViewTextBoxColumn gVisitante;
        private DataGridViewTextBoxColumn Visitante;
    }
}