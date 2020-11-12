using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Negocio
{
    public class Prestamo
    {

        ProcesoTransaccion presta = new ProcesoTransaccion();

        int idRol = 3;

        public DataTable mostrarPrestamos(int d)
        {


            DataTable tabla = new DataTable();
            tabla = presta.mostrarPrestamos(d);
            return tabla;


        }



        public void agregarPaquete(String fechaCreacion, String fechaCancelacion, String estadoCuenta, String idUsuario, String DetalleCuenta)
        {



            presta.agregarCuenta(Convert.ToDateTime(fechaCreacion),Convert.ToDateTime(fechaCancelacion),estadoCuenta,Convert.ToInt32(idUsuario),idRol,DetalleCuenta);





        }





        public DataTable mostrarPrestamos()
        {
            DataTable tabla = new DataTable();
            tabla = presta.globalPrestamos();
            return tabla;

        }

        public void editarCuenta(String idCuenta, String estadoCuenta)
        {


            presta.editarCuenta(Convert.ToInt32(idCuenta), estadoCuenta);



        }




        public void eliminaCuenta(String id)
        {



            presta.eliminarCuenta(Convert.ToInt32(id));


        }



        public DataTable mostrarActivo()
        {
            DataTable tabla = new DataTable();
            tabla = presta.cuentaActivo();
            return tabla;

        }


        public DataTable mostrarAtrasado()
        {
            DataTable tabla = new DataTable();
            tabla = presta.cuentaAtrasado();
            return tabla;

        }

        public DataTable mostrarFinalizado()
        {
            DataTable tabla = new DataTable();
            tabla = presta.cuentaFinalizado();
            return tabla;

        }

        public DataTable mostrarCobro()
        {
            DataTable tabla = new DataTable();
            tabla = presta.cuentaCobro();
            return tabla;

        }





    }
}
