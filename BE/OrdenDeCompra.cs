using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrdenDeCompra
    {
        public int idProducto { get; set; }
        public int CantAReponer { get; set; }
        public string FechaEntrga { get; set; }
        public string LugarEntrega { get; set; }

        public OrdenDeCompra(int idProducto, int cantAReponer, string fechaEntrga, string lugarEntrega)
        {
            this.idProducto = idProducto;
            CantAReponer = cantAReponer;
            FechaEntrga = fechaEntrga;
            LugarEntrega = lugarEntrega;
        }
    }
}
