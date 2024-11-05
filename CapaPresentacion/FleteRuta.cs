using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FleteRuta : Form
    {
        private int idClienteSeleccionado;
        public FleteRuta(int idCliente)
        {
            InitializeComponent();
            idClienteSeleccionado = idCliente;
            //txtFleteRetornoMonto.TextChanged += txtFleteRetornoMonto_TextChanged;
            //txtFletePorcentajeRetorno.TextChanged += txtFletePorcentajeRetorno_TextChanged;
            txtFleteRetornoMonto.Text = "0,00";
            txtFletePorcentajeRetorno.Text = "0,00";

            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            //lblRazonSocial.Text = idCliente.ToString();
            ObtenerInformacionCliente();
            this.Text = "Fletes por Ruta de Cliente[" + idCliente + "]";
            ListarFletes();
        }

        private void ListarFletes()
        {
            dgvFletesAsignados.DataSource = logFlete.Instancia.ListarRutas(idClienteSeleccionado);
        }
        public void SetRuta(string ruta)
        {
            txtRutaSeleccionada.Text = ruta;
        }
        private void ObtenerInformacionCliente()
        {
            try
            {
                entCliente c = logCliente.Instancia.InformacionClienteID(idClienteSeleccionado);
                if (c != null)
                {
                    lblRazonSocial.Text = c.RazonSocial;
                    lblRUC.Text = c.RUC;
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            FleteRuta_VerificarDescripcion FleteRuta_VerificarDescripcion = new FleteRuta_VerificarDescripcion(this);
            FleteRuta_VerificarDescripcion.Show();
        }

        private void btnAgregarFleteRutaNuevo_Click(object sender, EventArgs e)
        {
            
            int val = 0;
            if (txtRutaSeleccionada.Text == "")
            {
                val++;
            }
            if (txtFleteMonto.Text == "")
            {
                val++;
            }
            if (cmbTipoServicio.SelectedIndex==0)
            {
                val++;
            }
            if (val == 0)
            {
                try
                {
                    entFlete f = new entFlete
                    {
                        ClienteId = idClienteSeleccionado,
                        DescripcionRuta = txtRutaSeleccionada.Text.Trim(),
                        Monto = Convert.ToInt32(txtFleteMonto.Text.Trim()),
                        ValorFleteRetorno = Convert.ToSingle(txtFletePorcentajeRetorno.Text.Trim()),
                        MontoFleteRetorno=Convert.ToDecimal(txtFleteRetornoMonto.Text.Trim()),
                        TipoServicio = cmbTipoServicio.SelectedItem.ToString(),
                        //Activo = true, -- Activo tiene como default true en el sp
                    };

                    bool resultado = logFlete.Instancia.AsignarFlete(f);

                    if (resultado)
                    {
                        MessageBox.Show("Flete asignado exitosamente a Cliente.[" + idClienteSeleccionado + "]");
                        //LimpiarControles();
                        //gbDatos.Enabled = false;
                        //ListarClientes();
                        //ConfigurarControlesInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Llena todos los campos");
            }
        }
    }
}
