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
        
        public string cadenaconexion = ("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=hrsf;Integrated Security=True;Trusted_Connection=True;");
        public string sql;
        public int resultado;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public string mensaje;
        public SqlDataAdapter da;
        public DataTable dt;
        public string x;

        public connect()
        {
            this.cnn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }

        public void SetConection(string DataSource, string Catalog, string userbase, string password)
        {
            RecursoHumano.Properties.Settings.Default.DataSource = DataSource;
            RecursoHumano.Properties.Settings.Default.Catalog = Catalog;
            RecursoHumano.Properties.Settings.Default.PassBase = password;
            RecursoHumano.Properties.Settings.Default.UserBase = userbase;
            RecursoHumano.Properties.Settings.Default.Save();
            x = ("Data Source=" + RecursoHumano.Properties.Settings.Default.DataSource + ";Initial Catalog=" + RecursoHumano.Properties.Settings.Default.Catalog + ";User ID=" + RecursoHumano.Properties.Settings.Default.UserBase+"; Password ="+ RecursoHumano.Properties.Settings.Default.PassBase);
        }
    }
}
