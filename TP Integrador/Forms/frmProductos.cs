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
    public partial class frmProductos : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();
        public frmProductos()
        {
            InitializeComponent();
        }

        BLLProductos bllProductos = new BLLProductos();
        BLLProveedores bllProv = new BLLProveedores();
        private void frmProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
            grillaProductos.Columns[3].Width = 200;
        }

        public void ActualizarGrilla()
        {
            grillaProductos.DataSource = bllProductos.traerTabla();
            grillaProveedores.DataSource = bllProv.traerTabla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(numPrecio.Value > 0 && txtDescripcion.Text != "")
            {
                Producto prod = new Producto(Convert.ToDouble(numPrecio.Value), 0, txtDescripcion.Text);
                bllProductos.AltaProducto(prod);
                ActualizarGrilla();
            }
            else { MessageBox.Show("Ingrese los datos en los campos"); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas dar de baja el producto", "Dar de baja", MessageBoxButtons.YesNo);
            if (MensajeSIoNO == DialogResult.Yes)
            {
                try
                {
                    int idProd = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                    bllProductos.BajaProducto(idProd);
                    ActualizarGrilla();
                }
                catch (Exception ex) { MessageBox.Show("Seleccione un producto en la grilla para Eliminar"); }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas editar el producto", "Editar", MessageBoxButtons.YesNo);
            if (MensajeSIoNO == DialogResult.Yes)
            {
                try
                {
                    int idProd = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                    Producto prod = new Producto(Convert.ToDouble(numPrecio.Value), 0, txtDescripcion.Text);
                    prod.id_producto = idProd;
                    bllProductos.EditarProducto(prod);
                    ActualizarGrilla();
                }
                catch (Exception ex) { MessageBox.Show("Seleccione un producto en la grilla para Eliminar"); }
            }
        }

        private void btnSolicitarStock_Click(object sender, EventArgs e)
        {
            if(grillaProveedores.SelectedRows.Count > 0)
            {
                string nombre = grillaProveedores.CurrentRow.Cells[1].Value.ToString();
                int NumTel = Convert.ToInt32(grillaProveedores.CurrentRow.Cells[2].Value);

                Proveedor prov = new Proveedor(nombre, NumTel);
                prov.id_proveedor = Convert.ToInt32(grillaProveedores.CurrentRow.Cells[0].Value);

                frmSolicitarStock frm = new frmSolicitarStock(prov);
                frm.Show();

                ActualizarGrilla();
            }
            else { MessageBox.Show("Seleccione un proveedor para solicitar Stock"); }
            
            
        }
    }
}
