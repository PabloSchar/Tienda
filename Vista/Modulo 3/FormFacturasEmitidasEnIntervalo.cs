using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Modulo_3
{
    public partial class FormFacturasEmitidasEnIntervalo : Form
    {
        public FormFacturasEmitidasEnIntervalo()
        {
            InitializeComponent();
        }

        private void FormFacturasEmitidasEnIntervalo_Load(object sender, EventArgs e)
        {
            gBoxFacturas.Enabled = false;
        }

        private void btnVerFacturasIntervalo_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = TimePickerInicio.Value;
            DateTime fechaFin = TimePickerFin.Value;
            if (fechaFin > fechaInicio)
            {
                var facturas = ControladoraFacturasEnIntervalo.Instance.ObtenerFacturasEnIntervalo(fechaInicio, fechaFin);
                if (facturas.Count > 0)
                {
                    ActualizarDgv(facturas);
                    gBoxFacturas.Enabled = true;
                    gBoxFechas.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No hay facturas en ese intervalo");
                }
            }
            else
            {
                MessageBox.Show("La fecha de Fin debe ser mayor que la fecha de inicio");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dgvFacturasIntervalo.DataSource = null;
            gBoxFacturas.Enabled = false;
            gBoxFechas.Enabled = true;
        }

        private void ActualizarDgv(ReadOnlyCollection<Factura> facturas)
        {
            dgvFacturasIntervalo.DataSource = null;

            var facturasParaMostrar = facturas.Select(f => new
            {
                f.Id,
                f.Numero,
                f.Fecha,
                ClienteNombre = f.Cliente.Nombre,
                CodigoCliente = f.Cliente.Codigo,
                f.Total
            }).ToList();

            dgvFacturasIntervalo.DataSource = facturasParaMostrar;
        }
    }
}
