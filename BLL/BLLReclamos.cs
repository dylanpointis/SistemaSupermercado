using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using BE;
using System.Data.SqlClient;

namespace BLL
{
    public class BLLReclamos
    {

        DalConexion dal = new DalConexion();

        public DataTable TraerTabla()
        {
            DataTable tabla = dal.TraerTabla("Reclamos");
            return tabla;

        }
        public void AgregarReclamos(Reclamos REC)
        {
            SqlParameter[] parametros = new SqlParameter[]
          {
                new SqlParameter("@idCliente", REC.ID_Cliente),
                new SqlParameter("@Categoria", REC.Categoria),
                new SqlParameter("@Descripcion", REC.Descripcion)
          };

            dal.EjecutarProcAlmacenado("AltaReclamo", parametros);
        }

        public void EliminarReclamo(int id)
        {
            dal.EjecutarComando($"DELETE FROM Reclamos WHERE id_reclamo = {id}");
        }

        public void EditarReclamo(int idReclamo, Reclamos reclamo)
        {
            dal.EjecutarComando($"UPDATE Reclamos SET id_cliente = {reclamo.ID_Cliente}, Categoria = '{reclamo.Categoria}', Descripcion = '{reclamo.Descripcion}' where id_reclamo = {idReclamo}");
        }
    }
}
