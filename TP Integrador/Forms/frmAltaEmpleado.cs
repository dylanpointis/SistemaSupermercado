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
using BE;

namespace TP_Integrador.Forms
{
    public partial class frmAltaEmpleado : Form
    {
        private int idUser;

        public frmAltaEmpleado(int Id)
        {
            idUser = Id;
            InitializeComponent();
        }
        BLLEmpleado BLLemp = new BLLEmpleado();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(txtNombreEmp.Text, txtApellidoEmp.Text, txtHorarioEmp.Text, txtRolEmp.Text, Convert.ToDouble(txtSueldoEmp.Text), idUser.ToString(), "-");
            emp.idEmpleado = idUser;

            BLLemp.RegistrarEmpleado(emp);
        }
    }
}
