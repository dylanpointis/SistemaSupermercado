using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pedidos
    {
        public int id_pedido { get; set; }
        public int id_cliente { get; set; }
        public string Fecha { get; set; }

        public string MetodoPago { get; set; }

        public decimal Total { get; set; }

        public Pedidos(int id_cliente, string fecha, string metodoPago, decimal total)
        {
            this.id_cliente = id_cliente;
            Fecha = fecha;
            MetodoPago = metodoPago;
            Total = total;
        }
    }
}
