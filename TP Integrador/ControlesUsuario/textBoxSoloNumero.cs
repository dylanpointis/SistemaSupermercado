using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Integrador.ControlesUsuario
{
    public partial class textBoxSoloNumero : UserControl
    {
        public textBoxSoloNumero()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EXPRESION REGULAR PARA SOLO NUMEROS
            Regex regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public string Texto = "";

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            Texto = txtNum.Text;
        }
    }
}
