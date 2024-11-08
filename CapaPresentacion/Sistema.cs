using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            MantenedorCliente manCliente = new MantenedorCliente();
            manCliente.Show();
        }

        private void tsmiProveedores_Click(object sender, EventArgs e)
        {
            ManProveedor manProveedor = new ManProveedor();
            manProveedor.Show();
        }

        private void tsmiConductores_Click(object sender, EventArgs e)
        {
            ManConductor manConductor = new ManConductor();
            manConductor.Show();
        }


        private void tsmiOrdenes_Click_1(object sender, EventArgs e)
        {
            ManOrden ordenes = new ManOrden();
            ordenes.Show();
        }

        private void guiasDeTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guias guias = new Guias();
            guias.Show();
        }

        private void tsmiVehiculos_Click(object sender, EventArgs e)
        {
            ManVehiculo manVehiculo = new ManVehiculo();
            manVehiculo.Show();
        }
    }
}
