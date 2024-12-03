using Controladora;
using Modelo;

namespace Vista.Modulo_2
{
    public partial class FormFactura : Form
    {
        private Factura factura;
        private Producto productoElegido;
        public FormFactura()
        {
            InitializeComponent();
            factura = new Factura();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            factura.Fecha = datePicker.Value;
            var clientes = ControladoraFacturas.Instance.RecuperarClientes();
            factura.Cliente = clientes.FirstOrDefault(c => c.Codigo == cBoxCliente.SelectedItem);
            gBoxDetalleFactura.Enabled = true;
            gBoxDatosFactura.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            gBoxDetalleFactura.Enabled = false;
            gBoxProductos.Enabled = false;
            gBoxCantidad.Enabled = false;

            var clientes = ControladoraFacturas.Instance.RecuperarClientes();
            foreach (var cliente in clientes)
            {
                cBoxCliente.Items.Add(cliente.Codigo);
            }
            cBoxCliente.DisplayMember = "Codigo";
        }

        private void ActualizarDGVDetallesFactura()
        {
            dgvProductosDetalles.DataSource = null;
            var detalleFacturaParaMostrar = factura.DetalleDeFacturas.Select(f => new
            {
                f.Id,
                NombreProducto = f.Producto.Nombre,
                CodigoProducto = f.Producto.Codigo,
                NombreCategoriaProducto = f.Producto.Categoria.Nombre,
                CodigoCategoriaProducto = f.Producto.Categoria.Codigo,
                f.Cantidad,
                f.PrecioUnitario,
                f.SubTotal
            }).ToList();
            dgvProductosDetalles.DataSource = detalleFacturaParaMostrar;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            gBoxDetalleFactura.Enabled = false;
            gBoxProductos.Enabled = true;
            ActualizarDGVProductos();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductosDetalles.Rows.Count > 0)
            {
                var detalle = (DetalleDeFactura)dgvProductosDetalles.CurrentRow.DataBoundItem;
                var eliminado = factura.EliminarDetalleFactura(detalle);
                if (eliminado)
                {
                    MessageBox.Show("Detalle de Factura eliminado correctamente");
                    ActualizarDGVDetallesFactura();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el Detalle de Factura");
                }
            }
            else
            {
                MessageBox.Show("Debes tener almenos un detalle de factura");
            }
        }

        private void btnAceptarDetalles_Click(object sender, EventArgs e)
        {
            if (dgvProductosDetalles.Rows.Count > 0)
            {
                var agregado = ControladoraFacturas.Instance.AgregarFactura(factura);
                if (agregado)
                {
                    MessageBox.Show("Factura agregada correctamente");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar la factura");
                }
            }
            else
            {
                MessageBox.Show("Debes tener almenos un detalle de factura");
            }
        }

        private void btnCancelarDetalles_Click(object sender, EventArgs e)
        {
            factura.DetalleDeFacturas.Clear();
            dgvProductosDetalles.DataSource = null;
            gBoxDetalleFactura.Enabled = false;
            gBoxDatosFactura.Enabled = true;
            labelTotal.Text = "Total:";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var codigoProducto = dgvProductos.CurrentRow.Cells["Codigo"].Value;
            var productos = ControladoraFacturas.Instance.RecuperarProductos();
            var producto = productos.FirstOrDefault(c => c.Codigo == codigoProducto);
            productoElegido = producto;
            gBoxProductos.Enabled = false;
            gBoxCantidad.Enabled = true;
            labelStockTotalDisp.Text = $"Cantidad Total Disponible: {producto.Stock}";
        }

        private void btnCancelarSeleccion_Click(object sender, EventArgs e)
        {
            gBoxDetalleFactura.Enabled = true;
            gBoxProductos.Enabled = false;
            dgvProductos.DataSource = null;
        }

        private void ActualizarDGVProductos()
        {
            dgvProductos.DataSource = null;
            var productos = ControladoraFacturas.Instance.RecuperarProductos();

            //muestro solo los productos con stock mayor a 0 ya que son los unicos que se puede comprar.
            List<Producto> listaproductos = new List<Producto>();
            foreach (var producto in productos)
            {
                if (producto.Stock > 0) 
                {
                    listaproductos.Add(producto);
                }
            }

            var productosParaMostrar = listaproductos.Select(f => new
            {
                f.Id,
                f.Codigo,
                f.Nombre,
                f.Descripcion,
                f.Precio,
                f.Stock,
                NombreCategoria = f.Categoria.Nombre,
                CodigoCategoria = f.Categoria.Codigo
            }).ToList();

            dgvProductos.DataSource = productosParaMostrar;
        }

        private void btnAceptarCantidad_Click(object sender, EventArgs e)
        {
            if (VerificarCantidad())
            {
                DetalleDeFactura detalleDeFactura = new DetalleDeFactura();
                detalleDeFactura.Producto = productoElegido;
                detalleDeFactura.Factura = factura;
                detalleDeFactura.Cantidad = Convert.ToInt32(txtCantidad.Text);
                detalleDeFactura.PrecioUnitario = productoElegido.Precio;
                var agregado = factura.AgregarDetalleFactura(detalleDeFactura);
                if (!agregado)
                {
                    //borro el detalle de factura ya que ya existe y lo "piso" con el nuevo
                    var DetalleViejo = factura.DetalleDeFacturas.FirstOrDefault(c => c.Producto.Codigo == detalleDeFactura.Producto.Codigo);
                    factura.EliminarDetalleFactura(DetalleViejo);
                    factura.AgregarDetalleFactura(detalleDeFactura);
                }
                MessageBox.Show("Detalle de factura agregado con exito");
                gBoxCantidad.Enabled = false;
                gBoxDetalleFactura.Enabled = true;
                dgvProductos.DataSource = null;
                ActualizarDGVDetallesFactura();
                labelTotal.Text = $"Total: {factura.Total:C}";
                labelStockTotalDisp.Text = "Cantidad Total Disponible:";
            }
        }

        private bool VerificarCantidad()
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("La cantidad no puede ser nula");
                return false;
            }
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe que ser un numero entero");
                return false;
            }
            if (cantidad > productoElegido.Stock)
            {
                MessageBox.Show("No hay tanta cantidad de ese producto, coloca menos");
                return false;
            }
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser positiva y mayor a 0");
                return false;
            }
            return true;
        }

        private void btnCancelarCantidad_Click(object sender, EventArgs e)
        {
            gBoxProductos.Enabled = true;
            gBoxCantidad.Enabled = false;
            labelStockTotalDisp.Text = "Cantidad Total Disponible:";
        }
    }
}
