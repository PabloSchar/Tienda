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

namespace Vista.Modulo_1
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ActualizarVista();
            gBoxDescuento.Enabled = false;
            gBoxAgregarStock.Enabled = false;
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var productos = ControladoraProductos.Instance.RecuperarProductos();
                var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                Form formProducto = new FormProducto(producto);
                formProducto.ShowDialog();
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay nada para Modificar");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var productos = ControladoraProductos.Instance.RecuperarProductos();
                var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                var eliminado = ControladoraProductos.Instance.EliminarProducto(producto);
                if (eliminado)
                {
                    MessageBox.Show("Producto Eliminada con Exito");
                    ActualizarVista();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Producto");
                }
            }
            else
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var categorias = ControladoraProductos.Instance.RecuperarCategorias();
            if (categorias.Count > 0)
            {
                Form formProducto = new FormProducto();
                formProducto.ShowDialog();
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("Es necesario que tengas creada una categoria como minimo");
            }
        }

        private void ActualizarVista()
        {
            dgvProductos.DataSource = null;
            var productos = ControladoraProductos.Instance.RecuperarProductos();
            var productosParaMostrar = productos.Select(f => new
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

            var productosImportados = productos.OfType<ProductoImportado>().ToList();
            dgvProductosImportados.DataSource = null;
            var productosImportadosParaMostrar = productosImportados.Select(f => new
            {
                f.Id,
                f.Codigo,
                f.CodigoImportacion,
                f.Nombre,
                f.Descripcion,
                f.Precio,
                f.Stock,
                NombreCategoria = f.Categoria.Nombre,
                CodigoCategoria = f.Categoria.Codigo
            }).ToList();
            dgvProductosImportados.DataSource = productosImportadosParaMostrar;
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var productos = ControladoraProductos.Instance.RecuperarProductos();
                var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                gBoxAgregarStock.Enabled = true;
                gBoxProductos.Enabled = false;
                labelStock.Text = $"Stock Actual: {producto.Stock}";
            }
            else
            {
                MessageBox.Show("No hay productos para agregar stock");
            }
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                var productos = ControladoraProductos.Instance.RecuperarProductos();
                var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                gBoxDescuento.Enabled = true;
                gBoxProductos.Enabled = false;
                labelPrecio.Text = $"Precio: {producto.Precio:C}";
            }
            else
            {
                MessageBox.Show("No hay productos para aplicar descuentos");
            }
        }

        private void btnAceptarDescuento_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDescuento.Text.ToString(), out decimal descuento))
            {
                if (descuento > 0 && descuento <= 100)
                {
                    var productos = ControladoraProductos.Instance.RecuperarProductos();
                    var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                    var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                    producto.AplicarDescuento(descuento);
                    var modificado = ControladoraProductos.Instance.ModificarProducto(producto);
                    if (modificado)
                    {
                        MessageBox.Show("Descuento Aplicado con exito");
                        gBoxDescuento.Enabled = false;
                        gBoxProductos.Enabled = true;
                        ActualizarVista();
                        labelPrecio.Text = "Precio:";
                        txtDescuento.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al Aplicar el Descuento");
                    }
                }
                else
                {
                    MessageBox.Show("el numero de descuento debe ser mayor a 0 y menor a 100");
                }
            }
            else
            {
                MessageBox.Show("El descuento debe ser un numero entero o decimal");
            }
        }

        private void btnCancelarDescuento_Click(object sender, EventArgs e)
        {
            gBoxDescuento.Enabled = false;
            gBoxProductos.Enabled = true;
            labelPrecio.Text = "Precio:";
            txtDescuento.Text = null;
        }

        private void btnAceptarStock_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtStockAgregado.Text, out int stock))
            {
                if (stock > 0) 
                {
                    var productos = ControladoraProductos.Instance.RecuperarProductos();
                    var productoCodigo = dgvProductos.CurrentRow.Cells["Codigo"].Value;
                    var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                    producto.AjustarStock(stock);
                    var modificado = ControladoraProductos.Instance.ModificarProducto(producto);
                    if (modificado)
                    {
                        MessageBox.Show("Stock Agregado con exito");
                        gBoxAgregarStock.Enabled = false;
                        gBoxProductos.Enabled = true;
                        ActualizarVista();
                        labelStock.Text = "Stock Actual:";
                        txtStockAgregado.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el Stock");
                    }
                }
                else
                {
                    MessageBox.Show("el Stock debe ser mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("El stock debe ser un numero entero");
            }
        }

        private void btnCancelarStock_Click(object sender, EventArgs e)
        {
            gBoxAgregarStock.Enabled = false;
            gBoxProductos.Enabled = true;
            labelStock.Text = "Stock Actual:";
            txtStockAgregado.Text = null;
        }
    }
}
