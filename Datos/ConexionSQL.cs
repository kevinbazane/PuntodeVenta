using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Datos
{
    public class ConexionSQL
    {
        static string conexionstring = @"Data Source=DESKTOP-1EJASKQ\SQLEXPRESS; Initial Catalog =PuntodeVenta; Integrated Security = True";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultaLogin(string usuario, string password) 
        {
            int count;
            con.Open();
            string query = "select Count(*) from Persona where usuario='" + usuario + "' and contrasena='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }

        public DataTable ConsultarUsuariosDG()
        {
            string query = "select * from Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string pass)
        {
            int flag = 0;
            con.Open();
            string query = "insert into Persona values('"+nombre+ "', '"+apellidos+ "', '"+dni+ "', '"+telefono+ "', '" + usuario + "', '" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int ModificarUsuario(string nombre, string apellidos, string dni, string telefono, string usuario, string pass)
        {
            int flag = 0;
            con.Open();
            string query = "update Persona set nombre= '" + nombre + "', apellidos= '" + apellidos + "', telefono= '" + telefono + "', usuario= '" + usuario + "',contrasena= '" + pass + "' where dni='"+dni+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public int EliminarUsuario(string dni)
        {
            int flag = 0;
            con.Open();
            string query = "delete from Persona where dni = '" + dni + "' ";
            SqlCommand cmd = new SqlCommand(query,con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public string consultaFactura()
        {
            con.Open();
            string query = "select(select distinct top 1 numfactura from Facturacion order by numfactura desc)+1 as numfactura";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                return reg["numfactura"].ToString();
            }
            else
            {
                return "Null";
            }

            con.Close();
        }

    }
}
