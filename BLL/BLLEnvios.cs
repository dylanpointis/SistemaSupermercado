using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLLEnvios
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Envios");
            return dt;
        }

        public DataTable traerTablaSegunCliente(int id) //Busca en la tabla ENVIOS los PEDIDOS que coinciden con el id_cliente. Para esto va desde la tabla Envios a la tabla Pedidos y busca los que coincidan
        {
            DataTable dataTable = dal.traerTablaQuery($"SELECT * FROM Envios WHERE id_pedido IN (SELECT id_pedido FROM Pedidos WHERE id_cliente = {id})");
            return dataTable;
        }


        public void AgregarEnvio(Envios envio) //ID EMPLEADO e ID LOGISTICA  NULL PORQUE TODAVIA NO FUE PROGRAMADO EL ENVIO
        {
            dal.EjecutarComando($"INSERT INTO Envios VALUES ({envio.id_pedido}, null, null, '{envio.estado}','{envio.fecha}','{envio.direccion}','{envio.localidad}','{envio.opcionEnvio}')");
        }


        public void ProgramarEnvio(int idEnvio, int iDEmpleado, int idLogistica, string Estado, string FechaEnvio)
        {
            dal.EjecutarComando($"update Envios SET id_empleado = {iDEmpleado}, id_logistica = {idLogistica}, Estado = '{Estado}', FechaDeEnvio = '{FechaEnvio}' WHERE id_envio = {idEnvio};");
        }

        public void DarBaja(int idEnvio)
        {
            dal.EjecutarComando($"DELETE FROM Envios where id_envio = {idEnvio}");
        }

        public void EditarEstado(int idEnvio, string Estado)
        {
            dal.EjecutarComando($"update Envios SET Estado = '{Estado}' WHERE id_envio = {idEnvio};");
        }
    }
}
