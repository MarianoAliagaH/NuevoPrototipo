namespace CapaPresentacion
{
    partial class Sistema
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiConductores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLicencias = new System.Windows.Forms.ToolStripMenuItem();
            this.vencimientosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarFacturasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guiasDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.almacenToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1424, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClientes,
            this.tsmiProveedores,
            this.toolStripSeparator1,
            this.tsmiConductores,
            this.tsmiVehiculos,
            this.toolStripSeparator2,
            this.tsmiLicencias,
            this.vencimientosGeneralesToolStripMenuItem,
            this.toolStripSeparator3,
            this.tsmiCerrarSesion,
            this.tsmiSalir});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(97, 19);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(204, 22);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiProveedores
            // 
            this.tsmiProveedores.Name = "tsmiProveedores";
            this.tsmiProveedores.Size = new System.Drawing.Size(204, 22);
            this.tsmiProveedores.Text = "Proveedores";
            this.tsmiProveedores.Click += new System.EventHandler(this.tsmiProveedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiConductores
            // 
            this.tsmiConductores.Name = "tsmiConductores";
            this.tsmiConductores.Size = new System.Drawing.Size(204, 22);
            this.tsmiConductores.Text = "Conductores";
            this.tsmiConductores.Click += new System.EventHandler(this.tsmiConductores_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(204, 22);
            this.tsmiVehiculos.Text = "Vehiculos";
            this.tsmiVehiculos.Click += new System.EventHandler(this.tsmiVehiculos_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiLicencias
            // 
            this.tsmiLicencias.Name = "tsmiLicencias";
            this.tsmiLicencias.Size = new System.Drawing.Size(204, 22);
            this.tsmiLicencias.Text = "Licencias";
            // 
            // vencimientosGeneralesToolStripMenuItem
            // 
            this.vencimientosGeneralesToolStripMenuItem.Name = "vencimientosGeneralesToolStripMenuItem";
            this.vencimientosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.vencimientosGeneralesToolStripMenuItem.Text = "Vencimientos Generales";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(204, 22);
            this.tsmiCerrarSesion.Text = "Cerrar Sesion";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(204, 22);
            this.tsmiSalir.Text = "Salir del Sistema";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrdenes,
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem,
            this.toolStripSeparator4,
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem,
            this.toolStripSeparator5,
            this.facturasToolStripMenuItem,
            this.procesarFacturasPorClienteToolStripMenuItem,
            this.guiasDeTransporteToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(86, 19);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // tsmiOrdenes
            // 
            this.tsmiOrdenes.Name = "tsmiOrdenes";
            this.tsmiOrdenes.Size = new System.Drawing.Size(296, 22);
            this.tsmiOrdenes.Text = "Ordenes";
            this.tsmiOrdenes.Click += new System.EventHandler(this.tsmiOrdenes_Click_1);
            // 
            // procesarOrdenesDeTrabajoPorClienteToolStripMenuItem
            // 
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Name = "procesarOrdenesDeTrabajoPorClienteToolStripMenuItem";
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.procesarOrdenesDeTrabajoPorClienteToolStripMenuItem.Text = "Procesar Ordenes de Trabajo por Cliente";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(293, 6);
            // 
            // ordenesDeTrabajoParaAutorizacionToolStripMenuItem
            // 
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Name = "ordenesDeTrabajoParaAutorizacionToolStripMenuItem";
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.ordenesDeTrabajoParaAutorizacionToolStripMenuItem.Text = "Ordenes de Trabajo para Autorizacion";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(293, 6);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // procesarFacturasPorClienteToolStripMenuItem
            // 
            this.procesarFacturasPorClienteToolStripMenuItem.Name = "procesarFacturasPorClienteToolStripMenuItem";
            this.procesarFacturasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.procesarFacturasPorClienteToolStripMenuItem.Text = "Procesar Facturas por Cliente";
            // 
            // guiasDeTransporteToolStripMenuItem
            // 
            this.guiasDeTransporteToolStripMenuItem.Name = "guiasDeTransporteToolStripMenuItem";
            this.guiasDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.guiasDeTransporteToolStripMenuItem.Text = "Guias de Transporte";
            this.guiasDeTransporteToolStripMenuItem.Click += new System.EventHandler(this.guiasDeTransporteToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.almacenToolStripMenuItem.Text = "Almacen";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 19);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.Text = "Sistema para Transportes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiProveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiConductores;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem vencimientosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLicencias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrdenes;
        private System.Windows.Forms.ToolStripMenuItem procesarOrdenesDeTrabajoPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoParaAutorizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarFacturasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guiasDeTransporteToolStripMenuItem;
    }
}

