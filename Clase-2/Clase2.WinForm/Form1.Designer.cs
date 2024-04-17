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
            this.btnCargarResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEquipoVisitante = new System.Windows.Forms.TextBox();
            this.cboGolesVisitante = new System.Windows.Forms.ComboBox();
            this.gvResultados = new System.Windows.Forms.DataGridView();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboGolesLocal = new System.Windows.Forms.ComboBox();
            this.txtEquipoLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEquipoACargar = new System.Windows.Forms.TextBox();
            this.btnCargarEquipo = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnObtenerEquipos = new System.Windows.Forms.Button();
            this.gvEquipos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnGuardarEquipos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarResultado
            // 
            this.btnCargarResultado.Location = new System.Drawing.Point(241, 402);
            this.btnCargarResultado.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarResultado.Name = "btnCargarResultado";
            this.btnCargarResultado.Size = new System.Drawing.Size(169, 26);
            this.btnCargarResultado.TabIndex = 10;
            this.btnCargarResultado.Text = "Cargar Resultado";
            this.btnCargarResultado.UseVisualStyleBackColor = true;
            this.btnCargarResultado.Click += new System.EventHandler(this.btnCargarResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEquipoVisitante);
            this.groupBox2.Controls.Add(this.cboGolesVisitante);
            this.groupBox2.Location = new System.Drawing.Point(344, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(257, 124);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goles:";
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.Location = new System.Drawing.Point(83, 28);
            this.txtEquipoVisitante.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.Size = new System.Drawing.Size(161, 27);
            this.txtEquipoVisitante.TabIndex = 8;
            // 
            // cboGolesVisitante
            // 
            this.cboGolesVisitante.FormattingEnabled = true;
            this.cboGolesVisitante.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboGolesVisitante.Location = new System.Drawing.Point(83, 62);
            this.cboGolesVisitante.Margin = new System.Windows.Forms.Padding(2);
            this.cboGolesVisitante.Name = "cboGolesVisitante";
            this.cboGolesVisitante.Size = new System.Drawing.Size(161, 28);
            this.cboGolesVisitante.TabIndex = 9;
            // 
            // gvResultados
            // 
            this.gvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Local,
            this.Goles,
            this.Visitante});
            this.gvResultados.Location = new System.Drawing.Point(91, 452);
            this.gvResultados.Margin = new System.Windows.Forms.Padding(2);
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.RowHeadersWidth = 62;
            this.gvResultados.RowTemplate.Height = 33;
            this.gvResultados.Size = new System.Drawing.Size(510, 180);
            this.gvResultados.TabIndex = 11;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.MinimumWidth = 8;
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Width = 150;
            // 
            // Goles
            // 
            this.Goles.HeaderText = "Goles";
            this.Goles.MinimumWidth = 8;
            this.Goles.Name = "Goles";
            this.Goles.ReadOnly = true;
            this.Goles.Width = 150;
            // 
            // Visitante
            // 
            this.Visitante.HeaderText = "Visitante";
            this.Visitante.MinimumWidth = 8;
            this.Visitante.Name = "Visitante";
            this.Visitante.ReadOnly = true;
            this.Visitante.Width = 150;
            // 
            // cboGolesLocal
            // 
            this.cboGolesLocal.FormattingEnabled = true;
            this.cboGolesLocal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboGolesLocal.Location = new System.Drawing.Point(83, 62);
            this.cboGolesLocal.Margin = new System.Windows.Forms.Padding(2);
            this.cboGolesLocal.Name = "cboGolesLocal";
            this.cboGolesLocal.Size = new System.Drawing.Size(161, 28);
            this.cboGolesLocal.TabIndex = 7;
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.Location = new System.Drawing.Point(83, 28);
            this.txtEquipoLocal.Margin = new System.Windows.Forms.Padding(2);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.Size = new System.Drawing.Size(161, 27);
            this.txtEquipoLocal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Goles:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEquipoLocal);
            this.groupBox1.Controls.Add(this.cboGolesLocal);
            this.groupBox1.Location = new System.Drawing.Point(49, 262);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(257, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // txtEquipoACargar
            // 
            this.txtEquipoACargar.Location = new System.Drawing.Point(118, 44);
            this.txtEquipoACargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEquipoACargar.Name = "txtEquipoACargar";
            this.txtEquipoACargar.Size = new System.Drawing.Size(145, 27);
            this.txtEquipoACargar.TabIndex = 0;
            // 
            // btnCargarEquipo
            // 
            this.btnCargarEquipo.Location = new System.Drawing.Point(119, 154);
            this.btnCargarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargarEquipo.Name = "btnCargarEquipo";
            this.btnCargarEquipo.Size = new System.Drawing.Size(65, 30);
            this.btnCargarEquipo.TabIndex = 2;
            this.btnCargarEquipo.Text = "Agregar";
            this.btnCargarEquipo.UseVisualStyleBackColor = true;
            this.btnCargarEquipo.Click += new System.EventHandler(this.btnCargarEquipo_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.Location = new System.Drawing.Point(193, 154);
            this.btnEliminarEquipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(70, 30);
            this.btnEliminarEquipo.TabIndex = 3;
            this.btnEliminarEquipo.Text = "Eliminar";
            this.btnEliminarEquipo.UseVisualStyleBackColor = true;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // btnObtenerEquipos
            // 
            this.btnObtenerEquipos.Location = new System.Drawing.Point(152, 192);
            this.btnObtenerEquipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObtenerEquipos.Name = "btnObtenerEquipos";
            this.btnObtenerEquipos.Size = new System.Drawing.Size(70, 30);
            this.btnObtenerEquipos.TabIndex = 4;
            this.btnObtenerEquipos.Text = "Obtener";
            this.btnObtenerEquipos.UseVisualStyleBackColor = true;
            this.btnObtenerEquipos.Click += new System.EventHandler(this.btnObtenerEquipos_Click);
            // 
            // gvEquipos
            // 
            this.gvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Equipo,
            this.Pais});
            this.gvEquipos.Location = new System.Drawing.Point(344, 44);
            this.gvEquipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gvEquipos.Name = "gvEquipos";
            this.gvEquipos.RowHeadersWidth = 62;
            this.gvEquipos.RowTemplate.Height = 25;
            this.gvEquipos.Size = new System.Drawing.Size(291, 140);
            this.gvEquipos.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.MinimumWidth = 8;
            this.Equipo.Name = "Equipo";
            this.Equipo.Width = 150;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.MinimumWidth = 8;
            this.Pais.Name = "Pais";
            this.Pais.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Equipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pais:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(118, 90);
            this.txtPais.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(145, 27);
            this.txtPais.TabIndex = 1;
            // 
            // btnGuardarEquipos
            // 
            this.btnGuardarEquipos.Location = new System.Drawing.Point(237, 193);
            this.btnGuardarEquipos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarEquipos.Name = "btnGuardarEquipos";
            this.btnGuardarEquipos.Size = new System.Drawing.Size(90, 27);
            this.btnGuardarEquipos.TabIndex = 5;
            this.btnGuardarEquipos.Text = "Guardar Equipos";
            this.btnGuardarEquipos.UseVisualStyleBackColor = true;
            this.btnGuardarEquipos.Click += new System.EventHandler(this.btnGuardarEquipos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 672);
            this.Controls.Add(this.btnGuardarEquipos);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gvEquipos);
            this.Controls.Add(this.btnObtenerEquipos);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnCargarEquipo);
            this.Controls.Add(this.txtEquipoACargar);
            this.Controls.Add(this.gvResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarResultado);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Admin de Resultados";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn Local;
        private DataGridViewTextBoxColumn Goles;
        private DataGridViewTextBoxColumn Visitante;
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
    }
}