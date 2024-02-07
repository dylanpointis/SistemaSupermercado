using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_Integrador
{
    public partial class frmPagarTarjeta : Form
    {
        private Pedidos pedido;
        List<Item> listaCarrito;

        public frmPagarTarjeta(Pedidos pedioRecibido, List<Item> listaCarritoRecibida)
        {
            pedido = pedioRecibido;
            listaCarrito = listaCarritoRecibida;
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(txtTitular.Texto != "" && txtCodigo.Text != "" && txtNumTarjeta.Texto != "")
            {
                MessageBox.Show("Pago exitoso");
                frmInfoEnvio frm = new frmInfoEnvio(pedido, listaCarrito);
                frm.Show();
                this.Close();
            }
            else { MessageBox.Show("LLene los campos solicitados"); }
        }



        //SOLO NUMEROS
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtCodigo.Text.Length < 3 || char.IsControl(e.KeyChar)) //Solo hasta 3 numeros. Se usa el char.IsControl para poder usar la tecla Borrar
            {
                Regex regex = new Regex(@"[^0-9\b]"); // EXPRESION REGULAR PARA SOLO NUMEROS
                if (regex.IsMatch(e.KeyChar.ToString()))
                {
                    e.Handled = true;
                }
            }
            else { e.Handled = true; }
        }

        private void frmPagarTarjeta_Load(object sender, EventArgs e)
        {
            lblMonto.Text += pedido.Total.ToString();
        }
    }
}
