using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Formulario
{
    public class Ver 
    {
        Conexion cone = new Conexion();

        public DataTable verAFP()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SP_VERAFP",cone.LeerCadena());
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            ad.Fill(da);
            return da;
        }

        public DataTable verISSS()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SP_VERISSS", cone.LeerCadena());
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            ad.Fill(da);
            return da;
        }

        public DataTable verGeneral()
        {
            SqlDataAdapter ad = new SqlDataAdapter("SP_VERPLANILLAG", cone.LeerCadena());
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable da = new DataTable();
            ad.Fill(da);
            return da;
        }
    }
}
