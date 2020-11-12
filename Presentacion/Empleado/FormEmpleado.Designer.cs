namespace Presentacion.Empleado
{
    partial class FormEmpleado
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
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorFinalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorCobroJudicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPrestamosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // verPrestamosToolStripMenuItem
            // 
            this.verPrestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarPorActivoToolStripMenuItem,
            this.filtrarPorToolStripMenuItem,
            this.filtrarPorFinalizadoToolStripMenuItem,
            this.filtrarPorCobroJudicialToolStripMenuItem});
            this.verPrestamosToolStripMenuItem.Name = "verPrestamosToolStripMenuItem";
            this.verPrestamosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.verPrestamosToolStripMenuItem.Text = "Prestamos";
            this.verPrestamosToolStripMenuItem.Click += new System.EventHandler(this.verPrestamosToolStripMenuItem_Click);
            // 
            // filtrarPorActivoToolStripMenuItem
            // 
            this.filtrarPorActivoToolStripMenuItem.Name = "filtrarPorActivoToolStripMenuItem";
            this.filtrarPorActivoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.filtrarPorActivoToolStripMenuItem.Text = "Filtrar por Activo";
            this.filtrarPorActivoToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorActivoToolStripMenuItem_Click);
            // 
            // filtrarPorToolStripMenuItem
            // 
            this.filtrarPorToolStripMenuItem.Name = "filtrarPorToolStripMenuItem";
            this.filtrarPorToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.filtrarPorToolStripMenuItem.Text = "Filtrar por  Atrasado";
            this.filtrarPorToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorToolStripMenuItem_Click);
            // 
            // filtrarPorFinalizadoToolStripMenuItem
            // 
            this.filtrarPorFinalizadoToolStripMenuItem.Name = "filtrarPorFinalizadoToolStripMenuItem";
            this.filtrarPorFinalizadoToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.filtrarPorFinalizadoToolStripMenuItem.Text = "Filtrar por Finalizado";
            this.filtrarPorFinalizadoToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorFinalizadoToolStripMenuItem_Click);
            // 
            // filtrarPorCobroJudicialToolStripMenuItem
            // 
            this.filtrarPorCobroJudicialToolStripMenuItem.Name = "filtrarPorCobroJudicialToolStripMenuItem";
            this.filtrarPorCobroJudicialToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.filtrarPorCobroJudicialToolStripMenuItem.Text = "Filtrar por Cobro Judicial";
            this.filtrarPorCobroJudicialToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorCobroJudicialToolStripMenuItem_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorFinalizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorCobroJudicialToolStripMenuItem;
    }
}