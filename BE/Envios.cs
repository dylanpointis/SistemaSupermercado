using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Envios
    {
        public int id_envio { get; set; }
        public int id_pedido { get; set; }
        public int id_empleado { get; set; }

        public int id_logistica { get; set; }

        public string estado { get; set; }
        public string fecha { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string opcionEnvio { get; set; }

        public Envios(int id_Pedido, string Estado, string Fecha, string Direccion, string Localidad, string Opcion)
        {
            id_pedido = id_Pedido;
            estado = Estado;
            fecha = Fecha;
            direccion = Direccion;
            localidad = Localidad;
            opcionEnvio = Opcion;
        }
    }
}
