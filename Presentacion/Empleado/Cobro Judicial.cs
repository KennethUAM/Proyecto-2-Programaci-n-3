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
    public partial class Cobro_Judicial : Form
    {
        public Cobro_Judicial()
        {
            InitializeComponent();
        }


        Prestamo prestaCobro = new Prestamo();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cobro_Judicial_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prestaCobro.mostrarCobro();
        }
    }
}
