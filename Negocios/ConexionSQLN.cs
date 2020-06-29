using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocios
{
    public class ConexionSQLN
    {

        ConexionSQL cn = new ConexionSQL();

        public int conSQL(string user, string pass)
        {
            return cn.consultaLogin(user, pass);
        }

        public DataTable consultaDT()
        {
            return cn.ConsultarUsuariosDG();
        }

        public int InsertarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string pass)
        {

            return cn.InsertarUsuario(nombre,apellidos,dni,telefono,usuario,pass);
        }

        public int ModificarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string pass)
        {
            return cn.ModificarUsuario(nombre,apellidos,dni,telefono,usuario,pass);
        }

        public int EliminarUsuario(string dni)
        {
            return cn.EliminarUsuario(dni);
        }
    }
}
