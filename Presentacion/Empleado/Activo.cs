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
    public partial class Activo : Form
    {
        public Activo()
        {
            InitializeComponent();
        }

        Prestamo prestaAactivo = new Prestamo();
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Activo_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = prestaAactivo.mostrarActivo();

        }
    }
}
