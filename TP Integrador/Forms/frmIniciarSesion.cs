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
using BLL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace TP_Integrador
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        BLLUsuarios bllUsuarios = new BLLUsuarios();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (SingletonSessionManager._instance == null) //Chequea que no haya una instancia de SINGLETON, que no haya iniciado sesion antes
            {
                Usuario user = bllUsuarios.VerificarUsuario(txtNombreUsuario.Text, txtClave.Text);//Verifica el usuario con username y clave. Trae el usuario con sus Datos y Familia

                if (user != null)
                {
                    SingletonSessionManager.Instancia.EstablecerUsuario(user); //Establece el usuario en la instancia de singleton

                    this.Hide(); //oculta el formulario actual
                    frmInicio form = new frmInicio();

                    form.Show();
                    form.FormClosing += CerrandoFormulario; //cuando se cierra el formulario Inicio ejecuta la funcion CerrandoFormulario que vuelve a mostrar el formulario actual
                                                            //y elimina la instancia del Singleton
                }
                else
                {
                    MessageBox.Show("No iniciaste sesión");
                }
            }
            else //Si ya hay una instancia de singleton
            {
                MessageBox.Show("La sesión ya está iniciada.");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse form = new frmRegistrarse();
            form.Show();
        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "Joaquin";
            txtClave.Text = "123";
        }

        private void CerrandoFormulario(object sender, FormClosingEventArgs e)
        {
            SingletonSessionManager.Instancia.Desconectar(); //Borra la instancia del SINGLETON para que haya solo una
            this.Show();
        }

        private void btnOcultarClave_Click(object sender, EventArgs e)
        {
            btnMostrarClave.BringToFront();
            txtClave.PasswordChar = '*';
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            btnOcultarClave.BringToFront();
            txtClave.PasswordChar = '\0';
        }

        private void btnMostrarCuentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente:\nusuario: Joaquin, clave: 123");
            MessageBox.Show("Empleado:\nusuario: Empleado, clave: 123");
            MessageBox.Show("Admin:\nusuario: Admin, clave: 123");
        }
    }
}
