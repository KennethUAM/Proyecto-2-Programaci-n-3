using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Administrador;
using Presentacion.Empleado;

namespace Presentacion.Administrador
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }


        crearCliente cliente = new crearCliente();



        private void configuraciónClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ConfiguracionCliente confi = new ConfiguracionCliente();
            confi.Show();


        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo_Empleado empleado = new Modulo_Empleado();
            empleado.Show();
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configuraciónEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracionEmpleado confi = new ConfiguracionEmpleado();
            confi.Show();
        }
    }
}
