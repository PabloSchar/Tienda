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
    public class ControladoraFacturasEnIntervalo
    {
        private static readonly Lazy<ControladoraFacturasEnIntervalo> instance = new Lazy<ControladoraFacturasEnIntervalo>(() => new ControladoraFacturasEnIntervalo());
        public static ControladoraFacturasEnIntervalo Instance => instance.Value;

        private DBCreacion db;
        private ControladoraFacturasEnIntervalo()
        {
            db = new DBCreacion();
        }

        public ReadOnlyCollection<Factura> ObtenerFacturasEnIntervalo(DateTime Inicio, DateTime fin)
        {
            List<Factura> facturas = RecuperarFacturas();
            //obtengo las facturas entre las fechas dadas
            List<Factura> facturasDelCliente = facturas.Where(f => f.Fecha >= Inicio && f.Fecha <= fin).ToList();

            return facturasDelCliente.AsReadOnly();
        }

        private List<Factura> RecuperarFacturas()
        {
            try
            {
                return db.Facturas.Include(c => c.Cliente).Include(d => d.DetalleDeFacturas).ToList();
            }
            catch
            {
                return new List<Factura>();
            }
        }
    }
}
