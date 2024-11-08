namespace CapaPresentacion
{
    partial class pagarFactura
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
            this.bCancelarFactura = new System.Windows.Forms.Button();
            this.bGrabar = new System.Windows.Forms.Button();
            this.lblDatosFac = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dTPFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBVRef = new System.Windows.Forms.TextBox();
            this.txtBSerie = new System.Windows.Forms.TextBox();
            this.txtBTotal = new System.Windows.Forms.TextBox();
            this.txtBMontoIGV = new System.Windows.Forms.TextBox();
            this.txtBIGV = new System.Windows.Forms.TextBox();
            this.txtBSubtotal = new System.Windows.Forms.TextBox();
            this.txtBCliente = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblVRef = new System.Windows.Forms.Label();
            this.lblMontoIGV = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.dTPFechadePago = new System.Windows.Forms.DateTimePicker();
            this.cBMetpago = new System.Windows.Forms.ComboBox();
            this.lblFechadePago = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblMetdePago = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCancelarFactura
            // 
            this.bCancelarFactura.Location = new System.Drawing.Point(595, 404);
            this.bCancelarFactura.Name = "bCancelarFactura";
            this.bCancelarFactura.Size = new System.Drawing.Size(119, 23);
            this.bCancelarFactura.TabIndex = 10;
            this.bCancelarFactura.Text = "CancelarFactura";
            this.bCancelarFactura.UseVisualStyleBackColor = true;
            // 
            // bGrabar
            // 
            this.bGrabar.Location = new System.Drawing.Point(205, 404);
            this.bGrabar.Name = "bGrabar";
            this.bGrabar.Size = new System.Drawing.Size(75, 23);
            this.bGrabar.TabIndex = 9;
            this.bGrabar.Text = "Grabar";
            this.bGrabar.UseVisualStyleBackColor = true;
            // 
            // lblDatosFac
            // 
            this.lblDatosFac.AutoSize = true;
            this.lblDatosFac.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosFac.Location = new System.Drawing.Point(16, -1);
            this.lblDatosFac.Name = "lblDatosFac";
            this.lblDatosFac.Size = new System.Drawing.Size(167, 19);
            this.lblDatosFac.TabIndex = 7;
            this.lblDatosFac.Text = "Datos de la Factura";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dTPFecha);
            this.panel1.Controls.Add(this.txtBVRef);
            this.panel1.Controls.Add(this.txtBSerie);
            this.panel1.Controls.Add(this.txtBTotal);
            this.panel1.Controls.Add(this.txtBMontoIGV);
            this.panel1.Controls.Add(this.txtBIGV);
            this.panel1.Controls.Add(this.txtBSubtotal);
            this.panel1.Controls.Add(this.txtBCliente);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblSerie);
            this.panel1.Controls.Add(this.lblVRef);
            this.panel1.Controls.Add(this.lblMontoIGV);
            this.panel1.Controls.Add(this.lblIGV);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblInfoPago);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 352);
            this.panel1.TabIndex = 8;
            // 
            // dTPFecha
            // 
            this.dTPFecha.CustomFormat = "dd-MM-yyyy";
            this.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFecha.Location = new System.Drawing.Point(95, 9);
            this.dTPFecha.Name = "dTPFecha";
            this.dTPFecha.Size = new System.Drawing.Size(113, 27);
            this.dTPFecha.TabIndex = 18;
            // 
            // txtBVRef
            // 
            this.txtBVRef.Location = new System.Drawing.Point(551, 147);
            this.txtBVRef.Name = "txtBVRef";
            this.txtBVRef.Size = new System.Drawing.Size(100, 27);
            this.txtBVRef.TabIndex = 17;
            // 
            // txtBSerie
            // 
            this.txtBSerie.Location = new System.Drawing.Point(689, 7);
            this.txtBSerie.Name = "txtBSerie";
            this.txtBSerie.Size = new System.Drawing.Size(100, 27);
            this.txtBSerie.TabIndex = 16;
            // 
            // txtBTotal
            // 
            this.txtBTotal.Location = new System.Drawing.Point(732, 83);
            this.txtBTotal.Multiline = true;
            this.txtBTotal.Name = "txtBTotal";
            this.txtBTotal.Size = new System.Drawing.Size(144, 41);
            this.txtBTotal.TabIndex = 15;
            // 
            // txtBMontoIGV
            // 
            this.txtBMontoIGV.Location = new System.Drawing.Point(541, 91);
            this.txtBMontoIGV.Name = "txtBMontoIGV";
            this.txtBMontoIGV.Size = new System.Drawing.Size(100, 27);
            this.txtBMontoIGV.TabIndex = 14;
            // 
            // txtBIGV
            // 
            this.txtBIGV.Location = new System.Drawing.Point(305, 91);
            this.txtBIGV.Name = "txtBIGV";
            this.txtBIGV.Size = new System.Drawing.Size(100, 27);
            this.txtBIGV.TabIndex = 13;
            // 
            // txtBSubtotal
            // 
            this.txtBSubtotal.Location = new System.Drawing.Point(97, 91);
            this.txtBSubtotal.Name = "txtBSubtotal";
            this.txtBSubtotal.Size = new System.Drawing.Size(100, 27);
            this.txtBSubtotal.TabIndex = 12;
            // 
            // txtBCliente
            // 
            this.txtBCliente.Location = new System.Drawing.Point(95, 50);
            this.txtBCliente.Name = "txtBCliente";
            this.txtBCliente.Size = new System.Drawing.Size(781, 27);
            this.txtBCliente.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(672, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 23);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total :";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(591, 15);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(92, 19);
            this.lblSerie.TabIndex = 8;
            this.lblSerie.Text = "Serie y N° :";
            // 
            // lblVRef
            // 
            this.lblVRef.AutoSize = true;
            this.lblVRef.Location = new System.Drawing.Point(384, 150);
            this.lblVRef.Name = "lblVRef";
            this.lblVRef.Size = new System.Drawing.Size(161, 19);
            this.lblVRef.TabIndex = 7;
            this.lblVRef.Text = "Valor de Referencial :";
            // 
            // lblMontoIGV
            // 
            this.lblMontoIGV.AutoSize = true;
            this.lblMontoIGV.Location = new System.Drawing.Point(434, 94);
            this.lblMontoIGV.Name = "lblMontoIGV";
            this.lblMontoIGV.Size = new System.Drawing.Size(111, 19);
            this.lblMontoIGV.TabIndex = 6;
            this.lblMontoIGV.Text = "Monto I.G.V. :";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(225, 94);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(83, 19);
            this.lblIGV.TabIndex = 5;
            this.lblIGV.Text = "% I.G.V. :";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(3, 91);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 19);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Sub Total :";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(21, 53);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 19);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(29, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 19);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha :";
            // 
            // lblInfoPago
            // 
            this.lblInfoPago.AutoSize = true;
            this.lblInfoPago.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPago.Location = new System.Drawing.Point(7, 197);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(188, 19);
            this.lblInfoPago.TabIndex = 1;
            this.lblInfoPago.Text = "Imformacion del Pago";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCaracteres);
            this.panel2.Controls.Add(this.dTPFechadePago);
            this.panel2.Controls.Add(this.cBMetpago);
            this.panel2.Controls.Add(this.lblFechadePago);
            this.panel2.Controls.Add(this.lblCaracteres);
            this.panel2.Controls.Add(this.lblMetdePago);
            this.panel2.Location = new System.Drawing.Point(3, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 135);
            this.panel2.TabIndex = 0;
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Location = new System.Drawing.Point(143, 71);
            this.txtCaracteres.Multiline = true;
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(729, 50);
            this.txtCaracteres.TabIndex = 6;
            // 
            // dTPFechadePago
            // 
            this.dTPFechadePago.CustomFormat = "dd-MM-yyyy";
            this.dTPFechadePago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPFechadePago.Location = new System.Drawing.Point(748, 16);
            this.dTPFechadePago.Name = "dTPFechadePago";
            this.dTPFechadePago.Size = new System.Drawing.Size(106, 27);
            this.dTPFechadePago.TabIndex = 5;
            this.dTPFechadePago.Value = new System.DateTime(2024, 10, 27, 13, 31, 18, 0);
            // 
            // cBMetpago
            // 
            this.cBMetpago.FormattingEnabled = true;
            this.cBMetpago.Location = new System.Drawing.Point(143, 16);
            this.cBMetpago.Name = "cBMetpago";
            this.cBMetpago.Size = new System.Drawing.Size(141, 27);
            this.cBMetpago.TabIndex = 3;
            // 
            // lblFechadePago
            // 
            this.lblFechadePago.AutoSize = true;
            this.lblFechadePago.Location = new System.Drawing.Point(620, 19);
            this.lblFechadePago.Name = "lblFechadePago";
            this.lblFechadePago.Size = new System.Drawing.Size(122, 19);
            this.lblFechadePago.TabIndex = 2;
            this.lblFechadePago.Text = "Fecha de pago :";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Location = new System.Drawing.Point(3, 74);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(139, 38);
            this.lblCaracteres.TabIndex = 1;
            this.lblCaracteres.Text = "Detalle del Pago : \r\n(Min. 15 caract.)\r\n";
            // 
            // lblMetdePago
            // 
            this.lblMetdePago.AutoSize = true;
            this.lblMetdePago.Location = new System.Drawing.Point(3, 16);
            this.lblMetdePago.Name = "lblMetdePago";
            this.lblMetdePago.Size = new System.Drawing.Size(134, 19);
            this.lblMetdePago.TabIndex = 0;
            this.lblMetdePago.Text = "Metodo de Pago :";
            // 
            // pagarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 438);
            this.Controls.Add(this.bCancelarFactura);
            this.Controls.Add(this.bGrabar);
            this.Controls.Add(this.lblDatosFac);
            this.Controls.Add(this.panel1);
            this.Name = "pagarFactura";
            this.Text = "pagarFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancelarFactura;
        private System.Windows.Forms.Button bGrabar;
        private System.Windows.Forms.Label lblDatosFac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dTPFecha;
        private System.Windows.Forms.TextBox txtBVRef;
        private System.Windows.Forms.TextBox txtBSerie;
        private System.Windows.Forms.TextBox txtBTotal;
        private System.Windows.Forms.TextBox txtBMontoIGV;
        private System.Windows.Forms.TextBox txtBIGV;
        private System.Windows.Forms.TextBox txtBSubtotal;
        private System.Windows.Forms.TextBox txtBCliente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblVRef;
        private System.Windows.Forms.Label lblMontoIGV;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblInfoPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.DateTimePicker dTPFechadePago;
        private System.Windows.Forms.ComboBox cBMetpago;
        private System.Windows.Forms.Label lblFechadePago;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblMetdePago;
    }
}