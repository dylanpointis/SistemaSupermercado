using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public abstract class Componente
    {
        public string Nombre { get; set; }
        public Componente(string nombre)
        {
            Nombre = nombre;
        }
        public abstract void AgregarHijo(Componente comp);

        public abstract IList<Componente> ObtenerHijos();
    }
}
