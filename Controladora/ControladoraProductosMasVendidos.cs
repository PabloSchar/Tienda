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
    public class ControladoraProductosMasVendidos
    {
        private static readonly Lazy<ControladoraProductosMasVendidos> instance = new Lazy<ControladoraProductosMasVendidos>(() => new ControladoraProductosMasVendidos());
        public static ControladoraProductosMasVendidos Instance => instance.Value;

        private DBCreacion db;
        private ControladoraProductosMasVendidos()
        {
            db = new DBCreacion();
        }

        public Dictionary<Producto, int> RecuperarProductos()
        {
            return ObtenerProductos();
        }

        private Dictionary<Producto, int> ObtenerProductos()
        {
            Dictionary<Producto, int> productosMasVendidos = new Dictionary<Producto, int>();
            List<DetalleDeFactura> detalleDeFacturas = RecuperarDetallesDeFactura();

            foreach (var detalle in detalleDeFacturas)
            {
                // Verifico si ya existe el producto en el diccionario
                var productoExistente = productosMasVendidos
                    .Keys
                    .FirstOrDefault(p => p.Codigo == detalle.Producto.Codigo);

                if (productoExistente != null)
                {
                    // Si ya está, sumo la cantidad al producto
                    productosMasVendidos[productoExistente] += detalle.Cantidad;
                }
                else
                {
                    // Si no está, agrego el producto con su cantidad de vendidos
                    productosMasVendidos.Add(detalle.Producto, detalle.Cantidad);
                }
            }

            // Ordeno el diccionario de mayor a menor según la cantidad de venta
            var productosOrdenados = productosMasVendidos
                .OrderByDescending(p => p.Value)
                .ToDictionary(p => p.Key, p => p.Value);

            return productosMasVendidos;

        }

        private List<DetalleDeFactura> RecuperarDetallesDeFactura()
        {
            try
            {
                return db.DetalleDeFacturas.Include(c => c.Producto).Include(d =>d.Producto.Categoria).ToList();
            }
            catch
            {
                return new List<DetalleDeFactura>();
            }
        }
    }
}
