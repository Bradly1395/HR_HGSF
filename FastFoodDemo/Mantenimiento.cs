using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    class Mantenimiento : connect
    {
        public static bool resul = false;
        public bool Buscar(string sql)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                bool resultado = false;
                cone.Open();
                SqlCommand comando = new SqlCommand(sql, cone);

                SqlDataReader reg = (null);
                reg = comando.ExecuteReader();
                if (reg.Read())
                {
                    resultado = true;
                }
                cone.Close();
                resul = resultado;
                return resultado;
            }
        }

        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }

        public void llenarCB(ComboBox cb, string x, string y)
        {
            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand(x, Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb.Items.Add(Lect[y].ToString());
                }
                Cone.Close();
            }
        }

        //Para llenar stringbox
        public void stringfiller(string cb, string x, string y)
        {
            SqlDataReader Lect;

            cb = "";

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand(x, Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    cb += (Lect[y].ToString())+"\n";
                }
                Cone.Close();
            }
        }

        public static string lookerSt(string query)
        {
            string look = "none";
            //float isval;

            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                object userNameObj = comando.ExecuteScalar();
                if (userNameObj != null)
                    look = comando.ExecuteScalar().ToString();
                

                cnn.Close();

            }

            return look;
        }
        /*---------------------------------------------------*/
        public static string booler(string query)
        {
            string look = "none";
            //float isval;

            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                object userNameObj = comando.ExecuteScalar();
                if (userNameObj != null)
                    look = comando.ExecuteScalar().ToString();


                cnn.Close();

            }

            return look;
        }

        /*----------------Creacion general-----------------------------------*/
        public static void insertar(string query)
        {
            using (SqlConnection cnn = Conexion.generarConexion())
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand(query, cnn);
                comando.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Ingresado!");
            }
        }
        /*---------------------------------------------------*/
        public static void actualizar(string query)
        {
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                comando.ExecuteNonQuery();
                cone.Close();
                MessageBox.Show("Modificacion realizada!");
            }
        }

        public static int returnInt(string query)
        {
            int resultado;
            using (SqlConnection cone = Conexion.generarConexion())
            {
                cone.Open();
                SqlCommand comando = new SqlCommand(query, cone);

                resultado = Convert.ToInt32(comando.ExecuteScalar().ToString());
                cone.Close();

            }

            return resultado;
        }

        public void cargarDGgeneral(DataGridView dgv, string query)
        {
            try
            {
                da = new SqlDataAdapter(query, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el Datagridview: " + ex.ToString());
            }
        }

        public void llenarDoc(ComboBox cb)
        {
            using (SqlConnection sqlConnection = Conexion.generarConexion())
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 1 order by Nombre", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cb.Items.Add(sqlReader["Nombre"].ToString());
                }

                sqlReader.Close();
            }
        }

        public void llenarEnf(ComboBox cb)
        {
            using (SqlConnection sqlConnection = Conexion.generarConexion())
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 2 order by Nombre", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cb.Items.Add(sqlReader["Nombre"].ToString());
                }

                sqlReader.Close();
            }
        }

        public void llenarUser(ComboBox cb)
        {
            using (SqlConnection sqlConnection = Conexion.generarConexion())
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 3 order by Nombre", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                while (sqlReader.Read())
                {
                    cb.Items.Add(sqlReader["Nombre"].ToString());
                }

                sqlReader.Close();
            }
        }

    }
}
