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
    public partial class Guias : Form
    {
        public Guias()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Guias_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManVehiculo manVehiculo = new ManVehiculo();
            manVehiculo.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManConductor manconductor = new ManConductor();
            manconductor.Show();
        }

        private void Nuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrdenNueva ordenNueva = new OrdenNueva();
            ordenNueva.Show();
        }
    }
}
