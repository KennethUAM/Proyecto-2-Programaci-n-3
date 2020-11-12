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
    public partial class Finalizado : Form
    {
        public Finalizado()
        {
            InitializeComponent();
        }

        Prestamo prestaFinalizado = new Prestamo();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Finalizado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prestaFinalizado.mostrarFinalizado();
        }
    }
}
