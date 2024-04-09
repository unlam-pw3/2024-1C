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
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).BeginInit();
            SuspendLayout();
            // 
            // cboGolesLocal
            // 
            cboGolesLocal.FormattingEnabled = true;
            cboGolesLocal.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboGolesLocal.Location = new Point(83, 62);
            cboGolesLocal.Margin = new Padding(2, 2, 2, 2);
            cboGolesLocal.Name = "cboGolesLocal";
            cboGolesLocal.Size = new Size(161, 28);
            cboGolesLocal.TabIndex = 0;
            // 
            // btnCargarResultado
            // 
            btnCargarResultado.Location = new Point(202, 141);
            btnCargarResultado.Margin = new Padding(2, 2, 2, 2);
            btnCargarResultado.Name = "btnCargarResultado";
            btnCargarResultado.Size = new Size(169, 27);
            btnCargarResultado.TabIndex = 1;
            btnCargarResultado.Text = "Cargar Resultado";
            btnCargarResultado.UseVisualStyleBackColor = true;
            btnCargarResultado.Click += btnCargarResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Equipo:";
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(83, 28);
            txtEquipoLocal.Margin = new Padding(2, 2, 2, 2);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(161, 27);
            txtEquipoLocal.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEquipoLocal);
            groupBox1.Controls.Add(cboGolesLocal);
            groupBox1.Location = new Point(10, 2);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(257, 124);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Local";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Goles:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Equipo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtEquipoVisitante);
            groupBox2.Controls.Add(cboGolesVisitante);
            groupBox2.Location = new Point(304, 2);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(257, 124);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 65);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Goles:";
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(83, 28);
            txtEquipoVisitante.Margin = new Padding(2, 2, 2, 2);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(161, 27);
            txtEquipoVisitante.TabIndex = 3;
            // 
            // cboGolesVisitante
            // 
            cboGolesVisitante.FormattingEnabled = true;
            cboGolesVisitante.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboGolesVisitante.Location = new Point(83, 62);
            cboGolesVisitante.Margin = new Padding(2, 2, 2, 2);
            cboGolesVisitante.Name = "cboGolesVisitante";
            cboGolesVisitante.Size = new Size(161, 28);
            cboGolesVisitante.TabIndex = 0;
            // 
            // gvResultados
            // 
            gvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvResultados.Columns.AddRange(new DataGridViewColumn[] { Local, Goles, Visitante });
            gvResultados.Location = new Point(51, 170);
            gvResultados.Margin = new Padding(2, 2, 2, 2);
            gvResultados.Name = "gvResultados";
            gvResultados.RowHeadersWidth = 62;
            gvResultados.RowTemplate.Height = 33;
            gvResultados.Size = new Size(510, 180);
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.LightSeaGreen;
            linkLabel1.Location = new Point(209, 382);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrar nuevo Equipo";
            linkLabel1.LinkClicked += registrarEquipo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(620, 501);
            Controls.Add(linkLabel1);
            Controls.Add(gvResultados);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(btnCargarResultado);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Admin de Resultados";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvResultados).EndInit();
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
        private LinkLabel linkLabel1;
    }
}