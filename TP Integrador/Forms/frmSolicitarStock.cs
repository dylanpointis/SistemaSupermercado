using BE;
using BLL;
using Microsoft.VisualBasic;
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
    public partial class frmSolicitarStock : Form
    {
        Proveedor prov;
        public frmSolicitarStock(Proveedor provRecibido)
        {
            prov = provRecibido;
            InitializeComponent();
        }

        BLLProductos bllProductos = new BLLProductos();
        List<OrdenDeCompra> listCompra = new List<OrdenDeCompra>();

        private void frmSolicitarStock_Load(object sender, EventArgs e)
        {
            lblProveedor.Text = $"Proveedor ID: {prov.id_proveedor}, Nombre: {prov.Nombre}";
            txtFecha.MinDate = DateTime.Today;

            grillaOrden.ColumnCount = 4;
            grillaOrden.Columns[0].Name = "id producto";
            grillaOrden.Columns[1].Name = "Cant a reponer";
            grillaOrden.Columns[2].Name = "Fecha";
            grillaOrden.Columns[3].Name = "Lugar";

            ActualizarGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProd = Convert.ToInt32(grillaProductos.CurrentRow.Cells[0].Value);
                int cantReponer = Convert.ToInt32(Interaction.InputBox("Ingrese la cantidad a reponer"));

                if(txtFecha.Text != "" && txtLugar.Text != "")
                {
                    OrdenDeCompra orden = new OrdenDeCompra(idProd,cantReponer, txtFecha.Value.ToString("dd-MM-yyyy"), txtLugar.Text );
                    listCompra.Add(orden);
                    ActualizarGrilla();
                }
                else { MessageBox.Show("Ingrese la fecha de Entrega y lugar de Entrega"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }          
        }

        private void ActualizarGrilla()
        {
            grillaProductos.DataSource = null;
            grillaProductos.DataSource = bllProductos.traerTabla();

            grillaOrden.Rows.Clear();
            if (listCompra.Count() > 0)
            {
                foreach (OrdenDeCompra orden in listCompra)
                {
                    grillaOrden.Rows.Add(new string[] { orden.idProducto.ToString(), orden.CantAReponer.ToString(), orden.FechaEntrga.ToString(), orden.LugarEntrega });
                }
            }

        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listCompra.Count > 0)
            {
                foreach (OrdenDeCompra item in listCompra)
                {
                    bllProductos.AgregarItemOrdenCompra(prov.id_proveedor, item);

                    //Suma stock al producto
                    int cantStock = bllProductos.ConsultarCantStock(item.idProducto);
                    bllProductos.EditarStock(item.idProducto, item.CantAReponer + cantStock);
                    
                    ActualizarGrilla();
                    MessageBox.Show("Compra de stock exitosa");
                }
            }
            else { MessageBox.Show("Agregue productos a la orden de compra"); }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(grillaOrden.CurrentRow.Cells[0].Value);
                OrdenDeCompra itemAEliminar = listCompra.FirstOrDefault(c => c.idProducto == idProducto);

                if (itemAEliminar != null)
                {
                    listCompra.Remove(itemAEliminar);
                }
                ActualizarGrilla();
            }
            catch (Exception ex) { }
        }
    }
}
