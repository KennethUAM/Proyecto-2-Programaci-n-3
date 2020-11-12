using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;
using Entidades;

namespace Datos
{
    public class ProcesoTransaccion
    {

        public AccesoDatos cn = new AccesoDatos();
        SqlDataReader lectura;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable IniciaSesion(IniciaSesion obje)
        {

            SqlCommand cmd = new SqlCommand("iniciaSesion", cn.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usernameUsuario", obje.username);
            cmd.Parameters.AddWithValue("@passUsuario", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }



        public DataTable globalClientes()
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "verClientes";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }


        public void agregarCliente(String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, int edadUsuario, int TelefonoUsuario, String direccionUsuario, int idRol)
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "agregarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@passUsuario", passUsuario);
            comando.Parameters.AddWithValue("@usernameUsuario", usernameUsuario);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@apellido1Usuario", apellido1Usuario);
            comando.Parameters.AddWithValue("@apellido2Usuario", apellido2Usuario);
            comando.Parameters.AddWithValue("@edadUsuario", edadUsuario);
            comando.Parameters.AddWithValue("@TelefonoUsuario", TelefonoUsuario);
            comando.Parameters.AddWithValue("@direccionUsuario", direccionUsuario);
            comando.Parameters.AddWithValue("@idRol", idRol);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            // METODO A BASE DE DATOS QUE CREARA EL CLIENTE 

        }




        public void agregarEmpleado(String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, int edadUsuario, int TelefonoUsuario, String direccionUsuario, int idRol)
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "agregarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@passUsuario", passUsuario);
            comando.Parameters.AddWithValue("@usernameUsuario", usernameUsuario);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@apellido1Usuario", apellido1Usuario);
            comando.Parameters.AddWithValue("@apellido2Usuario", apellido2Usuario);
            comando.Parameters.AddWithValue("@edadUsuario", edadUsuario);
            comando.Parameters.AddWithValue("@TelefonoUsuario", TelefonoUsuario);
            comando.Parameters.AddWithValue("@direccionUsuario", direccionUsuario);
            comando.Parameters.AddWithValue("@idRol", idRol);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            // METODO A BASE DE DATOS QUE CREARA EL CLIENTE 

        }



        public void editarCliente(int idUsuario, String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, int edadUsuario, int telefonoUsuario, String direccionUsuario)
        {

            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "editaCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@passUsuario", passUsuario);
            comando.Parameters.AddWithValue("@usernameUsuario", usernameUsuario);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@apellido1Usuario", apellido1Usuario);
            comando.Parameters.AddWithValue("@apellido2Usuario", apellido2Usuario);
            comando.Parameters.AddWithValue("@edadUsuario", edadUsuario);
            comando.Parameters.AddWithValue("@telefonoUsuario", telefonoUsuario);
            comando.Parameters.AddWithValue("@direccionUsuario", direccionUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }

        public void eliminarCliente(int idUsuario)
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "eliminaCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }


        public DataTable globalEmpleados()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "verEmpleados";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }



        public void editarEmpleado(int idUsuario, String passUsuario, String usernameUsuario, String nombreUsuario, String apellido1Usuario, String apellido2Usuario, int edadUsuario, int telefonoUsuario, String direccionUsuario)
        {

            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "editaEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@passUsuario", passUsuario);
            comando.Parameters.AddWithValue("@usernameUsuario", usernameUsuario);
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@apellido1Usuario", apellido1Usuario);
            comando.Parameters.AddWithValue("@apellido2Usuario", apellido2Usuario);
            comando.Parameters.AddWithValue("@edadUsuario", edadUsuario);
            comando.Parameters.AddWithValue("@telefonoUsuario", telefonoUsuario);
            comando.Parameters.AddWithValue("@direccionUsuario", direccionUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }

        public void eliminarEmpleado(int idUsuario)
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "eliminaEmpleado";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idUsuario", idUsuario);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }



        public DataTable mostrarPrestamos(int idUsuario)
        {


            comando.Connection = cn.AbrirConexion();
            // SqlCommand cmd = new SqlCommand("verPaquete", cn.conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "misPrestamos";
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            //comando.CommandType = CommandType.StoredProcedure;

            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }

        public void agregarCuenta(DateTime fechaCreacion, DateTime fechaCancelacion, String estadoCuenta, int idUsuario, int idRol, String DetalleCuenta)
        {
            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "agregarCuenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaCreacion", fechaCreacion);
            comando.Parameters.AddWithValue("@fechaCancelacion", fechaCancelacion);
            comando.Parameters.AddWithValue("@estadoCuenta", estadoCuenta);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.Parameters.AddWithValue("@idRol", idRol);
            comando.Parameters.AddWithValue("@DetalleCuenta", DetalleCuenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            // METODO A BASE DE DATOS QUE CREARA EL EMPLEADO





        }


        public DataTable globalPrestamos()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "globalPrestamos";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }



        public void editarCuenta(int idCuenta, String estadoCuenta)
        {

            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "modificarCuenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuenta", idCuenta);
            comando.Parameters.AddWithValue("@estadoCuenta", estadoCuenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }





        public void eliminarCuenta(int idCuenta)
        {

            comando.Connection = cn.AbrirConexion();
            comando.CommandText = "eliminarCuenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCuenta", idCuenta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable cuentaActivo()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "cuentaActivo";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }


        public DataTable cuentaFinalizado()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "cuentaFinalizado";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }
        public DataTable cuentaAtrasado()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "cuentaAtrasado";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }
        public DataTable cuentaCobro()
        {


            comando.Connection = cn.AbrirConexion();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "cuentaJudicial";
            lectura = comando.ExecuteReader();
            comando.Parameters.Clear();

            tabla.Load(lectura);
            cn.cerrarConexion();
            return tabla;

        }











    }
}
