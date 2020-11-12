namespace Presentacion.Cliente
{
    partial class FormCliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisSolicitudesDePrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearSolicitudToolStripMenuItem,
            this.verMisSolicitudesDePrestamoToolStripMenuItem});
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.agregarCuentaToolStripMenuItem.Text = "Solicitudes";
            // 
            // crearSolicitudToolStripMenuItem
            // 
            this.crearSolicitudToolStripMenuItem.Name = "crearSolicitudToolStripMenuItem";
            this.crearSolicitudToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.crearSolicitudToolStripMenuItem.Text = "Crear solicitud";
            this.crearSolicitudToolStripMenuItem.Click += new System.EventHandler(this.crearSolicitudToolStripMenuItem_Click);
            // 
            // verMisSolicitudesDePrestamoToolStripMenuItem
            // 
            this.verMisSolicitudesDePrestamoToolStripMenuItem.Name = "verMisSolicitudesDePrestamoToolStripMenuItem";
            this.verMisSolicitudesDePrestamoToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.verMisSolicitudesDePrestamoToolStripMenuItem.Text = "Ver mis solicitudes de prestamo";
            this.verMisSolicitudesDePrestamoToolStripMenuItem.Click += new System.EventHandler(this.verMisSolicitudesDePrestamoToolStripMenuItem_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMisSolicitudesDePrestamoToolStripMenuItem;
    }
}