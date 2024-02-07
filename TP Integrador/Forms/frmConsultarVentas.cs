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

namespace TP_Integrador
{
    public partial class frmConsultarVentas : Form
    {
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            cargarGrafico();
        }

        BLLPedidos bllPedidos = new BLLPedidos();

        private void cargarGrafico()
        {
            DataTable tabla = bllPedidos.traerTabla();

            double[] yValores = new double[tabla.Rows.Count];
            string[] xValores = new string[tabla.Rows.Count];

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                yValores[i] = Convert.ToDouble(tabla.Rows[i]["Total"]);
                xValores[i] = Convert.ToString(tabla.Rows[i]["id_pedido"]);
            }

            //string[] xValores = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            chart1.Series[0].Points.DataBindXY(xValores, yValores);
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarGrafico();
        }
    }
}
