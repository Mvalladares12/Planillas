using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Formulario
{
    public class Conexion
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PLANILLAconn"].ConnectionString);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            return con;
        }
    }
}
