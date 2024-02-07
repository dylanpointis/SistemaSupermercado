using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Descuento
    {
        public int id_descuento { get; set; }
        public int id_producto { get; set; }
        public int Porcentaje { get; set; }
        public string duracion { get; set; }

        public Descuento(int id_producto, int porcentaje, string duracion)
        {
            this.id_producto = id_producto;
            Porcentaje = porcentaje;
            this.duracion = duracion;
        }
    }
}
