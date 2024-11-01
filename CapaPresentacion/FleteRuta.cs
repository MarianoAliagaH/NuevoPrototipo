using CapaEntidad;
using CapaLogicaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FleteRuta : Form
    {
        public FleteRuta(int idCliente)
        {
            InitializeComponent();
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

            lblIdMasRazonSocial.Text = idCliente.ToString();
            ObtenerInformacionCliente();
            this.Text = "Fletes por Ruta de Cliente[" + idCliente + "]";
        }
        public void SetRuta(string ruta)
        {
            txtRutaSeleccionada.Text = ruta;
        }
        public void ObtenerInformacionCliente()
        {
            try
            {
                entCliente c = logCliente.Instancia.InformacionClienteID(Convert.ToInt32(lblIdMasRazonSocial.Text));
                if (c != null)
                {
                    lblIdMasRazonSocial.Text = c.RazonSocial;
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
                /*
                try
                {
                    entFlete c = new entFlete
                    {
                        RutaId = txtRutaSeleccionada.Text.Trim(),
                        RUC = txtRUC.Text.Trim(),
                        IdTipoPersona = cmbTipoPersona.SelectedIndex,
                        Telefono = txtTelefono.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Ubigeo = txtUbigeo.Text.Trim(),
                        Estado = cbEstado.Checked
                    };

                    if (c.IdTipoPersona == 0)
                    {
                        MessageBox.Show("Seleccione Tipo Persona");
                        return;
                    }

                    bool resultado = logCliente.Instancia.InsertarCliente(c);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente guardado exitosamente.");
                        LimpiarControles();
                        //gbDatos.Enabled = false;
                        ListarClientes();
                        ConfigurarControlesInicial();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar el cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }*/
            }
            else
            {
                MessageBox.Show("Llena todos los campos");
            }
        }
    }
}
