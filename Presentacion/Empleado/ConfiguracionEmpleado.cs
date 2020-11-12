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
    public partial class ConfiguracionEmpleado : Form
    {
        public ConfiguracionEmpleado()
        {
            InitializeComponent();
        }

        private Boolean editar = false;

        LogicaEmpleado empleado = new LogicaEmpleado();

        String dniEmpleado;

        private void ConfiguracionEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        public void limpiarCasillas()
        {
            id.Text = "";
            pass.Text = "";
            usuario.Text = "";
            nombre.Text = "";
            apellido1.Text = "";
            apellido2.Text = "";
            edad.Text = "";
            telefono.Text = "";
            direccion.Text = "";

        }




        public void MostrarEmpleados()
        {


            dataGridView1.DataSource = empleado.mostrarEmpleados();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {

                try
                {
                    empleado.editarEmpleado(id.Text, pass.Text, usuario.Text, nombre.Text, apellido1.Text, apellido2.Text, edad.Text, telefono.Text, direccion.Text);
                    MessageBox.Show("Se ha editado un usuario");
                    refrescarEmpleado();
                    limpiarCasillas();

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Se produjo un error por" + ex);
                }




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                id.Text = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
                pass.Text = dataGridView1.CurrentRow.Cells["passUsuario"].Value.ToString();
                usuario.Text = dataGridView1.CurrentRow.Cells["usernameUsuario"].Value.ToString();
                nombre.Text = dataGridView1.CurrentRow.Cells["nombreUsuario"].Value.ToString();
                apellido1.Text = dataGridView1.CurrentRow.Cells["apellido1Usuario"].Value.ToString();
                apellido2.Text = dataGridView1.CurrentRow.Cells["apellido2Usuario"].Value.ToString();
                edad.Text = dataGridView1.CurrentRow.Cells["edadUsuario"].Value.ToString();
                telefono.Text = dataGridView1.CurrentRow.Cells["telefonoUsuario"].Value.ToString();
                direccion.Text = dataGridView1.CurrentRow.Cells["direccionUsuario"].Value.ToString();



            }
            else
                MessageBox.Show("Seleccione una fila");
        }


        private void button1_Click(object sender, EventArgs e)
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



                    dniEmpleado = dataGridView1.CurrentRow.Cells["idUsuario"].Value.ToString();
                    empleado.eliminarEmpleado(dniEmpleado);
                    MessageBox.Show(" Cliente eliminado de forma exitosa ");
                    refrescarEmpleado();
                    limpiarCasillas();

                }
                catch (Exception i)
                {
                    MessageBox.Show(" Parece ser que hay una cuenta asociada a este usuario, por lo que no se puede eliminar  \n " + i);


                }

            }
            else
            {


                MessageBox.Show("No existen empleados a eliminar");

            }
        }

        public void refrescarEmpleado()
        {


            LogicaEmpleado refrescaEmpleado = new LogicaEmpleado();


            dataGridView1.DataSource = refrescaEmpleado.mostrarEmpleados();
        }




    }
}
