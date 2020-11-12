namespace Presentacion.Administrador
{
    partial class FormAdministrador
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
            this.moduloClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloClienteToolStripMenuItem,
            this.moduloEmpresaToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moduloClienteToolStripMenuItem
            // 
            this.moduloClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearClienteToolStripMenuItem,
            this.configuraciónClienteToolStripMenuItem});
            this.moduloClienteToolStripMenuItem.Name = "moduloClienteToolStripMenuItem";
            this.moduloClienteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.moduloClienteToolStripMenuItem.Text = "Modulo Cliente";
            // 
            // crearClienteToolStripMenuItem
            // 
            this.crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            this.crearClienteToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.crearClienteToolStripMenuItem.Text = "Crear Cliente";
            this.crearClienteToolStripMenuItem.Click += new System.EventHandler(this.crearClienteToolStripMenuItem_Click);
            // 
            // configuraciónClienteToolStripMenuItem
            // 
            this.configuraciónClienteToolStripMenuItem.Name = "configuraciónClienteToolStripMenuItem";
            this.configuraciónClienteToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.configuraciónClienteToolStripMenuItem.Text = "Configuración Cliente";
            this.configuraciónClienteToolStripMenuItem.Click += new System.EventHandler(this.configuraciónClienteToolStripMenuItem_Click);
            // 
            // moduloEmpresaToolStripMenuItem
            // 
            this.moduloEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEmpleadoToolStripMenuItem,
            this.configuraciónEmpleadoToolStripMenuItem});
            this.moduloEmpresaToolStripMenuItem.Name = "moduloEmpresaToolStripMenuItem";
            this.moduloEmpresaToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.moduloEmpresaToolStripMenuItem.Text = "Modulo Empresa";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            this.crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            this.crearEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.crearEmpleadoToolStripMenuItem.Text = "Crear Empleado";
            this.crearEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.crearEmpleadoToolStripMenuItem_Click);
            // 
            // configuraciónEmpleadoToolStripMenuItem
            // 
            this.configuraciónEmpleadoToolStripMenuItem.Name = "configuraciónEmpleadoToolStripMenuItem";
            this.configuraciónEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.configuraciónEmpleadoToolStripMenuItem.Text = "Configuración Empleado";
            this.configuraciónEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.configuraciónEmpleadoToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 682);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moduloClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}