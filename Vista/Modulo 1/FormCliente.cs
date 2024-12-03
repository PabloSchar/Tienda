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
    public partial class FormCliente : Form
    {
        private bool modifica = false;
        private Cliente cliente;
        public FormCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        public FormCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            modifica = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                cliente.Contacto = txtContacto.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Codigo = txtCodigo.Text;
                if (modifica)
                {
                    var modificado = ControladoraClientes.Instance.ModificarCliente(cliente);
                    if (modificado)
                    {
                        MessageBox.Show("Cliente Modificado con exito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el Cliente");
                    }
                }
                else
                {
                    var agregado = ControladoraClientes.Instance.AgregarCliente(cliente);
                    if (agregado)
                    {
                        MessageBox.Show("Cliente Agregado con exito");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al Agregar el Cliente");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool VerificarDatos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("El codigo no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtContacto.Text))
            {
                MessageBox.Show("El Contacto no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede ser nulo");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La Direccion no puede ser nula");
                return false;
            }
            return true;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            if (modifica)
            {
                txtCodigo.Enabled = false;
                txtContacto.Text = cliente.Contacto;
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtCodigo.Text = cliente.Codigo;
            }
        }
    }
}
