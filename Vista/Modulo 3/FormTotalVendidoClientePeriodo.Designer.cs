namespace Vista.Modulo_3
{
    partial class FormTotalVendidoClientePeriodo
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
            gBoxClientes = new GroupBox();
            dgvClientes = new DataGridView();
            btnAceptar = new Button();
            btnCerrar = new Button();
            gBoxFechas = new GroupBox();
            btnVerTotal = new Button();
            label1 = new Label();
            label2 = new Label();
            TimePickerInicio = new DateTimePicker();
            TimePickerFin = new DateTimePicker();
            btnCancelar = new Button();
            gBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gBoxFechas.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxClientes
            // 
            gBoxClientes.Controls.Add(btnCerrar);
            gBoxClientes.Controls.Add(btnAceptar);
            gBoxClientes.Controls.Add(dgvClientes);
            gBoxClientes.Location = new Point(12, 12);
            gBoxClientes.Name = "gBoxClientes";
            gBoxClientes.Size = new Size(792, 377);
            gBoxClientes.TabIndex = 0;
            gBoxClientes.TabStop = false;
            gBoxClientes.Text = "Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 22);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(780, 303);
            dgvClientes.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 342);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 21);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(711, 342);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // gBoxFechas
            // 
            gBoxFechas.Controls.Add(btnCancelar);
            gBoxFechas.Controls.Add(TimePickerFin);
            gBoxFechas.Controls.Add(TimePickerInicio);
            gBoxFechas.Controls.Add(label2);
            gBoxFechas.Controls.Add(label1);
            gBoxFechas.Controls.Add(btnVerTotal);
            gBoxFechas.Location = new Point(810, 12);
            gBoxFechas.Name = "gBoxFechas";
            gBoxFechas.Size = new Size(342, 183);
            gBoxFechas.TabIndex = 1;
            gBoxFechas.TabStop = false;
            gBoxFechas.Text = "Intervalo de Fecha";
            // 
            // btnVerTotal
            // 
            btnVerTotal.Location = new Point(12, 134);
            btnVerTotal.Name = "btnVerTotal";
            btnVerTotal.Size = new Size(75, 23);
            btnVerTotal.TabIndex = 0;
            btnVerTotal.Text = "Ver Total Vendido";
            btnVerTotal.UseVisualStyleBackColor = true;
            btnVerTotal.Click += btnVerTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Fin:";
            // 
            // TimePickerInicio
            // 
            TimePickerInicio.Location = new Point(91, 36);
            TimePickerInicio.Name = "TimePickerInicio";
            TimePickerInicio.Size = new Size(220, 23);
            TimePickerInicio.TabIndex = 3;
            // 
            // TimePickerFin
            // 
            TimePickerFin.Location = new Point(91, 81);
            TimePickerFin.Name = "TimePickerFin";
            TimePickerFin.Size = new Size(220, 23);
            TimePickerFin.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(236, 134);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormTotalVendidoClientePeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 402);
            Controls.Add(gBoxFechas);
            Controls.Add(gBoxClientes);
            Name = "FormTotalVendidoClientePeriodo";
            Text = "FormTotalVendidoClientePeriodo";
            Load += FormTotalVendidoClientePeriodo_Load;
            gBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gBoxFechas.ResumeLayout(false);
            gBoxFechas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxClientes;
        private Button btnCerrar;
        private Button btnAceptar;
        private DataGridView dgvClientes;
        private GroupBox gBoxFechas;
        private Button btnVerTotal;
        private DateTimePicker TimePickerFin;
        private DateTimePicker TimePickerInicio;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
    }
}