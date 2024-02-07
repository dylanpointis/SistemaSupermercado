using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEmpleado
    {
        DalConexion dal = new DalConexion();

        public void BajaEmpleado(int id)
        {
            dal.EjecutarComando($"delete from Empleados where id_empleado = {id}");
        }

        public void RegistrarEmpleado(Empleado emp)
        {
            dal.EjecutarComando($"INSERT INTO Empleados VALUES ({emp.idEmpleado},'{emp.nombre}','{emp.apellido}','{emp.horario}',{emp.sueldo});");
        }
    }
}
