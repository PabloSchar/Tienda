using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraInicial
    {
        private static readonly Lazy<ControladoraInicial> instance = new Lazy<ControladoraInicial>(() => new ControladoraInicial());
        public static ControladoraInicial Instance => instance.Value;

        private DBCreacion db;
        private ControladoraInicial()
        {
            db = new DBCreacion();
        }

        public ReadOnlyCollection<Producto> RecuperarProductos()
        {
            try
            {
                return db.Productos.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Producto>(new List<Producto>());
            }
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

        public ReadOnlyCollection<DetalleDeFactura> RecuperarDetallesFactura()
        {
            try
            {
                return db.DetalleDeFacturas.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<DetalleDeFactura>(new List<DetalleDeFactura>());
            }
        }

        public ReadOnlyCollection<Factura> RecuperarFacturas()
        {
            try
            {
                return db.Facturas.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Factura>(new List<Factura>());
            }
        }
    }
}
