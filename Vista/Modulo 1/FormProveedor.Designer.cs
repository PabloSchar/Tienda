namespace Vista.Modulo_1
{
    partial class FormProveedor
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
            groupBox1 = new GroupBox();
            dgvProductosTotales = new DataGridView();
            btnCancelar = new Button();
            btnAceptar = new Button();
            btnEliminarProductoDelProveedor = new Button();
            dgvProductosDelProveedor = new DataGridView();
            label6 = new Label();
            btnAgregarProductoAProveedor = new Button();
            txtContacto = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDelProveedor).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProductosTotales);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAceptar);
            groupBox1.Controls.Add(btnEliminarProductoDelProveedor);
            groupBox1.Controls.Add(dgvProductosDelProveedor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnAgregarProductoAProveedor);
            groupBox1.Controls.Add(txtContacto);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(939, 554);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proveedor";
            // 
            // dgvProductosTotales
            // 
            dgvProductosTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosTotales.Location = new Point(289, 37);
            dgvProductosTotales.Name = "dgvProductosTotales";
            dgvProductosTotales.Size = new Size(610, 192);
            dgvProductosTotales.TabIndex = 16;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(140, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(27, 259);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnEliminarProductoDelProveedor
            // 
            btnEliminarProductoDelProveedor.Location = new Point(512, 522);
            btnEliminarProductoDelProveedor.Name = "btnEliminarProductoDelProveedor";
            btnEliminarProductoDelProveedor.Size = new Size(201, 23);
            btnEliminarProductoDelProveedor.TabIndex = 13;
            btnEliminarProductoDelProveedor.Text = "Eliminar Producto del Proveedor";
            btnEliminarProductoDelProveedor.UseVisualStyleBackColor = true;
            btnEliminarProductoDelProveedor.Click += btnEliminarProductoDelProveedor_Click;
            // 
            // dgvProductosDelProveedor
            // 
            dgvProductosDelProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosDelProveedor.Location = new Point(289, 295);
            dgvProductosDelProveedor.Name = "dgvProductosDelProveedor";
            dgvProductosDelProveedor.Size = new Size(610, 221);
            dgvProductosDelProveedor.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(542, 277);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 11;
            label6.Text = "Productos del Proveedor:";
            // 
            // btnAgregarProductoAProveedor
            // 
            btnAgregarProductoAProveedor.Location = new Point(512, 235);
            btnAgregarProductoAProveedor.Name = "btnAgregarProductoAProveedor";
            btnAgregarProductoAProveedor.Size = new Size(201, 23);
            btnAgregarProductoAProveedor.TabIndex = 10;
            btnAgregarProductoAProveedor.Text = "Agregar Producto al Proveedor";
            btnAgregarProductoAProveedor.UseVisualStyleBackColor = true;
            btnAgregarProductoAProveedor.Click += btnAgregarProductoAProveedor_Click;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(115, 150);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(115, 112);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(115, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(115, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 19);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Productos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 153);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Contacto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 115);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 78);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // FormProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 569);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "FormProveedor";
            Load += FormProveedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductosTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosDelProveedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEliminarProductoDelProveedor;
        private DataGridView dgvProductosDelProveedor;
        private Label label6;
        private Button btnAgregarProductoAProveedor;
        private TextBox txtContacto;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label5;
        private Button btnCancelar;
        private Button btnAceptar;
        private DataGridView dgvProductosTotales;
    }
}