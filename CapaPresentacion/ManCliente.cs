using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaEntidad;
using System;

namespace CapaPresentacion
{
    public partial class ManCliente : Form
    {
        private int idClienteSeleccionado;
        public ManCliente()
        {
            InitializeComponent();
            // Establece la posición inicial del formulario en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            // Desactiva la capacidad de maximizar el formulario
            this.MaximizeBox = false;

            // Establece el estilo del borde del formulario para que sea un cuadro de diálogo fijo
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            ListarClientes();
            //gbDatos.Enabled = false;
            //cmbTipoPersona.SelectedIndex = 0;
            ConfigurarControlesInicial();
        }
        public void ListarClientes()
        {
            dgvListaClientes.DataSource = logCliente.Instancia.ListarClientes();
            /*
            var clientes = logCliente.Instancia.ListarClientes();
            dgvListaClientes.DataSource = clientes;

            // Configurar las columnas visibles
            dgvListaClientes.Columns.Clear();
            dgvListaClientes.AutoGenerateColumns = false;

            dgvListaClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID"
            });
            dgvListaClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RazonSocial",
                HeaderText = "Razón Social"
            });
            dgvListaClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Domicio Fiscal"
            });
            dgvListaClientes.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });*/

        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
            LimpiarControles();

            txtRazonSocial.Focus();
            ConfigurarControlesNuevo();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            try
            {
                entCliente c = new entCliente
                {
                    RazonSocial = txtRazonSocial.Text.Trim(),
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
            }
        }

        private void dgvListaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvListaClientes.Rows[e.RowIndex];
                idClienteSeleccionado = Convert.ToInt32(fila.Cells[0].Value);
                txtId.Text = idClienteSeleccionado.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado > 0)
            {
                gbDatos.Enabled = true;
                txtId.Enabled = false;
                ConfigurarBotonesEditar();
                try
                {
                    entCliente c = logCliente.Instancia.InformacionClienteID(idClienteSeleccionado);
                    if (c != null)
                    {
                        //txtId.Text = c.Id.ToString();
                        txtRazonSocial.Text = c.RazonSocial;
                        txtRUC.Text = c.RUC;
                        cmbTipoPersona.SelectedIndex = c.IdTipoPersona;
                        txtDireccion.Text = c.Direccion;
                        txtTelefono.Text = c.Telefono;
                        txtCorreo.Text = c.Correo;
                        cbEstado.Checked = c.Estado;
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
            else
            {
                MessageBox.Show("Selecciona un cliente de la lista primero");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente
                {
                    Id = int.Parse(txtId.Text.Trim()),
                    RazonSocial = txtRazonSocial.Text.Trim(),
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

                bool resultado = logCliente.Instancia.EditarCliente(c);

                if (resultado)
                {
                    MessageBox.Show("Cliente modificado exitosamente.");
                    //gbDatos.Enabled = false;
                    idClienteSeleccionado = 0;
                    ConfigurarControlesInicial();
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LimpiarControles();
            ListarClientes();
        }
        private void ConfigurarControlesInicial()
        {
            LimpiarControles();
            gbListaClientes.Enabled = true;
            gbDatos.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void ConfigurarControlesNuevo()
        {
            gbDatos.Enabled = true;
            gbListaClientes.Enabled = false;
            txtId.Enabled = false;
            cbEstado.Checked = true;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            //btnConsultaExterna.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private void ConfigurarBotonesEditar()
        {
            gbListaClientes.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnConsultaExterna.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
        }

        public void LimpiarControles()
        {
            idClienteSeleccionado = 0;
            txtId.Text = "";
            txtRazonSocial.Text = "";
            txtRUC.Text = "";
            cmbTipoPersona.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtUbigeo.Text = "";
            cbEstado.Checked = false;
        }

        private void ManCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ConfigurarControlesInicial();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarFlete_Click(object sender, EventArgs e)
        {
            FleteRuta fleteRuta = new FleteRuta(idClienteSeleccionado);
            fleteRuta.Show();
        }
    }
}
