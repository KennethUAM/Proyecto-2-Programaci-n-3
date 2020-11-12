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

namespace Presentacion.Administrador
{
    public partial class crearCliente : Form
    {
        public crearCliente()
        {
            InitializeComponent();
        }


        LogicaNegocio nuevo = new LogicaNegocio();

        String ClientePassword, clienteName;


        public void limpiarCasillas()
        {
            nombreCliente.Text = "";
            primer.Text = ""; segundo.Text = "";
            direccion.Text = "";
            telefono.Text = "";
            edad.Text = "";
            usuario.Text = "";
            pass.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nombreCliente.Text == "" || primer.Text == "" || segundo.Text == "" || direccion.Text == "" ||  telefono.Text == "" || edad.Text == "" || usuario.Text == "" || pass.Text == "")
            {

                MessageBox.Show(" Error debe ingresar datos para poder agregar al usuario");



            }
            else if (nombreCliente.Text != "" || primer.Text != "" || segundo.Text != "" || direccion.Text != "" || telefono.Text != "" || edad.Text != "" || usuario.Text != "" || pass.Text != "")
            {



                nuevo.insertarDatos(pass.Text, usuario.Text, nombreCliente.Text, primer.Text, segundo.Text, edad.Text, telefono.Text, direccion.Text);
                MessageBox.Show(" Cliente creado de forma exitosa");
                ClientePassword = usuario.Text;
                clienteName = pass.Text;

                MessageBox.Show(" Por favor proporcine la siguiente información al Cliente, ya que es su nombre de usuario y contraseña para ingresar al sistema : \n Usuario : " + clienteName + " \n Password : " + ClientePassword);
                limpiarCasillas();



            }






        }
    }
}
