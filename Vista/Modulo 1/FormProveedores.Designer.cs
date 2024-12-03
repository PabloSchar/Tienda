namespace Vista.Modulo_1
{
    partial class FormProveedores
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
            dgvProveedores = new DataGridView();
            btnAgregarProveedor = new Button();
            btnModificarProveedor = new Button();
            btnEliminarProveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 12);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(776, 395);
            dgvProveedores.TabIndex = 0;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(12, 415);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(126, 23);
            btnAgregarProveedor.TabIndex = 1;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.Location = new Point(347, 415);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(132, 23);
            btnModificarProveedor.TabIndex = 2;
            btnModificarProveedor.Text = "Modificar Proveedor";
            btnModificarProveedor.UseVisualStyleBackColor = true;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(659, 415);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(129, 23);
            btnEliminarProveedor.TabIndex = 3;
            btnEliminarProveedor.Text = "Eliminar Proveedor";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnModificarProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(dgvProveedores);
            Name = "FormProveedores";
            Text = "FormProveedores";
            Load += FormProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedores;
        private Button btnAgregarProveedor;
        private Button btnModificarProveedor;
        private Button btnEliminarProveedor;
    }
}