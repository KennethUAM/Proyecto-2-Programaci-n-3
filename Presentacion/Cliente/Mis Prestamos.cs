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

namespace Presentacion.Cliente
{
    public partial class Mis_Prestamos : Form
    {
        public Mis_Prestamos()
        {
            InitializeComponent();
        }

        int d = Form1.id;

        Prestamo presta = new Prestamo();


        private void Mis_Prestamos_Load(object sender, EventArgs e)
        {
            mostrarPaquetes(d);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void mostrarPaquetes(int idUsuario)
        {



            dataGridView1.DataSource = presta.mostrarPrestamos(idUsuario);





        }
    }
}
