using BE.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public int IDUser { get; set; }

        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }

        public Familia familia;

        public Usuario(string nombreUsuario, string clave)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
        }
    }
}
