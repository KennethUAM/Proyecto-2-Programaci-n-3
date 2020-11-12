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
    public partial class Global_Prestamos : Form
    {
        public Global_Prestamos()
        {
            InitializeComponent();
        }


        Prestamo presta = new Prestamo();
        private Boolean editar = false;

        private void Global_Prestamos_Load(object sender, EventArgs e)
        {
            mostrarPrestamos();

        }


        public void mostrarPrestamos()
        {


            dataGridView1.DataSource = presta.mostrarPrestamos();


        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idPrestamo.Text == "" || estadoPrestamo.Text == "")
            {

                MessageBox.Show("Debe escribir parametros para poder modifar la cuenta ");



            }
            else if (idPrestamo.Text != "" || estadoPrestamo.Text != "")
            {
                try
                {
                    presta.editarCuenta(idPrestamo.Text, estadoPrestamo.Text);
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" Error al tratar de modififcar la cuenta " +ex);
                }


               
                MessageBox.Show(" Cuenta editada de forma exitosa ");
                limpiar();
                refrescarCuenta();



            }





        }



        public void limpiar()
        {

            idPrestamo.Text = "";
            estadoPrestamo.Text = "";





        }





       public void refrescarCuenta()
        {

            Prestamo refrescarPrestamo = new Prestamo();

            dataGridView1.DataSource = refrescarPrestamo.mostrarPrestamos();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (idPrestamo.Text == "")
            {
                MessageBox.Show(" Debe seleccionar la cuenta a eliminar ");



            }else
                try
                {
                    presta.eliminaCuenta(idPrestamo.Text);
                    MessageBox.Show(" Cuenta eliminada de forma exitosa");
                    limpiar();
                    refrescarCuenta();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(" Ocurrio un error al tratar de eliminar la cuenta "+ex);
                }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;

                idPrestamo.Text = dataGridView1.CurrentRow.Cells["idCuenta"].Value.ToString();
                estadoPrestamo.Text = dataGridView1.CurrentRow.Cells["estadoCuenta"].Value.ToString();



            }
            else

                MessageBox.Show("Seleccion una fila");
        }
    }
}
