using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Patente: Componente
    {

        public Patente(string nombre): base(nombre)
        {

        }

        public override void AgregarHijo(Componente comp)
        {
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }
    }
}
