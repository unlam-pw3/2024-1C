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
            this.cboGolesLocal = new System.Windows.Forms.ComboBox();
            this.btnCargarResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEquipoLocal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEquipoVisitante = new System.Windows.Forms.TextBox();
            this.cboGolesVisitante = new System.Windows.Forms.ComboBox();
            this.gvResultados = new System.Windows.Forms.DataGridView();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).BeginInit();
            this.SuspendLayout();
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
            this.cboGolesLocal.Location = new System.Drawing.Point(104, 78);
            this.cboGolesLocal.Name = "cboGolesLocal";
            this.cboGolesLocal.Size = new System.Drawing.Size(200, 33);
            this.cboGolesLocal.TabIndex = 0;
            // 
            // btnCargarResultado
            // 
            this.btnCargarResultado.Location = new System.Drawing.Point(252, 176);
            this.btnCargarResultado.Name = "btnCargarResultado";
            this.btnCargarResultado.Size = new System.Drawing.Size(211, 34);
            this.btnCargarResultado.TabIndex = 1;
            this.btnCargarResultado.Text = "Cargar Resultado";
            this.btnCargarResultado.UseVisualStyleBackColor = true;
            this.btnCargarResultado.Click += new System.EventHandler(this.btnCargarResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipo:";
            // 
            // txtEquipoLocal
            // 
            this.txtEquipoLocal.Location = new System.Drawing.Point(104, 35);
            this.txtEquipoLocal.Name = "txtEquipoLocal";
            this.txtEquipoLocal.Size = new System.Drawing.Size(200, 31);
            this.txtEquipoLocal.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEquipoLocal);
            this.groupBox1.Controls.Add(this.cboGolesLocal);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Goles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEquipoVisitante);
            this.groupBox2.Controls.Add(this.cboGolesVisitante);
            this.groupBox2.Location = new System.Drawing.Point(380, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 155);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visitante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Goles:";
            // 
            // txtEquipoVisitante
            // 
            this.txtEquipoVisitante.Location = new System.Drawing.Point(104, 35);
            this.txtEquipoVisitante.Name = "txtEquipoVisitante";
            this.txtEquipoVisitante.Size = new System.Drawing.Size(200, 31);
            this.txtEquipoVisitante.TabIndex = 3;
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
            this.cboGolesVisitante.Location = new System.Drawing.Point(104, 78);
            this.cboGolesVisitante.Name = "cboGolesVisitante";
            this.cboGolesVisitante.Size = new System.Drawing.Size(200, 33);
            this.cboGolesVisitante.TabIndex = 0;
            // 
            // gvResultados
            // 
            this.gvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Local,
            this.Goles,
            this.Visitante});
            this.gvResultados.Location = new System.Drawing.Point(64, 213);
            this.gvResultados.Name = "gvResultados";
            this.gvResultados.RowHeadersWidth = 62;
            this.gvResultados.RowTemplate.Height = 33;
            this.gvResultados.Size = new System.Drawing.Size(637, 225);
            this.gvResultados.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.gvResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarResultado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Admin de Resultados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}