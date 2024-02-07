using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Familia: Componente
    {
        private List<Componente> listaHijos;

        public Familia(string nombre): base(nombre)
        {
           listaHijos = new List<Componente>();
        }

        public override void AgregarHijo(Componente comp)
        {
            listaHijos.Add(comp);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return listaHijos.ToArray();
        }
    }
}
