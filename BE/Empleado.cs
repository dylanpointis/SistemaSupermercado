using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Empleado: Usuario
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string horario { get; set; }
        public string rolEmpleado { get; set; }
        public double sueldo { get; set; }


        public string NombreUsuario { get; set; }
        public string clave { get; set; }

        public Empleado(string nombre, string apellido, string horario, string rolEmpleado, double sueldo, string nombreUsuario, string Clave) : base(nombreUsuario, Clave)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.horario = horario;
            this.rolEmpleado = rolEmpleado;
            this.sueldo = sueldo;

            this.NombreUsuario = nombreUsuario;
            this.clave = Clave;
    }
    }
}
