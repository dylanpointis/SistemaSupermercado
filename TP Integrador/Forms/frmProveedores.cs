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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        BLLProveedores bllProv = new BLLProveedores();
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            grillaProveedores.DataSource = null;
            grillaProveedores.DataSource = bllProv.traerTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Texto != "" && txtNumero.Texto != "")
            {
                Proveedor prov = new Proveedor(txtNombre.Texto, Convert.ToInt32(txtNumero.Texto));
                bllProv.AltaProveedor(prov);
                ActualizarGrilla();
            }MessageBox.Show("Llene los campos");      
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try 
            { 
                DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas dar de baja el proveedor", "Dar de baja", MessageBoxButtons.YesNo);
                if (MensajeSIoNO == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(grillaProveedores.CurrentRow.Cells[0].Value);
                    bllProv.BajaProveedor(idProveedor);
                    ActualizarGrilla();
                }
            }catch(Exception ex) { MessageBox.Show("Error al eliminar, asegurese de seleccionar el proveedor en la grilla"); }
}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas editar el proveedor", "Editar", MessageBoxButtons.YesNo);
                if (MensajeSIoNO == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(grillaProveedores.CurrentRow.Cells[0].Value);
                    Proveedor prov = new Proveedor(txtNombre.Texto, Convert.ToInt32(txtNumero.Texto));
                    prov.id_proveedor = idProveedor;
                    bllProv.EditarProveedor(prov);
                    ActualizarGrilla();
                }
            }catch(Exception ex) { MessageBox.Show("Error al editar, asegurese de seleccionar el proveedor en la grilla"); }
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
