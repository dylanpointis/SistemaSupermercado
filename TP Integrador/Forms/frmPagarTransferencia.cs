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

namespace TP_Integrador
{
    public partial class frmPagarTransferencia : Form
    {
        Pedidos pedido;
        List<Item> listaCarrito;

        public frmPagarTransferencia(Pedidos pedidoRecibido, List<Item> listaCarritoRecibida)
        {
            listaCarrito = listaCarritoRecibida;
            pedido = pedidoRecibido;
            InitializeComponent();
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            lblMonto.Text += pedido.Total.ToString();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago exitoso");
            frmInfoEnvio frm = new frmInfoEnvio(pedido, listaCarrito);
            frm.Show();
            this.Close();
        }
    }
}
