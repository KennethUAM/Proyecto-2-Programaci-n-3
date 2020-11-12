using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;
using Negocio;

namespace Presentacion.Cliente
{
    public partial class AbrirCuenta : Form
    {
        public AbrirCuenta()
        {
            InitializeComponent();
        }

        int d = Form1.id; // desde aqui se abrira agregara la cuenta al usuario 

        Prestamo presta = new Prestamo();


        String fechaSale = "10-10-10";

        String fechaLlegada = "10-10-10";

        String dato = "Activo";

        int login = Form1.id;

        private void AbrirCuenta_Load(object sender, EventArgs e)
        {


            mostrarMisCuentas(d);

        }





        public void mostrarMisCuentas(int idUsuario)
        {



            dataGridView1.DataSource = presta.mostrarPrestamos(idUsuario);


        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(solicitud.Text == "")
            {
                MessageBox.Show(" Debe escribir un detalle para su solicitud");
            }
            else
            {
                try
                {
                    String d = login.ToString();
                    presta.agregarPaquete(fechaSale, fechaLlegada,dato, d, solicitud.Text);
                    MessageBox.Show(" Solicitud realizada de forma exitosa, favor revise su modulo de solicitudes de prestamo ");
                    solicitud.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" Hubo un error en su solicitud por favor contacte al prestamista "+ ex);
                }



            }
        }

        private void solicitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            solicitud.Text = "";
        }
    }
}
