using CapaEntidad;
using CapaLogicaNegocio;
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
    public partial class OrdenNueva : Form
    {
        public OrdenNueva()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void btnBuscarClienteRUC_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtClienteDatos.Text == "")
            {
                val++;
                MessageBox.Show("Ingresa Cliente");
            }
            if (val == 0)
            {
                string clienteRUC=txtClienteDatos.Text;
                try
                {   
                    entCliente c = logCliente.Instancia.InformacionClienteRUC(clienteRUC);
                    if (c != null)
                    {
                        txtClienteDatos.Text = "("+c.RUC+") "+c.RazonSocial;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la información del cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la información del cliente: " + ex.Message);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
