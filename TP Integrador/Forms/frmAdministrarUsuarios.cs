using BLL;
using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace TP_Integrador.Forms
{
    public partial class frmAdministrarUsuarios : Form
    {
        public frmAdministrarUsuarios()
        {
            InitializeComponent();
        }


        BLLUsuarios bllUser = new BLLUsuarios();

        private void frmAdministrarUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }


        BLLEmpleado bllEmp = new BLLEmpleado();
        BLLCliente bllCli = new BLLCliente();



        private void ActualizarGrilla()
        {
            grillaUsuarios.DataSource = null;
            grillaUsuarios.DataSource = bllUser.traerTabla();
        }

        private void btnBaja_Click_1(object sender, EventArgs e)
        {
            DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas dar de baja el usuario", "Dar de baja", MessageBoxButtons.YesNo);
            if (MensajeSIoNO == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(grillaUsuarios.CurrentRow.Cells[0].Value);
                    string rol = Convert.ToString(grillaUsuarios.CurrentRow.Cells[3].Value);


                    if (rol == "Empleado")
                    {
                        bllEmp.BajaEmpleado(id);
                    }
                    if (rol == "Cliente")
                    {
                        bllCli.BajaCliente(id);
                    }
                    bllUser.BajaUsuario(id);

                    ActualizarGrilla();
                }catch(Exception ex) { MessageBox.Show("Error al dar de baja, asegurese de seleccionar un usuario en la grilla"); }
            }
        }

        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" && cmbTipoCuenta.Text != "")
            {
                try
                {
                    if (cmbTipoCuenta.Text == "Empleado")
                    {
                        bllUser.RegistrarUsuario(txtUsuario.Text, txtClave.Text, cmbTipoCuenta.Text);
                        int idUser = bllUser.TraerId(txtUsuario.Text);
                        frmAltaEmpleado form = new frmAltaEmpleado(idUser);
                        form.Show();
                    }
                    if (cmbTipoCuenta.Text == "Cliente")
                    {
                        bllUser.RegistrarUsuario(txtUsuario.Text, txtClave.Text, cmbTipoCuenta.Text);
                        int idUser = bllUser.TraerId(txtUsuario.Text);

                        string Nombre = Interaction.InputBox("Ingrese el nombre");
                        string Apellido = Interaction.InputBox("Ingrese el apellido");

                        bllCli.RegistrarCliente(new Cliente(idUser, Nombre, Apellido, txtUsuario.Text, "-"));
                    }
                    if (cmbTipoCuenta.Text == "Admin")
                    {
                        bllUser.RegistrarUsuario(txtUsuario.Text, txtClave.Text, cmbTipoCuenta.Text);

                    }
                    ActualizarGrilla();
                }
                catch (Exception ex) { MessageBox.Show("Error al registrar usuario"); }

            }
            else { MessageBox.Show("Llene los campos"); }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult MensajeSIoNO = MessageBox.Show("Estas seguro que deseas editar el usuario", "Editar", MessageBoxButtons.YesNo);
            if (MensajeSIoNO == DialogResult.Yes)
            {
                try
                {
                    if (txtUsuario.Text != "" && txtClave.Text != "" && cmbTipoCuenta.Text != "")
                    {
                        int idUser = Convert.ToInt32(grillaUsuarios.CurrentRow.Cells[0].Value);

                        Usuario user = new Usuario(txtUsuario.Text, txtClave.Text);
                        user.IDUser = idUser;
                        user.Rol = cmbTipoCuenta.Text;

                        bllUser.EditarUsuario(user);
                        ActualizarGrilla();
                    }
                    else { MessageBox.Show("Llene los campos"); }
                }
                catch (Exception ex) { MessageBox.Show("Error al editar, asegurese de seleccionar un usuario"); }
            }
        }
    }
}
