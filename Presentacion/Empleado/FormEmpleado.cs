using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Empleado
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void crearPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_Prestamo edita = new Editar_Prestamo();
            edita.Show();
        }

        private void verPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global_Prestamos global = new Global_Prestamos();
            global.Show();
        }

        private void filtrarPorActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activo activo = new Activo();
            activo.Show();
        }

        private void filtrarPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atrasado atrasado = new Atrasado();
            atrasado.Show();
        }

        private void filtrarPorFinalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Finalizado final = new Finalizado();
            final.Show();

        }

        private void filtrarPorCobroJudicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobro_Judicial cobro = new Cobro_Judicial();
            cobro.Show();

        }
    }
}
