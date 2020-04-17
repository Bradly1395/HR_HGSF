using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo
{
    class connect
    {
        //public string cadenaconexion = ("Data Source=DATACENTER\\TECHNOTEL;Initial Catalog=SSSM;User ID=sa;Password=Admin2012");
        public string cadenaconexion = ("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=hrsf;Integrated Security=True;Trusted_Connection=True;");
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;

        public connect()
        {
            this.cnn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }
    }
}
