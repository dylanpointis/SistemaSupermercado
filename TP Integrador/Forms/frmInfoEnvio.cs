using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace TP_Integrador
{
    public partial class frmInfoEnvio : Form
    {
        private Pedidos pedido;
        List<Item> listaCarrito;

        public frmInfoEnvio(Pedidos pedidoRecibido, List<Item> listaCarritoRecibida)
        {
            listaCarrito = listaCarritoRecibida;
            pedido = pedidoRecibido;
            InitializeComponent();
        }


        BLLPedidos bllPedido = new BLLPedidos();
        BLLEnvios bllEnvios = new BLLEnvios();
        BLLProductos bllProductos = new BLLProductos();


        private void cmbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbOpcion.Text == "Envío a sucursal del Correo")
            {
                label4.Visible = true; //Muestra los botones del correo
                cmbCorreo.Visible = true;

                label2.Visible = false; //Oculta el textBox de la direccion domicilio
                txtDirección.Visible = false;
            }
            else
            {
                label2.Visible = true;
                txtDirección.Visible = true;

                label4.Visible = false;
                cmbCorreo.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Inserta un nuevo pedido y guarda el ID de la primary key auto incrementable
            int idPedido = bllPedido.AgregarPedido(pedido);
            bllPedido.GenerarFactura(idPedido.ToString(), pedido.Fecha, pedido.Total.ToString());

            foreach (Item item in listaCarrito)
            {
                bllPedido.AgregarItem(idPedido, item);

                //Reduce el stock del producto
                int cantStock = bllProductos.ConsultarCantStock(item.idProducto);
                bllProductos.EditarStock(item.idProducto, cantStock - item.cantidad );
            }

            if(cmbOpcion.Text == "Envío a domicilio")
            {
                Envios envio = new Envios(idPedido, "Esperando a ser programado por un empleado", "-", txtDirección.Text, txtLocalidad.Text, cmbOpcion.Text);
                bllEnvios.AgregarEnvio(envio);
            }
            else //Envio a sucursal del Correo
            {
                Envios envio = new Envios(idPedido, "Esperando a ser programado por un empleado", "-", cmbCorreo.Text, txtLocalidad.Text, cmbOpcion.Text);
                bllEnvios.AgregarEnvio(envio);
            }
           

            MessageBox.Show("Compra exitosa");
            this.Close();
        }

        private void frmInfoEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
