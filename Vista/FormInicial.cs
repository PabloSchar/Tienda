using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            Form formCliente = new Modulo_1.FormCliente();
            formCliente.ShowDialog();
        }

        private void btnGestionarProveedores_Click(object sender, EventArgs e)
        {
            Form formProveedores = new Modulo_1.FormProveedores();
            formProveedores.ShowDialog();
        }

        private void btnGestionarProductos_Click(object sender, EventArgs e)
        {
            Form formProductos = new Modulo_1.FormProductos();
            formProductos.ShowDialog();
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            var productos = ControladoraInicial.Instance.RecuperarProductos();
            var clientes = ControladoraInicial.Instance.RecuperarClientes();
            if (productos.Count > 0 && clientes.Count > 0)
            {
                Form formFactura = new Modulo_2.FormFactura();
                formFactura.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes tener minimo un Cliente y un Producto registrados");
            }
        }

        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            var detallesFacturas = ControladoraInicial.Instance.RecuperarDetallesFactura();
            if (detallesFacturas.Count > 0)
            {
                Form formProductosMasVendidos = new Modulo_3.FormProductosMasVendidos();
                formProductosMasVendidos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ningun producto fue vendido");
            }
        }

        private void btnVendidoClienteFecha_Click(object sender, EventArgs e)
        {
            var clientes = ControladoraInicial.Instance.RecuperarClientes();
            if (clientes.Count > 0)
            {
                Form formVentasClienteIntervalo = new Modulo_3.FormTotalVendidoClientePeriodo();
                formVentasClienteIntervalo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes tener minimo un Cliente registrado");
            }
        }

        private void btnFacturasEnIntervalo_Click(object sender, EventArgs e)
        {
            var facturas = ControladoraInicial.Instance.RecuperarFacturas();
            if (facturas.Count > 0)
            {
                Form formFacturasEmitidasEnIntervalo = new Modulo_3.FormFacturasEmitidasEnIntervalo();
                formFacturasEmitidasEnIntervalo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debes tener minimo una factura");
            }
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            Form formCategoria = new Modulo_1.FormCategoria();
            formCategoria.ShowDialog();
        }
    }
}
