namespace CRUD.Equipos.Winform
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gvEquipo = new System.Windows.Forms.DataGridView();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEquipo
            // 
            this.txtEquipo.BackColor = System.Drawing.Color.MediumPurple;
            this.txtEquipo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEquipo.Location = new System.Drawing.Point(28, 35);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(201, 20);
            this.txtEquipo.TabIndex = 0;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.MediumPurple;
            this.txtPais.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPais.Location = new System.Drawing.Point(28, 90);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(201, 20);
            this.txtPais.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnviar.Location = new System.Drawing.Point(28, 143);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // gvEquipo
            // 
            this.gvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipo,
            this.Pais});
            this.gvEquipo.Location = new System.Drawing.Point(28, 215);
            this.gvEquipo.Name = "gvEquipo";
            this.gvEquipo.Size = new System.Drawing.Size(247, 150);
            this.gvEquipo.TabIndex = 3;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            // 
            // Pais
            // 
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.gvEquipo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEquipo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView gvEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
    }
}

