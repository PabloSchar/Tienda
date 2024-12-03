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

namespace Vista.Modulo_3
{
    public partial class FormProductosMasVendidos : Form
    {
        public FormProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProductosMasVendidos_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            dgvProductosMasVendidos.DataSource = null;

            var productosMasVendidos = ControladoraProductosMasVendidos.Instance.RecuperarProductos();

            //lo convierto en una lista para mostrarlos con sus cantidades vendidas en el dgv
            var productosParaMostrar = productosMasVendidos
            .Select(p => new
            {
                Codigo = p.Key.Codigo,
                Nombre = p.Key.Nombre,
                Descripcion = p.Key.Descripcion,
                Precio = p.Key.Precio,
                Stock = p.Key.Stock,
                Categoria = p.Key.Categoria.Nombre,
                CantidadVendida = p.Value
            })
            .ToList();

            dgvProductosMasVendidos.DataSource = productosParaMostrar;
        }
    }
}
