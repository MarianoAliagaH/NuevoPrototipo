namespace CapaPresentacion
{
    partial class FleteRuta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregarFleteRutaNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRUC = new System.Windows.Forms.Label();
            this.lblIdMasRazonSocial = new System.Windows.Forms.Label();
            this.lblNumRUC = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFletePorcentajeRetorno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFleteRetornoMonto = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtFleteMonto = new System.Windows.Forms.TextBox();
            this.txtRutaSeleccionada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1001, 315);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.btnAgregarFleteRutaNuevo);
            this.groupBox2.Location = new System.Drawing.Point(1019, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 312);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(52, 118);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 75);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregarFleteRutaNuevo
            // 
            this.btnAgregarFleteRutaNuevo.Location = new System.Drawing.Point(52, 26);
            this.btnAgregarFleteRutaNuevo.Name = "btnAgregarFleteRutaNuevo";
            this.btnAgregarFleteRutaNuevo.Size = new System.Drawing.Size(86, 75);
            this.btnAgregarFleteRutaNuevo.TabIndex = 1;
            this.btnAgregarFleteRutaNuevo.Text = "Agregar Flete por Ruta";
            this.btnAgregarFleteRutaNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarFleteRutaNuevo.Click += new System.EventHandler(this.btnAgregarFleteRutaNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRUC);
            this.groupBox1.Controls.Add(this.lblIdMasRazonSocial);
            this.groupBox1.Controls.Add(this.lblNumRUC);
            this.groupBox1.Controls.Add(this.lblDatosCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Location = new System.Drawing.Point(758, 23);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(40, 19);
            this.lblRUC.TabIndex = 4;
            this.lblRUC.Text = "RUC";
            // 
            // lblIdMasRazonSocial
            // 
            this.lblIdMasRazonSocial.AutoSize = true;
            this.lblIdMasRazonSocial.Location = new System.Drawing.Point(111, 23);
            this.lblIdMasRazonSocial.Name = "lblIdMasRazonSocial";
            this.lblIdMasRazonSocial.Size = new System.Drawing.Size(117, 19);
            this.lblIdMasRazonSocial.TabIndex = 2;
            this.lblIdMasRazonSocial.Text = "Id_RazonSocial";
            // 
            // lblNumRUC
            // 
            this.lblNumRUC.AutoSize = true;
            this.lblNumRUC.Location = new System.Drawing.Point(646, 23);
            this.lblNumRUC.Name = "lblNumRUC";
            this.lblNumRUC.Size = new System.Drawing.Size(90, 19);
            this.lblNumRUC.TabIndex = 1;
            this.lblNumRUC.Text = "R.U.C. Nº :";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Location = new System.Drawing.Point(6, 23);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(63, 19);
            this.lblDatosCliente.TabIndex = 0;
            this.lblDatosCliente.Text = "Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerificar);
            this.groupBox3.Controls.Add(this.cmbTipoServicio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtFletePorcentajeRetorno);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFleteRetornoMonto);
            this.groupBox3.Controls.Add(this.txtDistancia);
            this.groupBox3.Controls.Add(this.txtFleteMonto);
            this.groupBox3.Controls.Add(this.txtRutaSeleccionada);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1001, 242);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Flete por Ruta";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(762, 70);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(210, 30);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Items.AddRange(new object[] {
            "(Seleccionar)",
            "TRANSPORTE"});
            this.cmbTipoServicio.Location = new System.Drawing.Point(762, 155);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(210, 27);
            this.cmbTipoServicio.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Servicio:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 27);
            this.comboBox1.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(762, 20);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(210, 27);
            this.textBox8.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(646, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Total Tramos:";
            // 
            // txtFletePorcentajeRetorno
            // 
            this.txtFletePorcentajeRetorno.Location = new System.Drawing.Point(174, 186);
            this.txtFletePorcentajeRetorno.Name = "txtFletePorcentajeRetorno";
            this.txtFletePorcentajeRetorno.Size = new System.Drawing.Size(210, 27);
            this.txtFletePorcentajeRetorno.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "% Flete Retorno:";
            // 
            // txtFleteRetornoMonto
            // 
            this.txtFleteRetornoMonto.Location = new System.Drawing.Point(532, 186);
            this.txtFleteRetornoMonto.Name = "txtFleteRetornoMonto";
            this.txtFleteRetornoMonto.Size = new System.Drawing.Size(210, 27);
            this.txtFleteRetornoMonto.TabIndex = 9;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(532, 130);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(210, 27);
            this.txtDistancia.TabIndex = 8;
            // 
            // txtFleteMonto
            // 
            this.txtFleteMonto.Location = new System.Drawing.Point(174, 130);
            this.txtFleteMonto.Name = "txtFleteMonto";
            this.txtFleteMonto.Size = new System.Drawing.Size(210, 27);
            this.txtFleteMonto.TabIndex = 7;
            // 
            // txtRutaSeleccionada
            // 
            this.txtRutaSeleccionada.Enabled = false;
            this.txtRutaSeleccionada.Location = new System.Drawing.Point(174, 70);
            this.txtRutaSeleccionada.Name = "txtRutaSeleccionada";
            this.txtRutaSeleccionada.Size = new System.Drawing.Size(568, 27);
            this.txtRutaSeleccionada.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto Flete (Ret.):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distancia (Km.) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escala por Carga Util:";
            // 
            // FleteRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FleteRuta";
            this.Text = "Fletes por Ruta de Cliente[]";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregarFleteRutaNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumRUC;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFletePorcentajeRetorno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFleteRetornoMonto;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtFleteMonto;
        private System.Windows.Forms.TextBox txtRutaSeleccionada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label lblIdMasRazonSocial;
    }
}