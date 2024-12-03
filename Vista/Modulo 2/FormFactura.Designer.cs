namespace Vista.Modulo_2
{
    partial class FormFactura
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
            dgvProductosDetalles = new DataGridView();
            gBoxDatosFactura = new GroupBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cBoxCliente = new ComboBox();
            datePicker = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            gBoxDetalleFactura = new GroupBox();
            labelTotal = new Label();
            btnCancelarDetalles = new Button();
            btnAceptarDetalles = new Button();
            btnEliminarProducto = new Button();
            btnAgregarProducto = new Button();
            label4 = new Label();
            gBoxProductos = new GroupBox();
            btnCancelarSeleccion = new Button();
            btnConfirmar = new Button();
            dgvProductos = new DataGridView();
            gBoxCantidad = new GroupBox();
            labelStockTotalDisp = new Label();
            btnCancelarCantidad = new Button();
            btnAceptarCantidad = new Button();
            txtCantidad = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDetalles).BeginInit();
            gBoxDatosFactura.SuspendLayout();
            gBoxDetalleFactura.SuspendLayout();
            gBoxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gBoxCantidad.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductosDetalles
            // 
            dgvProductosDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosDetalles.Location = new Point(6, 43);
            dgvProductosDetalles.Name = "dgvProductosDetalles";
            dgvProductosDetalles.Size = new Size(626, 263);
            dgvProductosDetalles.TabIndex = 0;
            // 
            // gBoxDatosFactura
            // 
            gBoxDatosFactura.Controls.Add(btnCancelar);
            gBoxDatosFactura.Controls.Add(btnAceptar);
            gBoxDatosFactura.Controls.Add(cBoxCliente);
            gBoxDatosFactura.Controls.Add(datePicker);
            gBoxDatosFactura.Controls.Add(label3);
            gBoxDatosFactura.Controls.Add(label1);
            gBoxDatosFactura.Location = new Point(12, 12);
            gBoxDatosFactura.Name = "gBoxDatosFactura";
            gBoxDatosFactura.Size = new Size(300, 166);
            gBoxDatosFactura.TabIndex = 1;
            gBoxDatosFactura.TabStop = false;
            gBoxDatosFactura.Text = "Datos De La Factura";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(206, 117);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 117);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cBoxCliente
            // 
            cBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxCliente.FormattingEnabled = true;
            cBoxCliente.Location = new Point(63, 72);
            cBoxCliente.Name = "cBoxCliente";
            cBoxCliente.Size = new Size(121, 23);
            cBoxCliente.TabIndex = 5;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(63, 37);
            datePicker.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(218, 23);
            datePicker.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 75);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // gBoxDetalleFactura
            // 
            gBoxDetalleFactura.Controls.Add(labelTotal);
            gBoxDetalleFactura.Controls.Add(btnCancelarDetalles);
            gBoxDetalleFactura.Controls.Add(btnAceptarDetalles);
            gBoxDetalleFactura.Controls.Add(btnEliminarProducto);
            gBoxDetalleFactura.Controls.Add(btnAgregarProducto);
            gBoxDetalleFactura.Controls.Add(label4);
            gBoxDetalleFactura.Controls.Add(dgvProductosDetalles);
            gBoxDetalleFactura.Location = new Point(552, 12);
            gBoxDetalleFactura.Name = "gBoxDetalleFactura";
            gBoxDetalleFactura.Size = new Size(638, 381);
            gBoxDetalleFactura.TabIndex = 2;
            gBoxDetalleFactura.TabStop = false;
            gBoxDetalleFactura.Text = "Detalles de la Factura";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(298, 318);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(36, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total:";
            // 
            // btnCancelarDetalles
            // 
            btnCancelarDetalles.Location = new Point(354, 353);
            btnCancelarDetalles.Name = "btnCancelarDetalles";
            btnCancelarDetalles.Size = new Size(75, 23);
            btnCancelarDetalles.TabIndex = 5;
            btnCancelarDetalles.Text = "Cancelar";
            btnCancelarDetalles.UseVisualStyleBackColor = true;
            btnCancelarDetalles.Click += btnCancelarDetalles_Click;
            // 
            // btnAceptarDetalles
            // 
            btnAceptarDetalles.Location = new Point(219, 353);
            btnAceptarDetalles.Name = "btnAceptarDetalles";
            btnAceptarDetalles.Size = new Size(75, 23);
            btnAceptarDetalles.TabIndex = 4;
            btnAceptarDetalles.Text = "Aceptar";
            btnAceptarDetalles.UseVisualStyleBackColor = true;
            btnAceptarDetalles.Click += btnAceptarDetalles_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(505, 314);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(127, 23);
            btnEliminarProducto.TabIndex = 3;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(6, 314);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(127, 23);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 25);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 1;
            label4.Text = "Productos:";
            // 
            // gBoxProductos
            // 
            gBoxProductos.Controls.Add(btnCancelarSeleccion);
            gBoxProductos.Controls.Add(btnConfirmar);
            gBoxProductos.Controls.Add(dgvProductos);
            gBoxProductos.Location = new Point(12, 188);
            gBoxProductos.Name = "gBoxProductos";
            gBoxProductos.Size = new Size(534, 256);
            gBoxProductos.TabIndex = 3;
            gBoxProductos.TabStop = false;
            gBoxProductos.Text = "Agregar Productos";
            // 
            // btnCancelarSeleccion
            // 
            btnCancelarSeleccion.Location = new Point(453, 227);
            btnCancelarSeleccion.Name = "btnCancelarSeleccion";
            btnCancelarSeleccion.Size = new Size(75, 23);
            btnCancelarSeleccion.TabIndex = 2;
            btnCancelarSeleccion.Text = "Cancelar";
            btnCancelarSeleccion.UseVisualStyleBackColor = true;
            btnCancelarSeleccion.Click += btnCancelarSeleccion_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(6, 227);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(151, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar Seleccion";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 22);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(522, 199);
            dgvProductos.TabIndex = 0;
            // 
            // gBoxCantidad
            // 
            gBoxCantidad.Controls.Add(labelStockTotalDisp);
            gBoxCantidad.Controls.Add(btnCancelarCantidad);
            gBoxCantidad.Controls.Add(btnAceptarCantidad);
            gBoxCantidad.Controls.Add(txtCantidad);
            gBoxCantidad.Controls.Add(label6);
            gBoxCantidad.Location = new Point(552, 399);
            gBoxCantidad.Name = "gBoxCantidad";
            gBoxCantidad.Size = new Size(284, 123);
            gBoxCantidad.TabIndex = 4;
            gBoxCantidad.TabStop = false;
            gBoxCantidad.Text = "Definir Cantidades";
            // 
            // labelStockTotalDisp
            // 
            labelStockTotalDisp.AutoSize = true;
            labelStockTotalDisp.Location = new Point(6, 30);
            labelStockTotalDisp.Name = "labelStockTotalDisp";
            labelStockTotalDisp.Size = new Size(146, 15);
            labelStockTotalDisp.TabIndex = 4;
            labelStockTotalDisp.Text = "Cantidad Total Disponible:";
            // 
            // btnCancelarCantidad
            // 
            btnCancelarCantidad.Location = new Point(185, 94);
            btnCancelarCantidad.Name = "btnCancelarCantidad";
            btnCancelarCantidad.Size = new Size(75, 23);
            btnCancelarCantidad.TabIndex = 3;
            btnCancelarCantidad.Text = "Cancelar";
            btnCancelarCantidad.UseVisualStyleBackColor = true;
            btnCancelarCantidad.Click += btnCancelarCantidad_Click;
            // 
            // btnAceptarCantidad
            // 
            btnAceptarCantidad.Location = new Point(6, 94);
            btnAceptarCantidad.Name = "btnAceptarCantidad";
            btnAceptarCantidad.Size = new Size(75, 23);
            btnAceptarCantidad.TabIndex = 2;
            btnAceptarCantidad.Text = "Aceptar";
            btnAceptarCantidad.UseVisualStyleBackColor = true;
            btnAceptarCantidad.Click += btnAceptarCantidad_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(70, 61);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(190, 23);
            txtCantidad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 64);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 0;
            label6.Text = "Cantidad:";
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 523);
            ControlBox = false;
            Controls.Add(gBoxCantidad);
            Controls.Add(gBoxProductos);
            Controls.Add(gBoxDetalleFactura);
            Controls.Add(gBoxDatosFactura);
            Name = "FormFactura";
            Load += FormFactura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosDetalles).EndInit();
            gBoxDatosFactura.ResumeLayout(false);
            gBoxDatosFactura.PerformLayout();
            gBoxDetalleFactura.ResumeLayout(false);
            gBoxDetalleFactura.PerformLayout();
            gBoxProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gBoxCantidad.ResumeLayout(false);
            gBoxCantidad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductosDetalles;
        private GroupBox gBoxDatosFactura;
        private Label label1;
        private Label label3;
        private DateTimePicker datePicker;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cBoxCliente;
        private GroupBox gBoxDetalleFactura;
        private Button btnAgregarProducto;
        private Label label4;
        private Button btnEliminarProducto;
        private Label labelTotal;
        private Button btnCancelarDetalles;
        private Button btnAceptarDetalles;
        private GroupBox gBoxProductos;
        private DataGridView dgvProductos;
        private Button btnCancelarSeleccion;
        private Button btnConfirmar;
        private GroupBox gBoxCantidad;
        private TextBox txtCantidad;
        private Label label6;
        private Button btnCancelarCantidad;
        private Button btnAceptarCantidad;
        private Label labelStockTotalDisp;
    }
}