using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public string Direccion { get; set; }
        public string Contacto { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public bool AgregarProductoDeProveedor(Producto producto)
        {
            var existe = Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
            if (existe == null)
            {
                Productos.Add(producto);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarProductoDeProveedor(Producto producto)
        {
            var existe = Productos.FirstOrDefault(c => c.Codigo == producto.Codigo);
            if (existe != null)
            {
                Productos.Remove(producto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
