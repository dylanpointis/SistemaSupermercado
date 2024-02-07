using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SingletonSessionManager
    {
        public static SingletonSessionManager _instance; //Tiene que ser STATIC. Los atributos static son compartidos en todas las instancias de la clase. Mantienen el valor
        private Usuario _usuario;

        private SingletonSessionManager() { }

       public static SingletonSessionManager Instancia //Tiene que ser STATIC. Los metodos static pueden ser invocados sin crear un objeto de la clase SINGLETON ()
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonSessionManager();
                }
                return _instance;
            }
        }

        public  void EstablecerUsuario(Usuario user)
        {
            if (_usuario == null)
            {
                _usuario = user;
            }
        }

        public Usuario ObtenerUsuario()
        {
            return _usuario;
        }

        public void Desconectar()
        {
            _usuario = null;
            _instance = null;
        }
    }
}
