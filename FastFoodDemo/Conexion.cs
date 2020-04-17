using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo
{
    class Conexion
    {
        public static SqlConnection generarConexion()
        {

            connect cn = new connect();
            string x = cn.cadenaconexion;
            SqlConnection Con = new SqlConnection(x);


            return Con;



        }
    }
}
