using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        public SqlConnection conexion = new SqlConnection("data source = LAPTOPKENNETH; initial catalog = DB_proyecto_2; user id = administrador; password = admin123");



        public SqlConnection AbrirConexion()
        {

            if (conexion.State == ConnectionState.Closed)

                conexion.Open();

            return conexion;
        }

        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)

                conexion.Close();

            return conexion;

        }


    }
}
