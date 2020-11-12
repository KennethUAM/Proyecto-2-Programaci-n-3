using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Presentacion.Administrador;
using Presentacion.Empleado;
using Presentacion.Cliente;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        int contador = 0;

        public IniciaSesion objeuser = new IniciaSesion();
        public LogicaNegocio objeNego = new LogicaNegocio();

        public static int id { get; set; } = 0;

        public static String usuario_name;
        public static int idRol;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            objeuser.username = textUsername.Text;
            objeuser.clave = textPass.Text;
            dt = objeNego.iniciaSesion(objeuser);

            if (textUsername.Text == "" || textPass.Text == "")
            {


                MessageBox.Show(" Las casillas no pueden estar vacias");


            }

            else if (textUsername.Text != "" && textPass.Text != "")
            {



                if (dt.Rows.Count > 0)
                {


                    MessageBox.Show(" Bienvenido " + dt.Rows[0][0].ToString(), " Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuario_name = dt.Rows[0][0].ToString();
                    idRol = dt.Rows[0][1].GetHashCode();
                    id = dt.Rows[0][4].GetHashCode();
                    //MessageBox.Show("" + id);
                    // nuevo.mostrarPaquetes(id);


                    if (idRol == 1)
                    {

                        FormAdministrador admin = new FormAdministrador();
                        admin.Show();
                        // adminForm form = new adminForm();
                        //form.Show();
                        this.Hide();
                        ///MessageBox.Show(" ADMINISTRADOR " + id);



                    }
                    if (idRol == 2)
                    {

                        //MessageBox.Show("EMPLEADO");
                        //MessageBox.Show(" Bienvenido " + dt.Rows[0][0].ToString(), " Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Colaborador colaborador = new Colaborador();
                        // colaborador.Show();
                        this.Hide();
                       /// MessageBox.Show(" EMPLEADO " + id);
                        FormEmpleado emple = new FormEmpleado();
                        emple.Show();


                    }
                    if (idRol == 3)
                    {

                        //MessageBox.Show(" Bienvenido " + dt.Rows[0][0].ToString(), " Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("CLIENTE");
                        //MessageBox.Show(" Bienvenido " + dt.Rows[0][4].ToString(), " Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // idUsuario = dt.Rows[0][4].GetHashCode();
                        //id = idUsuario;

                        // MessageBox.Show("" + id);

                        // formCliente cliente = new formCliente();
                        //cliente.Show();
                        this.Hide();
                       // MessageBox.Show(" CLIENTE "+id);
                        FormCliente clie = new FormCliente();
                        clie.Show();






                    }


                }
                else
                {
                    MessageBox.Show(" Usuario o contraseña incorrecta ");
                   // limpia();

                    contador++;
                    if (contador == 3)
                    {

                        MessageBox.Show(" Ha sobrepasado los intentos de sesion por logueo, por favor contacte al administrador para su ayuda ");

                        this.Close();



                    }
                }




            }



        }
    }
}
