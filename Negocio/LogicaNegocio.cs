using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Negocio
{
    public class LogicaNegocio
    {
        private ProcesoTransaccion pro = new ProcesoTransaccion();







        public DataTable iniciaSesion(IniciaSesion obje)
        {
            return pro.IniciaSesion(obje);

        }

        int idRol = 3;



        public DataTable mostrarClientes()
        {


            DataTable tabla = new DataTable();
            tabla = pro.globalClientes();
            return tabla;


        }

        public void insertarDatos(String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, String edadUsuario, String telefonoUsuario, String direccionUsuario)
        {


           pro.agregarCliente(passUsuario, usernameUsuario, nombreUsuario, apellido1Usuario, apellido2Usuario, Convert.ToInt32(edadUsuario), Convert.ToInt32(telefonoUsuario), direccionUsuario, idRol);


        }




        public void editarCliente(String idUsuario, String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, String edadUsuario, String telefonoUsuario, String direccionUsuario)
        {

            pro.editarCliente(Convert.ToInt32(idUsuario),passUsuario,usernameUsuario,nombreUsuario,apellido1Usuario,apellido2Usuario,Convert.ToInt32(edadUsuario),Convert.ToInt32(telefonoUsuario),direccionUsuario);


        }



        public void eliminarCliente(String dni)
        {

            pro.eliminarCliente(Convert.ToInt32(dni));


        }








    }

}
