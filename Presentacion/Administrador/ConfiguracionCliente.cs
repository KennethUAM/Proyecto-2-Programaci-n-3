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
using System.Data.SqlClient;


namespace Presentacion.Administrador
{
    public partial class ConfiguracionCliente : Form
    {

        public ConfiguracionCliente()
        {
            InitializeComponent();
        }

        LogicaNegocio negocio = new LogicaNegocio();

        private Boolean editar = false;
        String dniCliente;


        public void mostrarClientes()
        {
           dataGridView1.DataSource = negocio.mostrarClientes();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void ConfiguracionCliente_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


         
       
       

            
        }


        public void limpiarCasillas()
        {
            id.Text = "";
            pass.Text = "";
            username.Text = "";
            nombre.Text = "";
            apellido1.Text = "";
            apellido2.Text = "";
            edad.Text = "";
            tel.Text = "";
            dir.Text = "";

        }





        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                id.Text = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
                pass.Text = dataGridView1.CurrentRow.Cells["passUsuario"].Value.ToString();
                username.Text = dataGridView1.CurrentRow.Cells["usernameUsuario"].Value.ToString();
                nombre.Text = dataGridView1.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                apellido1.Text = dataGridView1.CurrentRow.Cells["apellido1Usuario"].Value.ToString();
                apellido2.Text = dataGridView1.CurrentRow.Cells["apellido2Usuario"].Value.ToString();
                edad.Text = dataGridView1.CurrentRow.Cells["edadUsuario"].Value.ToString();
                tel.Text = dataGridView1.CurrentRow.Cells["telefonoUsuario"].Value.ToString();
                dir.Text = dataGridView1.CurrentRow.Cells["direccionUsuario"].Value.ToString();



            }else
                MessageBox.Show("Seleccione una fila");





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {

                try
                {
                    negocio.editarCliente(id.Text,pass.Text,username.Text,nombre.Text,apellido1.Text,apellido2.Text,edad.Text,tel.Text,dir.Text);
                    MessageBox.Show("Se ha editado un usuario");
                    refrescarCliente();
                    limpiarCasillas();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error por" + ex);
                }




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {




            if (id.Text == "")
            {

                MessageBox.Show(" Parece ser que no hay registros a eliminar, debe primero ingresar un registro primero ");

            }
            else

               if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {



                    dniCliente = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
                    negocio.eliminarCliente(dniCliente);
                    MessageBox.Show(" Cliente eliminado de forma exitosa ");
                    refrescarCliente();
                    limpiarCasillas();

                }
                catch (Exception i)
                {
                    MessageBox.Show(" Parece ser que hay una cuenta asociada a este usuario, por lo que no se puede eliminar  \n "+i);
                    

                }

            }
            else
            {


                MessageBox.Show("No existen empleados a eliminar");

            }
        }


        public void refrescarCliente()
        {


            LogicaNegocio clienteRefresca = new LogicaNegocio();
            

            dataGridView1.DataSource = clienteRefresca.mostrarClientes();

        }



    }
}
