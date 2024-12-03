using Controladora;
using Microsoft.EntityFrameworkCore.Update;
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
    public partial class FormCategoria : Form
    {
        private bool modifica = false;
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            ActualizarVista();
            gBoxCategoria.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var categorias = ControladoraCategorias.Instance.RecuperarCategorias();
                if (modifica)
                {
                    var categoriaCodigo = dgvCategorias.CurrentRow.Cells["Codigo"].Value;
                    var categoria = categorias.FirstOrDefault(c => c.Codigo == categoriaCodigo);
                    categoria.Codigo = txtCodigo.Text;
                    categoria.Descripcion = txtDescripcion.Text;
                    categoria.Nombre = txtNombre.Text;
                    var modificado = ControladoraCategorias.Instance.ModificarCategoria(categoria);
                    if (modificado)
                    {
                        MessageBox.Show("Categoria Modificada con exito");
                        gBoxCategoria.Enabled = false;
                        gBoxCategorias.Enabled = true;
                        ActualizarVista();
                        txtCodigo.Enabled = true;
                        txtCodigo.Text = null;
                        txtNombre.Text = null;
                        txtDescripcion.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la categoria");
                    }
                }
                else
                {
                    var categoria = new Categoria();
                    categoria.Codigo = txtCodigo.Text;
                    categoria.Descripcion = txtDescripcion.Text;
                    categoria.Nombre = txtNombre.Text;
                    var agregado = ControladoraCategorias.Instance.AgregarCategoria(categoria);
                    if (agregado)
                    {
                        MessageBox.Show("Categoria Agregada con exito");
                        gBoxCategoria.Enabled = false;
                        gBoxCategorias.Enabled = true;
                        ActualizarVista();
                        txtCodigo.Enabled = true;
                        txtCodigo.Text = null;
                        txtNombre.Text = null;
                        txtDescripcion.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al Agregar la categoria");
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarDatos()
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
            return true;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            gBoxCategoria.Enabled = true;
            gBoxCategorias.Enabled = false;
            modifica = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.Rows.Count > 0)
            {
                var categorias = ControladoraCategorias.Instance.RecuperarCategorias();
                var categoriaCodigo = dgvCategorias.CurrentRow.Cells["Codigo"].Value;
                var categoria = categorias.FirstOrDefault(c => c.Codigo == categoriaCodigo);
                txtCodigo.Enabled = false;
                txtCodigo.Text = categoria.Codigo.ToString();
                txtNombre.Text = categoria.Nombre.ToString();
                txtDescripcion.Text = categoria.Descripcion.ToString();
                gBoxCategoria.Enabled = true;
                gBoxCategorias.Enabled = false;
                modifica = true;
            }
        }

        private void ActualizarVista()
        {
            dgvCategorias.DataSource = null;
            var categorias = ControladoraCategorias.Instance.RecuperarCategorias();
            var categoriasParaMostrar = categorias.Select(f => new
            {
                f.Id,
                f.Codigo,
                f.Nombre,
                f.Descripcion
            }).ToList();
            dgvCategorias.DataSource = categoriasParaMostrar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtDescripcion.Text = null;
            gBoxCategoria.Enabled = false;
            gBoxCategorias.Enabled = true;
        }
    }
}
