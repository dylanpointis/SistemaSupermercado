using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reclamos
    {
        public int ID_Reclamos { get; set; }
        
        public int ID_Cliente { get; set; }

        public string Categoria { get; set; }

        public string Descripcion { get; set; }


        public Reclamos(string categoria, string descripcion)
        {
            Categoria = categoria;
            Descripcion=descripcion;

        }



    }
}
