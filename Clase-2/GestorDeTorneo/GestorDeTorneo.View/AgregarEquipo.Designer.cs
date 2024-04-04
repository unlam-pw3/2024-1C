namespace GestorDeTorneo.View
{
    partial class AgregarEquipo
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtEstadio = new TextBox();
            btnAgregarEquipo = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(250, 111);
            label2.Name = "label2";
            label2.Size = new Size(282, 37);
            label2.TabIndex = 23;
            label2.Text = "AGREGAR EQUIPO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(227, 215);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 24;
            label1.Text = "ESTADIO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(224, 171);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 25;
            label3.Text = "NOMBRE:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(309, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 26;
            // 
            // txtEstadio
            // 
            txtEstadio.Location = new Point(309, 213);
            txtEstadio.Name = "txtEstadio";
            txtEstadio.Size = new Size(237, 23);
            txtEstadio.TabIndex = 27;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(341, 266);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(101, 23);
            btnAgregarEquipo.TabIndex = 28;
            btnAgregarEquipo.Text = "Agregar Equipo";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // AgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(txtEstadio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEquipo";
            Text = "AgregarEquipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtEstadio;
        private Button btnAgregarEquipo;
    }
}