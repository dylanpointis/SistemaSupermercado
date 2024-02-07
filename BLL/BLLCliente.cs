using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {

        DalConexion dal = new DalConexion();

        public void BajaCliente(int id)
        {
            dal.EjecutarComando($"delete from Clientes where id_cliente = {id}");
        }

        public void RegistrarCliente(Cliente cli)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idCliente", cli.id_Cliente),
                new SqlParameter("@nombre", cli.Nombre),
                new SqlParameter("@apellido", cli.Apellido)
            };

            dal.EjecutarProcAlmacenado("AltaCliente", parametros);
        }
    }
}
