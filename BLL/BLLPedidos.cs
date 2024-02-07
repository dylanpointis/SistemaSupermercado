using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using BE;
using System.Windows.Forms;

namespace BLL
{
    public class BLLPedidos: Factura<string>
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Pedidos");
            return dt;
        }

        public DataTable traerTablaSegunIdCliente(int idCliente)
        {
            DataTable dt = dal.traerTablaQuery($"SELECT * FROM Pedidos where id_cliente = {idCliente}");
            return dt;
        }

        public DataTable traerTablaPedido_Producto(int idPedido)
        {
            DataTable dt = dal.traerTablaQuery($"SELECT * FROM Pedido_Producto where id_pedido = {idPedido}");
            return dt;
        }

        public int AgregarPedido(Pedidos pedido)
        {
            //Ejecuta el comando INSERT y devuelve el ID autoincrementable con SELECT SCOPE_IDENTITY();
            int Id = dal.EjecutarComandoYTraerID($"INSERT INTO Pedidos (id_cliente, Fecha, MetodoPago, Total) VALUES ({pedido.id_cliente}, '{pedido.Fecha}', '{pedido.MetodoPago}', {pedido.Total}); SELECT SCOPE_IDENTITY();");
            return Id;
        }

        public void AgregarItem(int idPedido,Item item)
        {
            dal.EjecutarComando($"INSERT INTO Pedido_Producto VALUES ({idPedido}, {item.idProducto}, {item.cantidad})");
        }

        public void DarBaja(int IdPedido)
        {
            dal.EjecutarComando($"DELETE FROM Pedido_Producto where id_pedido = {IdPedido}"); //Elimina de la tabla Intermedia Pedido_Producto
            dal.EjecutarComando($"DELETE FROM Pedidos where id_pedido = {IdPedido}"); //Elimina de la tabla principal Pedidos        
        }

        public void GenerarFactura(string idPedido, string fecha, string total)
        {
            MessageBox.Show($"Factura del pedido ID: {idPedido}\nMonto: {total}\nFecha: {fecha}");
        }
    }
}
