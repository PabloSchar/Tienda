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
    public class ControladoraProveedores
    {
        private static readonly Lazy<ControladoraProveedores> instance = new Lazy<ControladoraProveedores>(() => new ControladoraProveedores());
        public static ControladoraProveedores Instance => instance.Value;

        private DBCreacion db;
        private ControladoraProveedores()
        {
            db = new DBCreacion();
        }

        public ReadOnlyCollection<Proveedor> RecuperarProveedores()
        {
            try
            {
                return db.Proveedores.Include(c => c.Productos).ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Proveedor>(new List<Proveedor>());
            }
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

        public bool AgregarProveedor(Proveedor proveedor)
        {
            try
            {
                var existeProveedor = db.Proveedores.FirstOrDefault(c => c.Codigo == proveedor.Codigo);
                if (existeProveedor == null)
                {
                    db.Proveedores.Add(proveedor);
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

        public bool ModificarProveedor(Proveedor proveedor)
        {
            try
            {
                var existeProveedor = db.Proveedores.FirstOrDefault(c => c.Codigo == proveedor.Codigo);
                if (existeProveedor != null)
                {
                    db.Proveedores.Update(proveedor);
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

        public bool EliminarProveedor(Proveedor proveedor)
        {
            try
            {
                var existeProveedor = db.Proveedores.FirstOrDefault(c => c.Codigo == proveedor.Codigo);
                if (existeProveedor != null)
                {
                    db.Proveedores.Remove(proveedor);
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
