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
    public class ControladoraVentasEnIntervalo
    {
        private static readonly Lazy<ControladoraVentasEnIntervalo> instance = new Lazy<ControladoraVentasEnIntervalo>(() => new ControladoraVentasEnIntervalo());
        public static ControladoraVentasEnIntervalo Instance => instance.Value;

        private DBCreacion db;
        private ControladoraVentasEnIntervalo()
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

        public decimal ObtenerTotalVendidoIntervalo(Cliente cliente, DateTime Inicio, DateTime fin)
        {
            List<Factura> facturas = RecuperarFactura();
            //obtengo las facturas del cliente entre las fechas dadas
            List<Factura> facturasDelCliente = facturas.Where(f => f.Cliente.Codigo == cliente.Codigo && f.Fecha >= Inicio && f.Fecha <= fin).ToList();

            if (facturasDelCliente.Count == 0)
            {
                //no posee facturas entre las fechas
                return 0;
            }

            decimal totalVendido = facturasDelCliente.Sum(f => f.Total);
            return totalVendido;
        }

        private List<Factura> RecuperarFactura()
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
