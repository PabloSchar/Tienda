using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public Categoria Categoria { get; set; }

        public void AjustarStock(int stock)
        {
            Stock += stock; 
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            decimal descuento = Precio * (porcentaje / 100);

            Precio -= descuento;
        }
    }
}
