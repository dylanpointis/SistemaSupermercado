using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLDescuentos
    {
        DalConexion dal = new DalConexion();

        public void Agregar(Descuento descuento)
        {
          SqlParameter[] parametros = new SqlParameter[]
          {
              new SqlParameter("@idProductos", descuento.id_producto),
              new SqlParameter("@Porcentaje", descuento.Porcentaje),
              new SqlParameter("@Duracion", descuento.duracion)
          };
          dal.EjecutarProcAlmacenado("AltaDescuentos", parametros);
        }

        public void Baja(int idDescuento)
        {
            dal.EjecutarComando($"DELETE from Descuentos where id_descuento ={idDescuento}");
        }

        public int ConsultarDescuento(int idProd)
        {
            int descuento = dal.ConsultarNumero($"SELECT PorcentajeDescuento from Descuentos where id_producto = {idProd}");
            return descuento;
        }

        public void Editar(Descuento desc)
        {
            dal.EjecutarComando($"Update Descuentos set PorcentajeDescuento = {desc.Porcentaje}, FechaLimite = '{desc.duracion}' where id_descuento = {desc.id_descuento}");
        }

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Descuentos");
            return dt;
        }
    }
}
