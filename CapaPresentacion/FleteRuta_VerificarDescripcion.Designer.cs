namespace CapaPresentacion
{
    partial class FleteRuta_VerificarDescripcion
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
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnInsertarRuta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionRuta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRutas
            // 
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(12, 167);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.ReadOnly = true;
            this.dgvRutas.Size = new System.Drawing.Size(752, 303);
            this.dgvRutas.TabIndex = 14;
            this.dgvRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(493, 476);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 75);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnInsertarRuta
            // 
            this.btnInsertarRuta.Location = new System.Drawing.Point(248, 476);
            this.btnInsertarRuta.Name = "btnInsertarRuta";
            this.btnInsertarRuta.Size = new System.Drawing.Size(75, 75);
            this.btnInsertarRuta.TabIndex = 12;
            this.btnInsertarRuta.Text = "Guardar";
            this.btnInsertarRuta.UseVisualStyleBackColor = true;
            this.btnInsertarRuta.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescripcionRuta);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 149);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Descripcion de la Ruta";
            // 
            // txtDescripcionRuta
            // 
            this.txtDescripcionRuta.Location = new System.Drawing.Point(188, 26);
            this.txtDescripcionRuta.Multiline = true;
            this.txtDescripcionRuta.Name = "txtDescripcionRuta";
            this.txtDescripcionRuta.Size = new System.Drawing.Size(400, 70);
            this.txtDescripcionRuta.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(376, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Formato: [ORIGEN][espacio][-][espacio][DESTINO]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion de la Ruta:";
            // 
            // FleteRuta_VerificarDescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnInsertarRuta);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FleteRuta_VerificarDescripcion";
            this.Text = "FleteRuta Verificar Ingreso de Descripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnInsertarRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionRuta;
    }
}