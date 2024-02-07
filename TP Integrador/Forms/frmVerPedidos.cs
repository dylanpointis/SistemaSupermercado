using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador.Forms
{
    public partial class frmVerPedidos : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();

        public frmVerPedidos()
        {
            InitializeComponent();
        }
        BLLPedidos bllPedidos = new BLLPedidos();

        private void frmVerPedidos_Load(object sender, EventArgs e)
        {
            label2.Text = "Pedidos de " + user.NombreUsuario;
            grillaPedidos.DataSource = bllPedidos.traerTablaSegunIdCliente(user.IDUser);
        }

        private void grillaPedidos_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaPedidos.SelectedRows.Count > 0)
            {
                try
                {
                    int idPedido = Convert.ToInt32(grillaPedidos.CurrentRow.Cells[0].Value);
                    grillaPedido_Producto.DataSource = bllPedidos.traerTablaPedido_Producto(idPedido);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
