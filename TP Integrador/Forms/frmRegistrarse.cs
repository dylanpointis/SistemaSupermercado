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
using System.Threading;

namespace TP_Integrador
{
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        BLLUsuarios bllUsuarios = new BLLUsuarios();
        BLLCliente bllCliente = new BLLCliente();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                bllUsuarios.RegistrarUsuario(txtNombreUsuario.Text, txtClave.Text, "Cliente"); //Da alta un usuario con nombreUsuario y Clave

                int idUser = bllUsuarios.TraerId(txtNombreUsuario.Text); //Trae el id del usuario creado

                Cliente cli = new Cliente(idUser, txtNombre.Text, txtApellido.Text, txtNombreUsuario.Text, "-"); //Crea el cliente con el id, nombre y apellido. Tambien nombre de usuario pero no la clave
                bllCliente.RegistrarCliente(cli); //Da el alta del cliente en la base de datos

                MessageBox.Show("Registro exitoso");
                this.Close();
            }
            catch(Exception ex) { MessageBox.Show("Error al registrarse"); }
        }
    }
}
