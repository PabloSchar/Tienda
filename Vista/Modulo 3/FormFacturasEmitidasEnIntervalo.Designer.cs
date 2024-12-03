namespace Vista.Modulo_3
{
    partial class FormFacturasEmitidasEnIntervalo
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
            gBoxFechas = new GroupBox();
            btnCancelar = new Button();
            btnVerFacturasIntervalo = new Button();
            TimePickerFin = new DateTimePicker();
            TimePickerInicio = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            gBoxFacturas = new GroupBox();
            btnVolver = new Button();
            dgvFacturasIntervalo = new DataGridView();
            gBoxFechas.SuspendLayout();
            gBoxFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFacturasIntervalo).BeginInit();
            SuspendLayout();
            // 
            // gBoxFechas
            // 
            gBoxFechas.Controls.Add(btnCancelar);
            gBoxFechas.Controls.Add(btnVerFacturasIntervalo);
            gBoxFechas.Controls.Add(TimePickerFin);
            gBoxFechas.Controls.Add(TimePickerInicio);
            gBoxFechas.Controls.Add(label2);
            gBoxFechas.Controls.Add(label1);
            gBoxFechas.Location = new Point(12, 12);
            gBoxFechas.Name = "gBoxFechas";
            gBoxFechas.Size = new Size(319, 172);
            gBoxFechas.TabIndex = 0;
            gBoxFechas.TabStop = false;
            gBoxFechas.Text = "Intervalo de Fechas";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVerFacturasIntervalo
            // 
            btnVerFacturasIntervalo.Location = new Point(6, 120);
            btnVerFacturasIntervalo.Name = "btnVerFacturasIntervalo";
            btnVerFacturasIntervalo.Size = new Size(99, 23);
            btnVerFacturasIntervalo.TabIndex = 4;
            btnVerFacturasIntervalo.Text = "Ver Facturas";
            btnVerFacturasIntervalo.UseVisualStyleBackColor = true;
            btnVerFacturasIntervalo.Click += btnVerFacturasIntervalo_Click;
            // 
            // TimePickerFin
            // 
            TimePickerFin.Location = new Point(88, 70);
            TimePickerFin.Name = "TimePickerFin";
            TimePickerFin.Size = new Size(217, 23);
            TimePickerFin.TabIndex = 3;
            // 
            // TimePickerInicio
            // 
            TimePickerInicio.Location = new Point(88, 27);
            TimePickerInicio.Name = "TimePickerInicio";
            TimePickerInicio.Size = new Size(217, 23);
            TimePickerInicio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Inicio:";
            // 
            // gBoxFacturas
            // 
            gBoxFacturas.Controls.Add(btnVolver);
            gBoxFacturas.Controls.Add(dgvFacturasIntervalo);
            gBoxFacturas.Location = new Point(12, 190);
            gBoxFacturas.Name = "gBoxFacturas";
            gBoxFacturas.Size = new Size(776, 297);
            gBoxFacturas.TabIndex = 1;
            gBoxFacturas.TabStop = false;
            gBoxFacturas.Text = "Facturas En El Intervalo";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(350, 268);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvFacturasIntervalo
            // 
            dgvFacturasIntervalo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturasIntervalo.Location = new Point(6, 22);
            dgvFacturasIntervalo.Name = "dgvFacturasIntervalo";
            dgvFacturasIntervalo.Size = new Size(764, 240);
            dgvFacturasIntervalo.TabIndex = 0;
            // 
            // FormFacturasEmitidasEnIntervalo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            ControlBox = false;
            Controls.Add(gBoxFacturas);
            Controls.Add(gBoxFechas);
            Name = "FormFacturasEmitidasEnIntervalo";
            Load += FormFacturasEmitidasEnIntervalo_Load;
            gBoxFechas.ResumeLayout(false);
            gBoxFechas.PerformLayout();
            gBoxFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFacturasIntervalo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxFechas;
        private Button btnCancelar;
        private Button btnVerFacturasIntervalo;
        private DateTimePicker TimePickerFin;
        private DateTimePicker TimePickerInicio;
        private Label label2;
        private Label label1;
        private GroupBox gBoxFacturas;
        private Button btnVolver;
        private DataGridView dgvFacturasIntervalo;
    }
}