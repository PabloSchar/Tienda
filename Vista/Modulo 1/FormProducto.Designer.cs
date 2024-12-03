namespace Vista.Modulo_1
{
    partial class FormProducto
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
            GboxProducto = new GroupBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            cBoxCategoria = new ComboBox();
            checkImportado = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GboxProductoImportado = new GroupBox();
            btnCancelarImportado = new Button();
            btnAceptarImportado = new Button();
            txtCodigoImportado = new TextBox();
            label8 = new Label();
            GboxProducto.SuspendLayout();
            GboxProductoImportado.SuspendLayout();
            SuspendLayout();
            // 
            // GboxProducto
            // 
            GboxProducto.Controls.Add(btnCancelar);
            GboxProducto.Controls.Add(btnAceptar);
            GboxProducto.Controls.Add(txtCodigo);
            GboxProducto.Controls.Add(txtNombre);
            GboxProducto.Controls.Add(txtDescripcion);
            GboxProducto.Controls.Add(txtPrecio);
            GboxProducto.Controls.Add(txtStock);
            GboxProducto.Controls.Add(cBoxCategoria);
            GboxProducto.Controls.Add(checkImportado);
            GboxProducto.Controls.Add(label7);
            GboxProducto.Controls.Add(label6);
            GboxProducto.Controls.Add(label5);
            GboxProducto.Controls.Add(label4);
            GboxProducto.Controls.Add(label3);
            GboxProducto.Controls.Add(label2);
            GboxProducto.Controls.Add(label1);
            GboxProducto.Location = new Point(12, 12);
            GboxProducto.Name = "GboxProducto";
            GboxProducto.Size = new Size(344, 332);
            GboxProducto.TabIndex = 0;
            GboxProducto.TabStop = false;
            GboxProducto.Text = "Producto";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(256, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 297);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(140, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(142, 23);
            txtCodigo.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 112);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(140, 145);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(140, 178);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 9;
            // 
            // cBoxCategoria
            // 
            cBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxCategoria.FormattingEnabled = true;
            cBoxCategoria.Location = new Point(140, 213);
            cBoxCategoria.Name = "cBoxCategoria";
            cBoxCategoria.Size = new Size(191, 23);
            cBoxCategoria.TabIndex = 8;
            // 
            // checkImportado
            // 
            checkImportado.AutoSize = true;
            checkImportado.Location = new Point(140, 254);
            checkImportado.Name = "checkImportado";
            checkImportado.Size = new Size(15, 14);
            checkImportado.TabIndex = 7;
            checkImportado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 253);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 6;
            label7.Text = "Producto Importado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 216);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 181);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Stock:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // GboxProductoImportado
            // 
            GboxProductoImportado.Controls.Add(btnCancelarImportado);
            GboxProductoImportado.Controls.Add(btnAceptarImportado);
            GboxProductoImportado.Controls.Add(txtCodigoImportado);
            GboxProductoImportado.Controls.Add(label8);
            GboxProductoImportado.Location = new Point(402, 12);
            GboxProductoImportado.Name = "GboxProductoImportado";
            GboxProductoImportado.Size = new Size(386, 135);
            GboxProductoImportado.TabIndex = 1;
            GboxProductoImportado.TabStop = false;
            GboxProductoImportado.Text = "Producto Importado";
            // 
            // btnCancelarImportado
            // 
            btnCancelarImportado.Location = new Point(283, 88);
            btnCancelarImportado.Name = "btnCancelarImportado";
            btnCancelarImportado.Size = new Size(75, 23);
            btnCancelarImportado.TabIndex = 3;
            btnCancelarImportado.Text = "Cancelar";
            btnCancelarImportado.UseVisualStyleBackColor = true;
            btnCancelarImportado.Click += btnCancelarImportado_Click;
            // 
            // btnAceptarImportado
            // 
            btnAceptarImportado.Location = new Point(23, 88);
            btnAceptarImportado.Name = "btnAceptarImportado";
            btnAceptarImportado.Size = new Size(75, 23);
            btnAceptarImportado.TabIndex = 2;
            btnAceptarImportado.Text = "Aceptar";
            btnAceptarImportado.UseVisualStyleBackColor = true;
            btnAceptarImportado.Click += btnAceptarImportado_Click;
            // 
            // txtCodigoImportado
            // 
            txtCodigoImportado.Location = new Point(206, 31);
            txtCodigoImportado.Name = "txtCodigoImportado";
            txtCodigoImportado.Size = new Size(152, 23);
            txtCodigoImportado.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 34);
            label8.Name = "label8";
            label8.Size = new Size(177, 15);
            label8.TabIndex = 0;
            label8.Text = "Codigo De Producto Importado:";
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 348);
            ControlBox = false;
            Controls.Add(GboxProductoImportado);
            Controls.Add(GboxProducto);
            Name = "FormProducto";
            Load += FormProducto_Load;
            GboxProducto.ResumeLayout(false);
            GboxProducto.PerformLayout();
            GboxProductoImportado.ResumeLayout(false);
            GboxProductoImportado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GboxProducto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private ComboBox cBoxCategoria;
        private CheckBox checkImportado;
        private Label label7;
        private Button btnCancelar;
        private Button btnAceptar;
        private GroupBox GboxProductoImportado;
        private Button btnCancelarImportado;
        private Button btnAceptarImportado;
        private TextBox txtCodigoImportado;
        private Label label8;
    }
}