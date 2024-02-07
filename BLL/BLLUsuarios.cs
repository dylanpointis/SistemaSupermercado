using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using BE;
using System.Security.Claims;
using BE.Composite;

namespace BLL
{
    public class BLLUsuarios
    {
        DalConexion dal = new DalConexion();

        public DataTable traerTabla()
        {
            DataTable dt = dal.TraerTabla("Usuarios");
            return dt;
        }

        public void RegistrarUsuario(string username, string password, string rol)
        {
            string hash = HashPassword(password);

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreDeUsuario", username),
                new SqlParameter("@clave", hash),
                new SqlParameter("@rol", rol)
            };

            //$"INSERT INTO Usuarios (NombreDeUsuario, Clave, Salt) VALUES (@NombreDeUsuario, @Clave, @Salt)";
            dal.EjecutarProcAlmacenado("RegistrarUsuario", parametros);
        }

        public void BajaUsuario(int id)
        {
            dal.EjecutarComando($"Delete from Usuarios where id_usuario = {id}");
        }

        public void EditarUsuario(Usuario user)
        {
            string hash = HashPassword(user.Clave); //Encripta clave
            dal.EjecutarComando($"UPDATE Usuarios set NombreDeUsuario = '{user.NombreUsuario}', Clave = '{hash}', Rol = '{user.Rol}' where id_usuario = {user.IDUser}");
        }

        //Encriptar password con metodo MD5
        private string HashPassword(string clave)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(clave);
                byte[] hash = md5.ComputeHash(inputBytes);

                string hashTexto = BitConverter.ToString(hash).Replace("-", "").ToLower();

                return hashTexto;
            }
        }


        public Usuario VerificarUsuario(string nombreUsuario, string clave)
        {
            DataTable tabla = dal.TraerTabla("Usuarios");

            foreach(DataRow row in tabla.Rows)
            {
                if (row[1].ToString() == nombreUsuario && row[2].ToString() == HashPassword(clave))
                {
                    Usuario user = new Usuario(nombreUsuario, "-");
                    user.Rol = row[3].ToString();
                    user.IDUser = Convert.ToInt32(row[0]);
                    Familia familia = ObtenerFamilia(user.Rol);
                    user.familia = familia;
                    return user;
                }
            }
            return null;
        }

        private Familia ObtenerFamilia(string rol)
        {
            if (rol == "Cliente")
            {
                Familia familiaCliente = new Familia("Cliente");

                Componente patente1 = new Patente("Comprar"); familiaCliente.AgregarHijo(patente1);
                Componente patente2 = new Patente("Envios"); familiaCliente.AgregarHijo(patente2);
                Componente patente3 = new Patente("Reclamos"); familiaCliente.AgregarHijo(patente3);
                Componente patente4 = new Patente("Descuentos"); familiaCliente.AgregarHijo(patente4);
                Componente patente5 = new Patente("Pedidos"); familiaCliente.AgregarHijo(patente5);
                return familiaCliente;
            }
            if (rol == "Empleado")
            {
                Familia familiaEmpleado = new Familia("Empleado");
  
                Componente patente1 = new Patente("ProgramarEnvios"); familiaEmpleado.AgregarHijo(patente1);
                Componente patente2 = new Patente("Productos"); familiaEmpleado.AgregarHijo(patente2);
                Componente patente3 = new Patente("Proveedores"); familiaEmpleado.AgregarHijo(patente3);
                Componente patente4 = new Patente("Reclamos"); familiaEmpleado.AgregarHijo(patente4);
                Componente patente5 = new Patente("Descuentos"); familiaEmpleado.AgregarHijo(patente5);

                return familiaEmpleado;
            }
            if(rol == "Admin")
            {
                Familia familiaAdmin = new Familia("Admin");

                Componente patente1 = new Patente("Productos"); familiaAdmin.AgregarHijo(patente1);
                Componente patente2 = new Patente("Envios"); familiaAdmin.AgregarHijo(patente2);
                Componente patente3 = new Patente("Reclamos"); familiaAdmin.AgregarHijo(patente3);
                Componente patente4 = new Patente("Descuentos"); familiaAdmin.AgregarHijo(patente4);
                Componente patente5 = new Patente("Proveedores"); familiaAdmin.AgregarHijo(patente5);
                Componente patente6 = new Patente("Usuarios"); familiaAdmin.AgregarHijo(patente6);
                Componente patente7 = new Patente("ConsultarVentas"); familiaAdmin.AgregarHijo(patente7);

                return familiaAdmin;
            }
            return null;         
        }

        public int TraerId(string nombreUsuario)
        {
            int id = 0;

            DataTable tabla = dal.TraerTabla("Usuarios");
            foreach (DataRow row in tabla.Rows)
            {
                if (row[1].ToString() == nombreUsuario)
                {
                    id = Convert.ToInt32(row[0]);
                }
            }
            return id;
        }
    }
}
