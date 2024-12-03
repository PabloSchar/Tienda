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
    public class ControladoraProductos
    {
        private static readonly Lazy<ControladoraProductos> instance = new Lazy<ControladoraProductos>(() => new ControladoraProductos());
        public static ControladoraProductos Instance => instance.Value;

        private DBCreacion db;
        private ControladoraProductos() 
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

        public ReadOnlyCollection<Categoria> RecuperarCategorias()
        {
            try
            {
                return db.Categorias.ToList().AsReadOnly();
            }
            catch
            {
                return new ReadOnlyCollection<Categoria>(new List<Categoria>());
            }
        }

        public bool AgregarProducto(Producto producto)
        {
            try
            {
                var existeProducto = db.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto == null)
                {
                    db.Productos.Add(producto);
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

        public bool AgregarProducto(ProductoImportado producto)
        {
            try
            {
                var existeProducto = db.ProductosImportados.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto == null)
                {
                    db.ProductosImportados.Add(producto);
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

        public bool ModificarProducto(Producto producto)
        {
            try
            {
                var existeProducto = db.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto != null)
                {
                    db.Productos.Update(producto);
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
        public bool ModificarProducto(ProductoImportado producto)
        {
            try
            {
                var existeProducto = db.ProductosImportados.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto != null)
                {
                    db.ProductosImportados.Update(producto);
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

        public bool EliminarProducto(Producto producto)
        {
            try
            {
                var existeProducto = db.Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto != null)
                {
                    db.Productos.Remove(producto);
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

        public bool EliminarProducto(ProductoImportado producto)
        {
            try
            {
                var existeProducto = db.ProductosImportados.FirstOrDefault(c => c.Codigo == producto.Codigo);
                if (existeProducto != null)
                {
                    db.ProductosImportados.Remove(producto);
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
