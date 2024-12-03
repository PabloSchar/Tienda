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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Form formProveedor = new FormProveedor();
            formProveedor.ShowDialog();
            ActualizarVista();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.Rows.Count > 0)
            {
                var proveedor = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                Form formProveedor = new FormProveedor(proveedor);
                formProveedor.ShowDialog();
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay nada para Modificar");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.Rows.Count > 0)
            {
                var proveedor = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                var eliminado = ControladoraProveedores.Instance.EliminarProveedor(proveedor);
                if (eliminado)
                {
                    MessageBox.Show("Proveedor Eliminado con Exito");
                    ActualizarVista();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Proveedor");
                }
            }
            else
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        private void ActualizarVista()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = ControladoraProveedores.Instance.RecuperarProveedores();
        }
    }
}
