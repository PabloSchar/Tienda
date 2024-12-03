using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraClientes
    {
        private static readonly Lazy<ControladoraClientes> instance = new Lazy<ControladoraClientes>(() => new ControladoraClientes());
        public static ControladoraClientes Instance => instance.Value;

        private DBCreacion db;
        private ControladoraClientes()
        {
            db = new DBCreacion();
        }

        public ReadOnlyCollection<Cliente> RecuperarClientes()
        {
            try
            {
                return db.Clientes.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Cliente>(new List<Cliente>());
            }
        }

        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                var existeCliente = db.Clientes.FirstOrDefault(c => c.Codigo == cliente.Codigo);
                if (existeCliente == null)
                {
                    db.Clientes.Add(cliente);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool ModificarCliente(Cliente cliente)
        {
            try
            {
                var existeCliente = db.Clientes.FirstOrDefault(c => c.Codigo == cliente.Codigo);
                if (existeCliente != null)
                {
                    db.Clientes.Update(cliente);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarCliente(Cliente cliente)
        {
            try
            {
                var existeCliente = db.Clientes.FirstOrDefault(c => c.Codigo == cliente.Codigo);
                if (existeCliente != null)
                {
                    db.Clientes.Remove(cliente);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
