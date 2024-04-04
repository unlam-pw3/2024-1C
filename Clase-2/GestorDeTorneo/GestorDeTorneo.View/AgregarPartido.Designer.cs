using GestorDeTorneo.Models;
using System.Text.Json;

namespace GestorDeTorneo.View
{
    partial class AgregarPartido
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
            btnGuardarPartido = new Button();
            label6 = new Label();
            imptGolesVisitante = new TextBox();
            imptGolesLocal = new TextBox();
            label5 = new Label();
            cboVisitante = new ComboBox();
            cboLocal = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(232, 75);
            label2.Name = "label2";
            label2.Size = new Size(301, 37);
            label2.TabIndex = 22;
            label2.Text = "AGREGAR PARTIDO";
            // 
            // btnGuardarPartido
            // 
            btnGuardarPartido.Location = new Point(325, 274);
            btnGuardarPartido.Name = "btnGuardarPartido";
            btnGuardarPartido.Size = new Size(98, 23);
            btnGuardarPartido.TabIndex = 21;
            btnGuardarPartido.Text = "Guardar";
            btnGuardarPartido.UseVisualStyleBackColor = true;
            btnGuardarPartido.Click += btnGuardarPartido_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(368, 233);
            label6.Name = "label6";
            label6.Size = new Size(14, 19);
            label6.TabIndex = 20;
            label6.Text = "-";
            // 
            // imptGolesVisitante
            // 
            imptGolesVisitante.Location = new Point(390, 231);
            imptGolesVisitante.Name = "imptGolesVisitante";
            imptGolesVisitante.Size = new Size(33, 23);
            imptGolesVisitante.TabIndex = 19;
            // 
            // imptGolesLocal
            // 
            imptGolesLocal.Location = new Point(325, 231);
            imptGolesLocal.Name = "imptGolesLocal";
            imptGolesLocal.Size = new Size(33, 23);
            imptGolesLocal.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(344, 205);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 17;
            label5.Text = "GOLES";
            // 
            // cboVisitante
            // 
            cboVisitante.FormattingEnabled = true;
            cboVisitante.Location = new Point(384, 161);
            cboVisitante.Name = "cboVisitante";
            cboVisitante.Size = new Size(167, 23);
            cboVisitante.TabIndex = 16;
            // 
            // cboLocal
            // 
            cboLocal.FormattingEnabled = true;
            cboLocal.Location = new Point(200, 161);
            cboLocal.Name = "cboLocal";
            cboLocal.Size = new Size(167, 23);
            cboLocal.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(420, 130);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 14;
            label4.Text = "VISITANTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 130);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(254, 130);
            label1.Name = "label1";
            label1.Size = new Size(57, 19);
            label1.TabIndex = 13;
            label1.Text = "LOCAL";
            // 
            // AgregarPartido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnGuardarPartido);
            Controls.Add(label6);
            Controls.Add(imptGolesVisitante);
            Controls.Add(imptGolesLocal);
            Controls.Add(label5);
            Controls.Add(cboVisitante);
            Controls.Add(cboLocal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarPartido";
            Text = "AgregarPartido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnGuardarPartido;
        private Label label6;
        private TextBox imptGolesVisitante;
        private TextBox imptGolesLocal;
        private Label label5;
        private ComboBox cboVisitante;
        private ComboBox cboLocal;
        private Label label4;
        private Label label3;
        private Label label1;
        
    }
}