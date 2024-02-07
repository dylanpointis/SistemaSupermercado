using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProductos
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Productos");
            return dt;
        }

        public void AltaProducto(Producto prod)
        {
           SqlParameter[] parametros = new SqlParameter[]
           {
                new SqlParameter("@Precio", prod.Precio),
                new SqlParameter("@Descripcion", prod.Descripcion)
           };

            dal.EjecutarProcAlmacenado("AltaProducto", parametros);
        }

        public void BajaProducto(int idProd)
        {
            dal.EjecutarComando($"DELETE FROM Productos where id_producto = {idProd}");
        }

        public void EditarProducto(Producto prod)
        {
           SqlParameter[] parametros = new SqlParameter[]
           {
               new SqlParameter("@id_producto", prod.id_producto),
                new SqlParameter("@Precio", prod.Precio),
                new SqlParameter("@Descripcion", prod.Descripcion)
           };

            dal.EjecutarProcAlmacenado("EditarProducto", parametros);
        }

        public void EditarStock(int idProd, int cantStock)
        {
            dal.EjecutarComando($"update Productos set CantStock = {cantStock} where id_producto = {idProd};");
        }

        public void AgregarItemOrdenCompra(int id_proveedor, OrdenDeCompra item)
        {
            dal.EjecutarComando($"INSERT INTO OrdenDeCompra VALUES ({id_proveedor}, {item.idProducto}, {item.CantAReponer}, '{item.FechaEntrga}', '{item.LugarEntrega}')");
        }

        public int ConsultarCantStock(int idProd)
        {
            int CantStock = dal.ConsultarNumero($"SELECT CantStock from Productos where id_producto = {idProd}");
            return CantStock;
        }

        public DataTable BuscarDescripcionProducto(string descripcionProducto) //Esta funcion sirve para filtrar los productos segun su Descripcion
        {
            descripcionProducto = descripcionProducto + "%"; //Se le agrega un % y se utiliza la palabra LIKE para filtrar por las Descripciones que comienzen con ciertas letras
            DataTable tabla= dal.traerTablaQuery($"SELECT * FROM Productos where Descripcion LIKE '{descripcionProducto}';");//en vez de = se usa LIKE
            return tabla;
        }
    }
}
