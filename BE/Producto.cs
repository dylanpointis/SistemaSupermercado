using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int id_producto { get; set; }
        public double Precio { get; set; }

        public int CantStock { get; set; }
        public string Descripcion { get; set; }

        public Producto(double precio, int cantStock, string descripcion)
        {
            Precio = precio;
            CantStock = cantStock;
            Descripcion = descripcion;
        }
    }
}
