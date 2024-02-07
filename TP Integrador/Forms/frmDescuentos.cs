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
    public partial class frmDescuentos : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();
        public frmDescuentos()
        {
            InitializeComponent();
        }

        BLLDescuentos bllDescuentos = new BLLDescuentos();
        BLLProductos BLLProductos = new BLLProductos();

        private void frmDescuentos_Load(object sender, EventArgs e)
        {
            txtFecha.MinDate = DateTime.Today;
            if(user.Rol == "Cliente") { btnAgregar.Visible = false; btnEditar.Visible = false; btnEliminar.Visible = false; label1.Visible = false; txtPorcentaje.Visible = false; label2.Visible = false; txtFecha.Visible = false; }
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            grillaDescuentos.DataSource = bllDescuentos.traerTabla();
            grillaProductos.DataSource = BLLProductos.traerTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFecha.Text != "" && txtPorcentaje.Texto != "")
                {
                    if (Convert.ToInt32(txtPorcentaje.Texto) > 0 && Convert.ToInt32(txtPorcentaje.Texto) <= 100)
                    {
                        int idProd = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                        Descuento descuento = new Descuento(idProd, Convert.ToInt32(txtPorcentaje.Texto), txtFecha.Text);
                        bllDescuentos.Agregar(descuento);
                        ActualizarGrilla();
                    }
                    else { MessageBox.Show("El porcentaje de descuento tiene que ser entre 0 y 100"); }
                }
                else { MessageBox.Show("Llene los campos"); }
            }catch(Exception ex) { MessageBox.Show("Error al agregar, asegurese de seleccionar un producto"); }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas editar descuento", "Editar", MessageBoxButtons.YesNo);
                if (MensajeSIoNO == DialogResult.Yes)
                {
                    int idDescuento = Convert.ToInt32(grillaDescuentos.CurrentRow.Cells[0].Value);
                    int idProd = Convert.ToInt32(grillaDescuentos.CurrentRow.Cells[1].Value);
                    Descuento desc = new Descuento(idProd, Convert.ToInt32(txtPorcentaje.Texto), txtFecha.Text);
                    desc.id_descuento = idDescuento;
                    bllDescuentos.Editar(desc);
                    ActualizarGrilla();
                }
            }catch (Exception ex) { MessageBox.Show("Error al editar el descuento, asegurese de seleccionar un descuento en la grilla"); }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas dar de baja el descuento", "Dar de baja", MessageBoxButtons.YesNo);
                if (MensajeSIoNO == DialogResult.Yes)
                {
                    int idDescuento = Convert.ToInt32(grillaDescuentos.CurrentRow.Cells[0].Value);
                    bllDescuentos.Baja(idDescuento);
                    ActualizarGrilla();
                }
            }catch (Exception ex) { MessageBox.Show("Error al editar el descuento, asegurese de seleccionar un descuento en la grilla"); }
}

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
