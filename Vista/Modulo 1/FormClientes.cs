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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form formCliente = new FormCliente();
            formCliente.ShowDialog();
            ActualizarVista();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                Form formCliente = new FormCliente(cliente);
                formCliente.ShowDialog();
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("No hay nada para Modificar");
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                var eliminado = ControladoraClientes.Instance.EliminarCliente(cliente);
                if (eliminado)
                {
                    MessageBox.Show("Cliente Eliminado con Exito");
                    ActualizarVista();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Cliente");
                }
            }
            else
            {
                MessageBox.Show("No hay nada para eliminar");
            }
        }

        private void ActualizarVista()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ControladoraClientes.Instance.RecuperarClientes();
        }
    }
}
