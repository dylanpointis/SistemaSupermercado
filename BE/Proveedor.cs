using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public string Nombre { get; set; }
        public int NumTelefono { get; set; }

        public Proveedor(string nombre, int numTelefono)
        {
            Nombre = nombre;
            NumTelefono = numTelefono;
        }
    }
}
