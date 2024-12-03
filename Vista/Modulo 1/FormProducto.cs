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
    public partial class FormProducto : Form
    {
        private Producto producto;
        private ProductoImportado productoImportado;
        private bool modifica = false;
        private bool eraProductoImportado = false;
        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto)
        {
            InitializeComponent();
            if (producto is ProductoImportado productoImportado)
            {
                this.productoImportado = productoImportado;
            }
            else
            {
                this.producto = producto;
            }
            modifica = true;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            GboxProductoImportado.Enabled = false;

            var categorias = ControladoraProductos.Instance.RecuperarCategorias();
            foreach ( var categoria in categorias )
            {
                cBoxCategoria.Items.Add(categoria.Codigo);
            }
            cBoxCategoria.DisplayMember = "Codigo";

            if (modifica)
            {
                txtCodigo.Enabled = false;
                if (producto == null)
                {
                    txtCodigo.Text = productoImportado.Codigo.ToString();
                    txtDescripcion.Text = productoImportado.Descripcion.ToString();
                    txtNombre.Text = productoImportado.Nombre.ToString();
                    txtPrecio.Text = productoImportado.Precio.ToString();
                    txtStock.Text = productoImportado.Stock.ToString();
                    checkImportado.Checked = true;
                    cBoxCategoria.SelectedItem = productoImportado.Categoria.Codigo;
                    eraProductoImportado = true;
                }
                else
                {
                    txtCodigo.Text = producto.Codigo.ToString();
                    txtDescripcion.Text = producto.Descripcion.ToString();
                    txtNombre.Text = producto.Nombre.ToString();
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStock.Text = producto.Stock.ToString();
                    cBoxCategoria.SelectedItem = producto.Categoria.Codigo;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosProducto())
            {
                if (modifica)
                {
                    // si estoy modificando, puede que el producto sea importado y sea cambiado a no importado o viceversa
                    if (!checkImportado.Checked)
                    {
                        if (eraProductoImportado) //elimino el producto importado y creo el producto
                        {
                            var eliminado = ControladoraProductos.Instance.EliminarProducto(productoImportado);
                            if (eliminado)
                            {
                                producto = new Producto();
                                producto.Nombre = txtNombre.Text;
                                producto.Codigo = txtCodigo.Text;
                                producto.Descripcion = txtDescripcion.Text;
                                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                                producto.Stock = Convert.ToInt32(txtStock.Text);
                                var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                                producto.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);

                                var agregado = ControladoraProductos.Instance.AgregarProducto(producto);
                                if (agregado)
                                {
                                    MessageBox.Show("Producto Modificado con exito");
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al modificar el Producto");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el Producto");
                            }
                        }
                        else
                        {
                            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                            producto.Nombre = txtNombre.Text;
                            producto.Codigo = txtCodigo.Text;
                            producto.Descripcion = txtDescripcion.Text;
                            producto.Stock = Convert.ToInt32(txtStock.Text);
                            var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                            producto.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);

                            var modificado = ControladoraProductos.Instance.ModificarProducto(producto);
                            if (modificado)
                            {
                                MessageBox.Show("Producto Modificado con exito");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el Producto");
                            }
                        }
                    }
                    else //habilito el gbox producto importado
                    {
                        IntercambiarGBox();
                        if (eraProductoImportado)
                        {
                            txtCodigoImportado.Text = productoImportado.CodigoImportacion.ToString();
                        }
                    }
                }
                else //caso en el cual no modifico
                {
                    if (checkImportado.Checked)
                    {
                        IntercambiarGBox();
                    }
                    else
                    {
                        producto = new Producto();
                        producto.Nombre = txtNombre.Text;
                        producto.Codigo = txtCodigo.Text;
                        producto.Descripcion = txtDescripcion.Text;
                        producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                        producto.Stock = Convert.ToInt32(txtStock.Text);
                        var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                        producto.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);

                        var agregado = ControladoraProductos.Instance.AgregarProducto(producto);
                        if (agregado)
                        {
                            MessageBox.Show("Producto agregado con exito");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al agregar el Producto");
                        }
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarImportado_Click(object sender, EventArgs e)
        {
            if (ValidarDatosProductoImportado())
            {
                if (modifica)
                {
                    if (!eraProductoImportado)
                    {
                        //Elimino el producto y creo un producto importado
                        var eliminado = ControladoraProductos.Instance.EliminarProducto(producto);
                        if (eliminado)
                        {
                            productoImportado = new ProductoImportado();
                            productoImportado.Precio = Convert.ToDecimal(txtPrecio.Text);
                            productoImportado.Nombre = txtNombre.Text;
                            productoImportado.Codigo = txtCodigo.Text;
                            productoImportado.Descripcion = txtDescripcion.Text;
                            productoImportado.Stock = Convert.ToInt32(txtStock.Text);
                            var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                            productoImportado.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);
                            productoImportado.CodigoImportacion = txtCodigoImportado.Text;

                            var agregado = ControladoraProductos.Instance.AgregarProducto(productoImportado);
                            if (agregado)
                            {
                                MessageBox.Show("Producto Modificado con exito");
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar el Producto");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el Producto");
                        }
                    }
                    else
                    {
                        productoImportado.Precio = Convert.ToDecimal(txtPrecio.Text);
                        productoImportado.Nombre = txtNombre.Text;
                        productoImportado.Codigo = txtCodigo.Text;
                        productoImportado.Descripcion = txtDescripcion.Text;
                        productoImportado.Stock = Convert.ToInt32(txtStock.Text);
                        var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                        productoImportado.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);
                        productoImportado.CodigoImportacion = txtCodigoImportado.Text;

                        var modificado = ControladoraProductos.Instance.ModificarProducto(productoImportado);
                        if (modificado)
                        {
                            MessageBox.Show("Producto Modificado con exito");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar el Producto");
                        }
                    }
                }
                else
                {
                    productoImportado = new ProductoImportado();
                    productoImportado.Precio = Convert.ToDecimal(txtPrecio.Text);
                    productoImportado.Nombre = txtNombre.Text;
                    productoImportado.Codigo = txtCodigo.Text;
                    productoImportado.Descripcion = txtDescripcion.Text;
                    productoImportado.Stock = Convert.ToInt32(txtStock.Text);
                    var categorias = ControladoraProductos.Instance.RecuperarCategorias();
                    productoImportado.Categoria = categorias.FirstOrDefault(c => c.Codigo == cBoxCategoria.SelectedItem);
                    productoImportado.CodigoImportacion = txtCodigoImportado.Text;

                    var agregado = ControladoraProductos.Instance.AgregarProducto(productoImportado);
                    if (agregado)
                    {
                        MessageBox.Show("Producto agregado con exito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el Producto");
                    }
                }
            }
        }

        private void btnCancelarImportado_Click(object sender, EventArgs e)
        {
            txtCodigoImportado.Text = null;
            IntercambiarGBox();
        }

        private void IntercambiarGBox()
        {
            if (GboxProducto.Enabled)
            {
                GboxProducto.Enabled = false;
                GboxProductoImportado.Enabled = true;
            }
            else
            {
                GboxProducto.Enabled = true;
                GboxProductoImportado.Enabled = false;
            }
        }

        private bool ValidarDatosProducto()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El codigo no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("La descripcion no puede ser nula");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("El Precio no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("El stock no puede ser nulo");
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out var precio))
            {
                MessageBox.Show("El precio debe ser un numero");
                return false;
            }
            if (!int.TryParse(txtStock.Text, out var stock))
            {
                MessageBox.Show("El Stock debe ser un numero");
                return false;
            }
            if (stock < 0)
            {
                MessageBox.Show("El Stock debe ser mayor o igual a 0");
                return false;
            }
            if (precio < 0)
            {
                MessageBox.Show("El Precio debe ser mayor o igual a 0");
                return false;
            }
            return true;
        }

        private bool ValidarDatosProductoImportado()
        {
            if (string.IsNullOrEmpty(txtCodigoImportado.Text))
            {
                MessageBox.Show("El codigo Importado no puede ser nulo");
                return false;
            }
            return true;
        }
    }
}
