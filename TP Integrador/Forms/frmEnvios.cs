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
using BE;

namespace TP_Integrador
{
    public partial class frmEnvios : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();
        public frmEnvios()
        {
            InitializeComponent();
        }

        BLLEnvios bllEnvios = new BLLEnvios();
        

        private void frmEnvios_Load(object sender, EventArgs e)
        {
            if (user.Rol == "Cliente") { label1.Text += user.NombreUsuario; }
            ActualizarGrilla();
            grillaEnvios.Columns[0].Width = 50; grillaEnvios.Columns[1].Width = 50; grillaEnvios.Columns[2].Width = 50; grillaEnvios.Columns[3].Width = 50; grillaEnvios.Columns[4].Width = 170; grillaEnvios.Columns[6].Width = 150; grillaEnvios.Columns[8].Width = 150;
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas dar de baja el pedido", "Dar de baja", MessageBoxButtons.YesNo);
            if (MensajeSIoNO == DialogResult.Yes)
            {
                try
                {
                    int IdEnvio = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[0].Value);
                    int IdPedido = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[1].Value);

                    bllEnvios.DarBaja(IdEnvio);

                    BLLPedidos bLLPedidos = new BLLPedidos();
                    bLLPedidos.DarBaja(IdPedido);

                    ActualizarGrilla();
                }catch(Exception ex) { MessageBox.Show("Error al dar de baja, Asegurese de seleccionar el envío en la grilla"); }
                
            }
        }

        private void ActualizarGrilla()
        {
            if (user.Rol == "Cliente") //SI ES UN CLIENTE SOLO MUESTRA SUS ENVIOS
            {

                grillaEnvios.DataSource = bllEnvios.traerTablaSegunCliente(user.IDUser);
            }
            else { grillaEnvios.DataSource = bllEnvios.traerTabla(); } //SI ES ADMIN O EMPLEADO MUESTRA TODOS LOS ENVIOS
        }
    }
}
