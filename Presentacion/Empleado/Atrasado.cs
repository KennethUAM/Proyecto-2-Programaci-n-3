using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion.Empleado
{
    public partial class Atrasado : Form
    {
        public Atrasado()
        {
            InitializeComponent();
        }


        Prestamo prestaAtrasado = new Prestamo();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Atrasado_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = prestaAtrasado.mostrarAtrasado();

        }
    }
}
