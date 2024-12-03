namespace Vista.Modulo_1
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnAgregarProducto = new Button();
            btnModificarProducto = new Button();
            btnEliminarProducto = new Button();
            dgvProductosImportados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnAgregarStock = new Button();
            btnDescuento = new Button();
            gBoxProductos = new GroupBox();
            gBoxAgregarStock = new GroupBox();
            btnAceptarStock = new Button();
            btnCancelarStock = new Button();
            labelStock = new Label();
            label3 = new Label();
            txtStockAgregado = new TextBox();
            gBoxDescuento = new GroupBox();
            labelPrecio = new Label();
            label4 = new Label();
            txtDescuento = new TextBox();
            btnAceptarDescuento = new Button();
            btnCancelarDescuento = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).BeginInit();
            gBoxProductos.SuspendLayout();
            gBoxAgregarStock.SuspendLayout();
            gBoxDescuento.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(7, 35);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(1011, 284);
            dgvProductos.TabIndex = 0;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(7, 325);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(123, 23);
            btnAgregarProducto.TabIndex = 1;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(443, 325);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(130, 23);
            btnModificarProducto.TabIndex = 2;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(895, 325);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(123, 23);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // dgvProductosImportados
            // 
            dgvProductosImportados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosImportados.Location = new Point(6, 390);
            dgvProductosImportados.Name = "dgvProductosImportados";
            dgvProductosImportados.Size = new Size(1011, 227);
            dgvProductosImportados.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(445, 372);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 5;
            label1.Text = "Productos Importados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(477, 17);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Productos:";
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(203, 338);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(153, 23);
            btnAgregarStock.TabIndex = 7;
            btnAgregarStock.Text = "Agregar Stock al Producto";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnDescuento
            // 
            btnDescuento.Location = new Point(665, 338);
            btnDescuento.Name = "btnDescuento";
            btnDescuento.Size = new Size(185, 23);
            btnDescuento.TabIndex = 8;
            btnDescuento.Text = "Aplicar Descuento al Producto";
            btnDescuento.UseVisualStyleBackColor = true;
            btnDescuento.Click += btnDescuento_Click;
            // 
            // gBoxProductos
            // 
            gBoxProductos.Controls.Add(dgvProductos);
            gBoxProductos.Controls.Add(label1);
            gBoxProductos.Controls.Add(btnDescuento);
            gBoxProductos.Controls.Add(dgvProductosImportados);
            gBoxProductos.Controls.Add(label2);
            gBoxProductos.Controls.Add(btnAgregarStock);
            gBoxProductos.Controls.Add(btnEliminarProducto);
            gBoxProductos.Controls.Add(btnModificarProducto);
            gBoxProductos.Controls.Add(btnAgregarProducto);
            gBoxProductos.Location = new Point(12, 12);
            gBoxProductos.Name = "gBoxProductos";
            gBoxProductos.Size = new Size(1024, 623);
            gBoxProductos.TabIndex = 9;
            gBoxProductos.TabStop = false;
            gBoxProductos.Text = "Productos";
            // 
            // gBoxAgregarStock
            // 
            gBoxAgregarStock.Controls.Add(txtStockAgregado);
            gBoxAgregarStock.Controls.Add(label3);
            gBoxAgregarStock.Controls.Add(labelStock);
            gBoxAgregarStock.Controls.Add(btnCancelarStock);
            gBoxAgregarStock.Controls.Add(btnAceptarStock);
            gBoxAgregarStock.Location = new Point(1072, 12);
            gBoxAgregarStock.Name = "gBoxAgregarStock";
            gBoxAgregarStock.Size = new Size(299, 151);
            gBoxAgregarStock.TabIndex = 10;
            gBoxAgregarStock.TabStop = false;
            gBoxAgregarStock.Text = "Agregar Stock";
            // 
            // btnAceptarStock
            // 
            btnAceptarStock.Location = new Point(36, 110);
            btnAceptarStock.Name = "btnAceptarStock";
            btnAceptarStock.Size = new Size(75, 23);
            btnAceptarStock.TabIndex = 0;
            btnAceptarStock.Text = "Aceptar";
            btnAceptarStock.UseVisualStyleBackColor = true;
            btnAceptarStock.Click += btnAceptarStock_Click;
            // 
            // btnCancelarStock
            // 
            btnCancelarStock.Location = new Point(201, 110);
            btnCancelarStock.Name = "btnCancelarStock";
            btnCancelarStock.Size = new Size(75, 23);
            btnCancelarStock.TabIndex = 1;
            btnCancelarStock.Text = "Cancelar";
            btnCancelarStock.UseVisualStyleBackColor = true;
            btnCancelarStock.Click += btnCancelarStock_Click;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(19, 35);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(76, 15);
            labelStock.TabIndex = 2;
            labelStock.Text = "Stock Actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 68);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad A Sumar:";
            // 
            // txtStockAgregado
            // 
            txtStockAgregado.Location = new Point(131, 65);
            txtStockAgregado.Name = "txtStockAgregado";
            txtStockAgregado.Size = new Size(145, 23);
            txtStockAgregado.TabIndex = 4;
            // 
            // gBoxDescuento
            // 
            gBoxDescuento.Controls.Add(btnCancelarDescuento);
            gBoxDescuento.Controls.Add(btnAceptarDescuento);
            gBoxDescuento.Controls.Add(txtDescuento);
            gBoxDescuento.Controls.Add(label4);
            gBoxDescuento.Controls.Add(labelPrecio);
            gBoxDescuento.Location = new Point(1072, 169);
            gBoxDescuento.Name = "gBoxDescuento";
            gBoxDescuento.Size = new Size(299, 149);
            gBoxDescuento.TabIndex = 11;
            gBoxDescuento.TabStop = false;
            gBoxDescuento.Text = "Aplicar Descuento";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(19, 33);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(43, 15);
            labelPrecio.TabIndex = 0;
            labelPrecio.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 62);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 1;
            label4.Text = "Numero de Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(154, 59);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(122, 23);
            txtDescuento.TabIndex = 2;
            // 
            // btnAceptarDescuento
            // 
            btnAceptarDescuento.Location = new Point(36, 104);
            btnAceptarDescuento.Name = "btnAceptarDescuento";
            btnAceptarDescuento.Size = new Size(75, 23);
            btnAceptarDescuento.TabIndex = 3;
            btnAceptarDescuento.Text = "Aceptar";
            btnAceptarDescuento.UseVisualStyleBackColor = true;
            btnAceptarDescuento.Click += btnAceptarDescuento_Click;
            // 
            // btnCancelarDescuento
            // 
            btnCancelarDescuento.Location = new Point(201, 104);
            btnCancelarDescuento.Name = "btnCancelarDescuento";
            btnCancelarDescuento.Size = new Size(75, 23);
            btnCancelarDescuento.TabIndex = 4;
            btnCancelarDescuento.Text = "Cancelar";
            btnCancelarDescuento.UseVisualStyleBackColor = true;
            btnCancelarDescuento.Click += btnCancelarDescuento_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 647);
            Controls.Add(gBoxDescuento);
            Controls.Add(gBoxAgregarStock);
            Controls.Add(gBoxProductos);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosImportados).EndInit();
            gBoxProductos.ResumeLayout(false);
            gBoxProductos.PerformLayout();
            gBoxAgregarStock.ResumeLayout(false);
            gBoxAgregarStock.PerformLayout();
            gBoxDescuento.ResumeLayout(false);
            gBoxDescuento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnAgregarProducto;
        private Button btnModificarProducto;
        private Button btnEliminarProducto;
        private DataGridView dgvProductosImportados;
        private Label label1;
        private Label label2;
        private Button btnAgregarStock;
        private Button btnDescuento;
        private GroupBox gBoxProductos;
        private GroupBox gBoxAgregarStock;
        private Button btnCancelarStock;
        private Button btnAceptarStock;
        private TextBox txtStockAgregado;
        private Label label3;
        private Label labelStock;
        private GroupBox gBoxDescuento;
        private Label label4;
        private Label labelPrecio;
        private Button btnCancelarDescuento;
        private Button btnAceptarDescuento;
        private TextBox txtDescuento;
    }
}