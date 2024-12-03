using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }

        public decimal Total => DetalleDeFacturas.Sum(d => d.SubTotal);

        public List<DetalleDeFactura> DetalleDeFacturas { get; set; } = new List<DetalleDeFactura>();

        public bool AgregarDetalleFactura(DetalleDeFactura detalleFactura)
        {
            var existe = DetalleDeFacturas.FirstOrDefault(c => c.Producto.Codigo == detalleFactura.Producto.Codigo);
            if (existe == null)
            {
                DetalleDeFacturas.Add(detalleFactura);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarDetalleFactura(DetalleDeFactura detalleFactura)
        {
            var existe = DetalleDeFacturas.FirstOrDefault(c => c.Producto.Codigo == detalleFactura.Producto.Codigo);
            if (existe != null)
            {
                DetalleDeFacturas.Remove(detalleFactura);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
