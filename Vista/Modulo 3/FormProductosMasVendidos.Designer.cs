namespace Vista.Modulo_3
{
    partial class FormProductosMasVendidos
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
            dgvProductosMasVendidos = new DataGridView();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductosMasVendidos
            // 
            dgvProductosMasVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosMasVendidos.Location = new Point(6, 22);
            dgvProductosMasVendidos.Name = "dgvProductosMasVendidos";
            dgvProductosMasVendidos.Size = new Size(764, 369);
            dgvProductosMasVendidos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(340, 397);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProductosMasVendidos);
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos Mas Vendidos";
            // 
            // FormProductosMasVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(groupBox1);
            Name = "FormProductosMasVendidos";
            Load += FormProductosMasVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductosMasVendidos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductosMasVendidos;
        private Button btnCerrar;
        private GroupBox groupBox1;
    }
}