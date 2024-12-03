using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Modulo_3
{
    public partial class FormTotalVendidoClientePeriodo : Form
    {
        public FormTotalVendidoClientePeriodo()
        {
            InitializeComponent();
        }

        private void FormTotalVendidoClientePeriodo_Load(object sender, EventArgs e)
        {
            ActualizarVista();
            gBoxFechas.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gBoxClientes.Enabled = false;
            gBoxFechas.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerTotal_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = TimePickerInicio.Value;
            DateTime fechaFin = TimePickerFin.Value;
            if (fechaFin > fechaInicio)
            {
                var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                decimal totalVendido = ControladoraVentasEnIntervalo.Instance.ObtenerTotalVendidoIntervalo(cliente, fechaInicio, fechaFin);
                MessageBox.Show($"Total Vendido Entre las Fechas: ${totalVendido}");
                ActualizarVista();
                gBoxClientes.Enabled = true;
                gBoxFechas.Enabled = false;
            }
            else
            {
                MessageBox.Show("La fecha de Fin debe ser mayor que la fecha de inicio");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gBoxClientes.Enabled = true;
            gBoxFechas.Enabled = false;
        }

        private void ActualizarVista()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ControladoraVentasEnIntervalo.Instance.RecuperarClientes();
        }
    }
}
