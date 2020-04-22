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

        public string cadenaconexion; //= ("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=hrsf;Integrated Security=True;Trusted_Connection=True;");
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
            if (RecursoHumano.Properties.Settings.Default.Check)
            {
                cadenaconexion = ("Data Source=" + RecursoHumano.Properties.Settings.Default.DataSource + ";Initial Catalog=" + RecursoHumano.Properties.Settings.Default.Catalog + ";User ID=" + RecursoHumano.Properties.Settings.Default.UserBase + "; Password =" + RecursoHumano.Properties.Settings.Default.PassBase);
            }
            else
            {
                cadenaconexion = ("Data Source=" + RecursoHumano.Properties.Settings.Default.DataSource + ";Initial Catalog=" + RecursoHumano.Properties.Settings.Default.Catalog + ";Integrated Security=True;Trusted_Connection=True;");
            }

            this.cnn = new SqlConnection(this.cadenaconexion);
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }

        public void SetConection(string DataSource, string Catalog, string userbase, string password, bool check)
        {
            if (check)
            {
                RecursoHumano.Properties.Settings.Default.DataSource = DataSource;
                RecursoHumano.Properties.Settings.Default.Catalog = Catalog;
                RecursoHumano.Properties.Settings.Default.PassBase = password;
                RecursoHumano.Properties.Settings.Default.UserBase = userbase;
                RecursoHumano.Properties.Settings.Default.Check = check;
                RecursoHumano.Properties.Settings.Default.Save();

                cadenaconexion = ("Data Source=" + RecursoHumano.Properties.Settings.Default.DataSource + ";Initial Catalog=" + RecursoHumano.Properties.Settings.Default.Catalog + ";User ID=" + RecursoHumano.Properties.Settings.Default.UserBase + "; Password =" + RecursoHumano.Properties.Settings.Default.PassBase);
            }
            else
            {
                RecursoHumano.Properties.Settings.Default.DataSource = DataSource;
                RecursoHumano.Properties.Settings.Default.Catalog = Catalog;
                RecursoHumano.Properties.Settings.Default.Check = check;
                RecursoHumano.Properties.Settings.Default.Save();

                cadenaconexion = ("Data Source=" + RecursoHumano.Properties.Settings.Default.DataSource + ";Initial Catalog=" + RecursoHumano.Properties.Settings.Default.Catalog + ";Integrated Security=True;Trusted_Connection=True;");
            }
            
        }
    }
}
