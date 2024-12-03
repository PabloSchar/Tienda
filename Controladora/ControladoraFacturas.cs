using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraFacturas
    {
        private static readonly Lazy<ControladoraFacturas> instance = new Lazy<ControladoraFacturas>(() => new ControladoraFacturas());
        public static ControladoraFacturas Instance => instance.Value;

        private DBCreacion db;
        private ControladoraFacturas()
        {
            db = new DBCreacion();
        }

        public ReadOnlyCollection<Producto> RecuperarProductos()
        {
            try
            {
                return db.Productos.Include(c => c.Categoria).ToList().AsReadOnly();
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

        public bool AgregarFactura(Factura factura)
        {
            try
            {
                var existeFactura = db.Facturas.FirstOrDefault(c => c.Numero == factura.Numero);
                if (existeFactura == null)
                {
                    int numeroFactura = ObtenerUltimoNumeroFactura();
                    factura.Numero = numeroFactura + 1;
                    db.Facturas.Add(factura);
                    // Actualiza el stock de los productos
                    foreach (var detalle in factura.DetalleDeFacturas)
                    {
                        var producto = db.Productos.Find(detalle.Producto.Id);
                        if (producto != null)
                        {
                            producto.Stock -= detalle.Cantidad;
                            db.Productos.Update(producto);
                        }
                    }
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

        private int ObtenerUltimoNumeroFactura()
        {
            var ultimaFactura = db.Facturas.OrderByDescending(f => f.Numero).FirstOrDefault();
            return ultimaFactura != null ? ultimaFactura.Numero : 0; // Si no hay facturas, retorno 0
        }

    }
}
