namespace Vista
{
    partial class FormInicial
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
            btnGestionClientes = new Button();
            btnGestionarProveedores = new Button();
            btnGestionarProductos = new Button();
            btnRegistrarFactura = new Button();
            btnProductosMasVendidos = new Button();
            btnVendidoClienteFecha = new Button();
            btnFacturasEnIntervalo = new Button();
            btnGestionarCategorias = new Button();
            SuspendLayout();
            // 
            // btnGestionClientes
            // 
            btnGestionClientes.Location = new Point(110, 230);
            btnGestionClientes.Name = "btnGestionClientes";
            btnGestionClientes.Size = new Size(137, 23);
            btnGestionClientes.TabIndex = 0;
            btnGestionClientes.Text = "Gestionar Clientes";
            btnGestionClientes.UseVisualStyleBackColor = true;
            btnGestionClientes.Click += btnGestionClientes_Click;
            // 
            // btnGestionarProveedores
            // 
            btnGestionarProveedores.Location = new Point(110, 175);
            btnGestionarProveedores.Name = "btnGestionarProveedores";
            btnGestionarProveedores.Size = new Size(137, 23);
            btnGestionarProveedores.TabIndex = 1;
            btnGestionarProveedores.Text = "Gestionar Proveedores";
            btnGestionarProveedores.UseVisualStyleBackColor = true;
            btnGestionarProveedores.Click += btnGestionarProveedores_Click;
            // 
            // btnGestionarProductos
            // 
            btnGestionarProductos.Location = new Point(110, 275);
            btnGestionarProductos.Name = "btnGestionarProductos";
            btnGestionarProductos.Size = new Size(137, 23);
            btnGestionarProductos.TabIndex = 2;
            btnGestionarProductos.Text = "Gestionar Productos";
            btnGestionarProductos.UseVisualStyleBackColor = true;
            btnGestionarProductos.Click += btnGestionarProductos_Click;
            // 
            // btnRegistrarFactura
            // 
            btnRegistrarFactura.Location = new Point(429, 129);
            btnRegistrarFactura.Name = "btnRegistrarFactura";
            btnRegistrarFactura.Size = new Size(249, 23);
            btnRegistrarFactura.TabIndex = 3;
            btnRegistrarFactura.Text = "Registrar Factura";
            btnRegistrarFactura.UseVisualStyleBackColor = true;
            btnRegistrarFactura.Click += btnRegistrarFactura_Click;
            // 
            // btnProductosMasVendidos
            // 
            btnProductosMasVendidos.Location = new Point(429, 230);
            btnProductosMasVendidos.Name = "btnProductosMasVendidos";
            btnProductosMasVendidos.Size = new Size(249, 23);
            btnProductosMasVendidos.TabIndex = 4;
            btnProductosMasVendidos.Text = "Ver Productos Mas Vendidos";
            btnProductosMasVendidos.UseVisualStyleBackColor = true;
            btnProductosMasVendidos.Click += btnProductosMasVendidos_Click;
            // 
            // btnVendidoClienteFecha
            // 
            btnVendidoClienteFecha.Location = new Point(429, 275);
            btnVendidoClienteFecha.Name = "btnVendidoClienteFecha";
            btnVendidoClienteFecha.Size = new Size(249, 23);
            btnVendidoClienteFecha.TabIndex = 5;
            btnVendidoClienteFecha.Text = "Ver Total Vendido A Cliente en Cierta Fecha";
            btnVendidoClienteFecha.UseVisualStyleBackColor = true;
            btnVendidoClienteFecha.Click += btnVendidoClienteFecha_Click;
            // 
            // btnFacturasEnIntervalo
            // 
            btnFacturasEnIntervalo.Location = new Point(429, 173);
            btnFacturasEnIntervalo.Name = "btnFacturasEnIntervalo";
            btnFacturasEnIntervalo.Size = new Size(249, 27);
            btnFacturasEnIntervalo.TabIndex = 6;
            btnFacturasEnIntervalo.Text = "Ver Facturas en Cierta Fecha";
            btnFacturasEnIntervalo.UseVisualStyleBackColor = true;
            btnFacturasEnIntervalo.Click += btnFacturasEnIntervalo_Click;
            // 
            // btnGestionarCategorias
            // 
            btnGestionarCategorias.Location = new Point(110, 129);
            btnGestionarCategorias.Name = "btnGestionarCategorias";
            btnGestionarCategorias.Size = new Size(137, 23);
            btnGestionarCategorias.TabIndex = 7;
            btnGestionarCategorias.Text = "Gestionar Categorias";
            btnGestionarCategorias.UseVisualStyleBackColor = true;
            btnGestionarCategorias.Click += btnGestionarCategorias_Click;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGestionarCategorias);
            Controls.Add(btnFacturasEnIntervalo);
            Controls.Add(btnVendidoClienteFecha);
            Controls.Add(btnProductosMasVendidos);
            Controls.Add(btnRegistrarFactura);
            Controls.Add(btnGestionarProductos);
            Controls.Add(btnGestionarProveedores);
            Controls.Add(btnGestionClientes);
            Name = "FormInicial";
            Text = "FormInicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionClientes;
        private Button btnGestionarProveedores;
        private Button btnGestionarProductos;
        private Button btnRegistrarFactura;
        private Button btnProductosMasVendidos;
        private Button btnVendidoClienteFecha;
        private Button btnFacturasEnIntervalo;
        private Button btnGestionarCategorias;
    }
}