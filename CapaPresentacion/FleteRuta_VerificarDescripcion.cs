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
    public partial class FleteRuta_VerificarDescripcion : Form
    {
        private FleteRuta _fleteRuta;
        public FleteRuta_VerificarDescripcion(FleteRuta fleteRuta)
        {
            InitializeComponent();
            _fleteRuta = fleteRuta;
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            ListarRutas();
        }
        public void ListarRutas()
        {
            dgvRutas.DataSource = logRuta.Instancia.ListarRutas();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int val = 0;
            if (txtDescripcionRuta.Text == "")
            {
                val++;
                MessageBox.Show("Ingresa Descripcion de Ruta");
            }
            if (val==0)
            {
                try
                {
                    entRuta r = new entRuta()
                    {
                        Ruta = txtDescripcionRuta.Text.ToUpper().Trim()
                    };

                    bool resultado = logRuta.Instancia.InsertaRuta(r);
                    if (resultado)
                    {
                        MessageBox.Show("Ruta guardada exitosamente.");
                        txtDescripcionRuta.Text = "";
                        ListarRutas();
                        //ConfigurarControlesInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar la ruta.");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRutas.Rows[e.RowIndex];
                string ruta = fila.Cells[2].Value.ToString(); // Obtener el valor de la columna en la posición 2
                _fleteRuta.SetRuta(ruta); // Llamar al método para establecer el valor en el TextBox
                //this.Close();
                //txtId.Text = idClienteSeleccionado.ToString();
            }
        }
    }
}
