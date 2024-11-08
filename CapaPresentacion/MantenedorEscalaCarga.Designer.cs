namespace CapaPresentacion
{
    partial class MantenedorEscalaCarga
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbListaClientes = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.cmbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.gbDatos.SuspendLayout();
            this.gbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1044, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(938, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 29);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(832, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnActualizar);
            this.gbDatos.Controls.Add(this.cbEstado);
            this.gbDatos.Controls.Add(this.btnRegresar);
            this.gbDatos.Controls.Add(this.btnAgregar);
            this.gbDatos.Controls.Add(this.txtRazonSocial);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.txtId);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(499, 79);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(673, 537);
            this.gbDatos.TabIndex = 18;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(423, 455);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 29);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Modificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(423, 39);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEstado.Size = new System.Drawing.Size(72, 23);
            this.cbEstado.TabIndex = 29;
            this.cbEstado.Text = "Activo";
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(529, 455);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(317, 455);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 29);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(136, 80);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(508, 27);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escala (T.M.):";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(136, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 27);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // gbListaClientes
            // 
            this.gbListaClientes.Controls.Add(this.btnBuscarCliente);
            this.gbListaClientes.Controls.Add(this.dgvListaClientes);
            this.gbListaClientes.Controls.Add(this.cmbBuscarCliente);
            this.gbListaClientes.Location = new System.Drawing.Point(28, 79);
            this.gbListaClientes.Name = "gbListaClientes";
            this.gbListaClientes.Size = new System.Drawing.Size(453, 537);
            this.gbListaClientes.TabIndex = 16;
            this.gbListaClientes.TabStop = false;
            this.gbListaClientes.Text = "Lista de Escalas de Carga";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(121, 63);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(68, 29);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvListaClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(10, 100);
            this.dgvListaClientes.MultiSelect = false;
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaClientes.Size = new System.Drawing.Size(410, 383);
            this.dgvListaClientes.TabIndex = 2;
            // 
            // cmbBuscarCliente
            // 
            this.cmbBuscarCliente.FormattingEnabled = true;
            this.cmbBuscarCliente.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbBuscarCliente.Location = new System.Drawing.Point(10, 65);
            this.cmbBuscarCliente.Name = "cmbBuscarCliente";
            this.cmbBuscarCliente.Size = new System.Drawing.Size(105, 27);
            this.cmbBuscarCliente.TabIndex = 1;
            this.cmbBuscarCliente.Text = "(Todas)";
            // 
            // MantenedorEscalaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbListaClientes);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorEscalaCarga";
            this.Text = "Mantenimiento de Escalas de Carga";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbListaClientes;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.ComboBox cmbBuscarCliente;
    }
}