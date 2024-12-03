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
    public partial class FormProveedor : Form
    {
        private Proveedor proveedor;
        private bool modifica = false;
        public FormProveedor()
        {
            InitializeComponent();
            proveedor = new Proveedor();
        }

        public FormProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            modifica = true;
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            ActualizarDGVProductosDelProveedor();
            ActualizarDGVProductosTotales();

            if (modifica)
            {
                txtCodigo.Enabled = false;
                txtCodigo.Text = proveedor.Codigo.ToString();
                txtContacto.Text = proveedor.Contacto.ToString();
                txtDireccion.Text = proveedor.Direccion.ToString();
                txtNombre.Text = proveedor.Nombre.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                proveedor.Codigo = txtCodigo.Text;
                proveedor.Direccion = txtDireccion.Text;
                proveedor.Nombre = txtNombre.Text;
                proveedor.Contacto = txtContacto.Text;
                if (modifica)
                {
                    var modificado = ControladoraProveedores.Instance.ModificarProveedor(proveedor);
                    if (modificado)
                    {
                        MessageBox.Show("Proveedor Modificado con exito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el Proveedor");
                    }
                }
                else
                {
                    var agregado = ControladoraProveedores.Instance.AgregarProveedor(proveedor);
                    if (agregado)
                    {
                        MessageBox.Show("Proveedor Agregado con exito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al Agregar el proveedor");
                    }
                }
            }
        }

        private void btnEliminarProductoDelProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProductosDelProveedor.Rows.Count > 0)
            {
                var productos = ControladoraProveedores.Instance.RecuperarProductos();
                var codigoProducto = dgvProductosDelProveedor.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == codigoProducto);
                var eliminado = proveedor.EliminarProductoDeProveedor(producto);
                if (eliminado)
                {
                    MessageBox.Show("Producto Eliminado del Proveedor con Exito");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el producto del Proveedor");
                }
                ActualizarDGVProductosTotales();
                ActualizarDGVProductosDelProveedor();
            }
            else
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        private void btnAgregarProductoAProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProductosTotales.Rows.Count > 0)
            {
                var productos = ControladoraProveedores.Instance.RecuperarProductos();
                var productoCodigo = dgvProductosTotales.CurrentRow.Cells["Codigo"].Value;
                var producto = productos.FirstOrDefault(c => c.Codigo == productoCodigo);
                var agregado = proveedor.AgregarProductoDeProveedor(producto);
                if (agregado)
                {
                    MessageBox.Show("Producto agregado con exito al Proveedor");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto al Proveedor");
                }
                ActualizarDGVProductosTotales();
                ActualizarDGVProductosDelProveedor();
            }
            else
            {
                MessageBox.Show("No hay nada para agregar");
            }
        }

        private void ActualizarDGVProductosDelProveedor()
        {
            dgvProductosDelProveedor.DataSource = null;
            var productos = proveedor.Productos;
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
            dgvProductosDelProveedor.DataSource = productosParaMostrar;
        }

        private void ActualizarDGVProductosTotales()
        {
            dgvProductosTotales.DataSource = null;
            var productosTotales = ControladoraProveedores.Instance.RecuperarProductos();
            List<Producto> productos = new List<Producto>();
            foreach (var producto in productosTotales)
            {
                var existeProductoEnProveedor = proveedor.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProductoEnProveedor == null)
                {
                    productos.Add(producto);
                }
            }

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
            dgvProductosTotales.DataSource = productosParaMostrar;
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El codigo no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La direccion no puede ser nula");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtContacto.Text))
            {
                MessageBox.Show("El contacto no puede ser nulo");
                return false;
            }
            return true;
        }
    }
}
