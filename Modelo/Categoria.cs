using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<Producto> Productos { get; set; } = new List<Producto>();

        public bool AgregarProductoDeCategoria(Producto producto)
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

        public bool EliminarProductoDeCategoria(Producto producto)
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
