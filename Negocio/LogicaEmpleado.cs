using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocio
{
    public class LogicaEmpleado
    {
        ProcesoTransaccion empleado = new ProcesoTransaccion();


        public void insertarDatos(String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, String edadUsuario, String telefonoUsuario, String direccionUsuario, String idRol)
        {


            empleado.agregarEmpleado(passUsuario, usernameUsuario, nombreUsuario, apellido1Usuario, apellido2Usuario, Convert.ToInt32(edadUsuario), Convert.ToInt32(telefonoUsuario), direccionUsuario, Convert.ToInt32(idRol));


        }


        public DataTable mostrarEmpleados()
        {


            DataTable tabla = new DataTable();
            tabla = empleado.globalEmpleados();
            return tabla;


        }


        public void editarEmpleado(String idUsuario, String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, String edadUsuario, String telefonoUsuario, String direccionUsuario)
        {

            empleado.editarEmpleado(Convert.ToInt32(idUsuario), passUsuario, usernameUsuario, nombreUsuario, apellido1Usuario, apellido2Usuario, Convert.ToInt32(edadUsuario), Convert.ToInt32(telefonoUsuario), direccionUsuario);


        }



        public void eliminarEmpleado(String dni)
        {

            empleado.eliminarEmpleado(Convert.ToInt32(dni));


        }








    }
}
