namespace GestorDeTorneo.View
{
    partial class Inicio
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
            menuStrip1 = new MenuStrip();
            MenuDescargar = new ToolStripMenuItem();
            DescargarEquipos = new ToolStripMenuItem();
            DescargarPartidos = new ToolStripMenuItem();
            MenuAgregar = new ToolStripMenuItem();
            AgregarEquipo = new ToolStripMenuItem();
            AgregarPartido = new ToolStripMenuItem();
            contenedorPrincipal = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuDescargar, MenuAgregar });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuDescargar
            // 
            MenuDescargar.DropDownItems.AddRange(new ToolStripItem[] { DescargarEquipos, DescargarPartidos });
            MenuDescargar.Name = "MenuDescargar";
            MenuDescargar.Size = new Size(71, 20);
            MenuDescargar.Text = "Descargar";
            // 
            // DescargarEquipos
            // 
            DescargarEquipos.Name = "DescargarEquipos";
            DescargarEquipos.Size = new Size(180, 22);
            DescargarEquipos.Text = "Equipos";
            DescargarEquipos.Click += DescargarEquipos_Click;
            // 
            // DescargarPartidos
            // 
            DescargarPartidos.Name = "DescargarPartidos";
            DescargarPartidos.Size = new Size(180, 22);
            DescargarPartidos.Text = "Partidos";
            DescargarPartidos.Click += DescargarPartidos_Click;
            // 
            // MenuAgregar
            // 
            MenuAgregar.DropDownItems.AddRange(new ToolStripItem[] { AgregarEquipo, AgregarPartido });
            MenuAgregar.Name = "MenuAgregar";
            MenuAgregar.Size = new Size(61, 20);
            MenuAgregar.Text = "Agregar";
            // 
            // AgregarEquipo
            // 
            AgregarEquipo.Name = "AgregarEquipo";
            AgregarEquipo.Size = new Size(117, 22);
            AgregarEquipo.Text = "Equipos";
            AgregarEquipo.Click += AgregarEquipo_Click;
            // 
            // AgregarPartido
            // 
            AgregarPartido.Name = "AgregarPartido";
            AgregarPartido.Size = new Size(117, 22);
            AgregarPartido.Text = "Partidos";
            AgregarPartido.Click += AgregarPartido_Click;
            // 
            // contenedorPrincipal
            // 
            contenedorPrincipal.AutoSize = true;
            contenedorPrincipal.Location = new Point(0, 27);
            contenedorPrincipal.Name = "contenedorPrincipal";
            contenedorPrincipal.Size = new Size(800, 423);
            contenedorPrincipal.TabIndex = 12;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(contenedorPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Gestor de Torneo";
            Load += Inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuDescargar;
        private ToolStripMenuItem DescargarEquipos;
        private ToolStripMenuItem DescargarPartidos;
        private ToolStripMenuItem MenuAgregar;
        private ToolStripMenuItem AgregarEquipo;
        private ToolStripMenuItem AgregarPartido;
        private Panel contenedorPrincipal;
    }
}
