namespace Vista.Modulo_1
{
    partial class FormCategoria
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
            gBoxCategoria = new GroupBox();
            btnCerrar = new Button();
            btnAceptar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvCategorias = new DataGridView();
            btnAgregarCategoria = new Button();
            gBoxCategorias = new GroupBox();
            btnModificar = new Button();
            btnCancelar = new Button();
            gBoxCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            gBoxCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxCategoria
            // 
            gBoxCategoria.Controls.Add(btnCancelar);
            gBoxCategoria.Controls.Add(btnAceptar);
            gBoxCategoria.Controls.Add(txtDescripcion);
            gBoxCategoria.Controls.Add(txtNombre);
            gBoxCategoria.Controls.Add(txtCodigo);
            gBoxCategoria.Controls.Add(label3);
            gBoxCategoria.Controls.Add(label2);
            gBoxCategoria.Controls.Add(label1);
            gBoxCategoria.Location = new Point(12, 12);
            gBoxCategoria.Name = "gBoxCategoria";
            gBoxCategoria.Size = new Size(264, 197);
            gBoxCategoria.TabIndex = 0;
            gBoxCategoria.TabStop = false;
            gBoxCategoria.Text = "Categoria";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(289, 262);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 23);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 162);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(104, 108);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(104, 25);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(6, 22);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(649, 234);
            dgvCategorias.TabIndex = 8;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(6, 262);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(159, 23);
            btnAgregarCategoria.TabIndex = 10;
            btnAgregarCategoria.Text = "Agregar Categoria";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // gBoxCategorias
            // 
            gBoxCategorias.Controls.Add(btnCerrar);
            gBoxCategorias.Controls.Add(btnModificar);
            gBoxCategorias.Controls.Add(dgvCategorias);
            gBoxCategorias.Controls.Add(btnAgregarCategoria);
            gBoxCategorias.Location = new Point(300, 12);
            gBoxCategorias.Name = "gBoxCategorias";
            gBoxCategorias.Size = new Size(661, 291);
            gBoxCategorias.TabIndex = 11;
            gBoxCategorias.TabStop = false;
            gBoxCategorias.Text = "Categorias";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(527, 262);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar Categoria";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(183, 162);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 315);
            ControlBox = false;
            Controls.Add(gBoxCategorias);
            Controls.Add(gBoxCategoria);
            Name = "FormCategoria";
            Load += FormCategoria_Load;
            gBoxCategoria.ResumeLayout(false);
            gBoxCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            gBoxCategorias.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxCategoria;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnCerrar;
        private Button btnAceptar;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private DataGridView dgvCategorias;
        private Button btnAgregarCategoria;
        private GroupBox gBoxCategorias;
        private Button btnModificar;
        private Button btnCancelar;
    }
}