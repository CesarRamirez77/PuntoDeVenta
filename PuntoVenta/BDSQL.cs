using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PuntoVenta
{
    class BDSQL
    {
        public static SqlConnection Obtenerconexion()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-KFD5R0EP;Initial Catalog=PuntoDeVenta; Persist Security Info=True;User ID=Administrador;Password=123");
            con.Open();
            return con;
        }
    }
}
