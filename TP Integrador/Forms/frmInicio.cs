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
using BE.Composite;
using BLL;
using TP_Integrador.Forms;

namespace TP_Integrador
{
    public partial class frmInicio : Form
    {
        Usuario user = SingletonSessionManager.Instancia.ObtenerUsuario();


        public frmInicio()
        {
            InitializeComponent();
        }

        Form formActivo = new Form();

        private void AbrirForm(Form form) //FUNCION PARA ABRIR FORMS DENTRO DEL MDIPARENT
        {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = form;
            formActivo.MdiParent = this;
            formActivo.Dock = DockStyle.Fill;
            formActivo.ControlBox = false;
            formActivo.FormBorderStyle = FormBorderStyle.None;
            formActivo.Text = "";
            

            formActivo.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e) //OCULTAR BOTONES SEGUN ROL
        {
            //LAS FAMILIAS Y PATENTES SE ESTABLECEN EN EL INICIO DE SESION, EN LA BLLUSUARIOS
            IList<Componente> listaPatentes = user.familia.ObtenerHijos();
         
            foreach(Patente patente in listaPatentes)
            {
                if(patente.Nombre == "Comprar")
                {
                    btnComprar.Visible = true;
                }
                if (patente.Nombre == "Envios")
                {
                    btnVerEnvio.Visible = true;
                }
                if (patente.Nombre == "ProgramarEnvios")
                {
                    btnProgramarEnvios.Visible = true;
                }
                if (patente.Nombre == "Productos")
                {
                    btnProductos.Visible = true;
                }
                if (patente.Nombre == "Proveedores")
                {
                    btnProveedores.Visible = true;
                }
                if (patente.Nombre == "Usuarios")
                {
                    btnAdministrarUsuarios.Visible = true;
                }
                if (patente.Nombre == "Reclamos")
                {
                    btnReclamos.Visible = true;
                }
                if (patente.Nombre == "ConsultarVentas")
                {
                    btnConsultarVentas.Visible = true;
                }
                if (patente.Nombre == "Descuentos")
                {
                    btnDescuentos.Visible = true;
                }
                if (patente.Nombre == "Pedidos")
                {
                    btnVerPedidos.Visible = true;
                }
            }
            
            label1.Text = $"Bienvenido {user.Rol} {user.NombreUsuario}";
        }

        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            frmComprar form = new frmComprar();
            AbrirForm(form);
        }

        private void btnVerEnvio_Click(object sender, EventArgs e)
        {
            frmEnvios form = new frmEnvios();
            AbrirForm(form);
        }

        private void btnProgramarEnvios_Click_1(object sender, EventArgs e)
        {
            frmProgramarEnvios form = new frmProgramarEnvios();
            AbrirForm(form);
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            AbrirForm(form);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores form = new frmProveedores();
            AbrirForm(form);
        }

        private void btnAdministrarUsuarios_Click_1(object sender, EventArgs e)
        {
            frmAdministrarUsuarios form = new frmAdministrarUsuarios();
            AbrirForm(form);
        }

        private void btnReclamos_Click_1(object sender, EventArgs e)
        {
            frmReclamos form = new frmReclamos();
            AbrirForm(form);
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            frmConsultarVentas form = new frmConsultarVentas();
            AbrirForm(form);
        }

        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            frmDescuentos form = new frmDescuentos();
            AbrirForm(form);
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            frmVerPedidos form = new frmVerPedidos();
            AbrirForm(form);
        }
    }
}
