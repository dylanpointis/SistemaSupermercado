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
    public partial class textBoxSoloTexto : UserControl
    {
        public textBoxSoloTexto()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //EXPRESION REGULAR PARA SOLO LETRAS
            Regex regex = new Regex(@"[^a-zA-Z\b\s]"); // \b es para la tecla Borrar \s patra la barra espaciadora
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        public string Texto = "";

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Texto = textBox.Text;
        }
    }
}
