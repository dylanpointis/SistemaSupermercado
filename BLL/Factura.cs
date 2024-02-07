using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    interface Factura<T>
    {
        void GenerarFactura(T idPedido, T descripcion, T costo);
    }
}
