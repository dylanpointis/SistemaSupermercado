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


namespace TP_Integrador.Forms
{
    public partial class frmProgramarEnvios : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();
        public frmProgramarEnvios()
        {
            InitializeComponent();
        }

        BLLEnvios bllEnvios = new BLLEnvios();
        BLLLogistica bllLogistica = new BLLLogistica();

        private void frmProgramarEnvios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            grillaEnvios.Columns[0].Width = 50; grillaEnvios.Columns[1].Width = 40; grillaEnvios.Columns[2].Width = 40; grillaEnvios.Columns[3].Width = 40; grillaLogistica.Columns[0].Width = 50;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void btnProgramarEnvio_Click(object sender, EventArgs e)
        {
            //ID EMPLEADO, ID_LOGISTICA, ESTADO A "Esperando preparación", Fecha de envío
            
            try
            {
                if(grillaEnvios.CurrentRow.Cells[4].Value.ToString() == "Esperando a ser programado por un empleado")
                {
                    int idLogistica = Convert.ToInt32(grillaLogistica.CurrentRow.Cells[0].Value);
                    int idEnvio = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[0].Value);


                    bllEnvios.ProgramarEnvio(idEnvio, user.IDUser, idLogistica, "En preparación", dateTimePicker1.Value.ToString("dd-MM-yyyy"));

                    ActualizarGrilla();
                }
                else { MessageBox.Show("El envío ya ha sido programado"); }
                
            }catch(Exception ex) { MessageBox.Show("Seleccione un envio y una empresa de logistica"); }
           
        }

        private void ActualizarGrilla()
        {
            grillaEnvios.DataSource = bllEnvios.traerTabla();
            grillaLogistica.DataSource = bllLogistica.traerTabla();

        }

        private void grillaEnvios_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaEnvios.SelectedRows.Count > 0)
            {
                //int idEnvio = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[0].Value);
                string Estado = grillaEnvios.CurrentRow.Cells[4].Value.ToString();


                if (Estado == "Esperando a ser programado por un empleado")
                {
                    btnProgramarEnvio.Visible = true; btnEditarEstado.Visible = false; txtEstado.Visible = false; label3.Visible = false; dateTimePicker1.Visible = true ;label4.Visible = true;
                }
                else
                {
                    btnProgramarEnvio.Visible = false; btnEditarEstado.Visible = true; txtEstado.Visible = true; label3.Visible = true; dateTimePicker1.Visible = false; label4.Visible = false;
                }
            
            }
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEstado.Text != "")
                {
                    int idEnvio = Convert.ToInt32(grillaEnvios.CurrentRow.Cells[0].Value);
                    bllEnvios.EditarEstado(idEnvio, txtEstado.Text);
                    ActualizarGrilla();
                }
                else { MessageBox.Show("Seleccione un estado"); }      
            }
            catch(Exception ex) { MessageBox.Show("Error al editar estado, asegurese de seleccionar un envío en la grilla"); }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
