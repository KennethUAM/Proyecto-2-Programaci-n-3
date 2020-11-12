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
    public partial class Modulo_Empleado : Form
    {

        String almacena = "";
        String guardar;
        String user = "";
        String pass = "";

        LogicaEmpleado nuevo = new LogicaEmpleado();


        public Modulo_Empleado()
        {
            InitializeComponent();
        }


        public void limpiar()
        {

            password.Text = "";
            username.Text = "";
            nombre.Text = "";
            apellido1.Text = "";
            apellido2.Text = "";
            edad.Text = "";
            telefono.Text = "";
            direccion.Text = "";
            rol.Text = "";



        }






        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "" || username.Text == "" || nombre.Text == "" || apellido1.Text == "" || apellido2.Text == "" || edad.Text == "" || telefono.Text == "" || direccion.Text == "" || rol.Text == "")
            {


                MessageBox.Show(" Error debe ingresar datos para poder agregar al usuario");



            } else if (password.Text != "" && username.Text != "" && nombre.Text != "" && apellido1.Text != "" && apellido2.Text != "" && edad.Text != "" && telefono.Text != "" && direccion.Text != "" && rol.Text != "")
            {

                user = username.Text;
                pass = password.Text;
                almacena = rol.Text;
                int temporal = Int16.Parse(almacena);


                    MessageBox.Show(" Usuario de empresa creado de forma exitosa");
                    nuevo.insertarDatos(password.Text, username.Text, nombre.Text, apellido1.Text, apellido2.Text, edad.Text, telefono.Text, direccion.Text, rol.Text);
                    limpiar();


               
                if (temporal == 1)
                {
                    guardar = " Administrador ";
                    MessageBox.Show(" Por favor proporcine la siguiente información al usuario, ya que es su nombre de usuario y contraseña para el login en la empresa : \n  Usuario : " + user + " \n Password : " + pass + " \n Rol en la empresa : " + guardar);





                }
                else if (temporal == 2)
                {

                    guardar = " Empleado ";
                    MessageBox.Show(" Por favor proporcine la siguiente información al usuario, ya que es su nombre de usuario y contraseña para el login en la empresa : \n  Usuario : " + user + " \n Password : " + pass + " \n Rol en la empresa : " + guardar);




                }






            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
