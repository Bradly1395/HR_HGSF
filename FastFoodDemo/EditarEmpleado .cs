using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class EditarEmpleado : MetroFramework.Forms.MetroForm
    {
        
        public EditarEmpleado()
        {
            InitializeComponent();
            
        }

        int idEmp;
        private void Form2_Load(object sender, EventArgs e)
        {
            tipo.Items.Add("MEDICO");
            tipo.Items.Add("ENFERMERIA");
            tipo.Items.Add("GENERAL");

            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("SELECT [Nombre],[FechaIngreso],[TipoEmpleado],[TipoContrato],[TieneProfilactica], IDEmpleado FROM Empleado where Nombre = '"+nombre.Text+"'", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    fecha1.Value = Lect.GetDateTime(1);

                    tipo.SelectedIndex = Lect.GetInt32(2)-1;

                    if (Lect.GetString(3) == "P")
                        radP.Checked = true;  
                    else
                        radC.Checked = true;

                    if (Lect.GetString(4) == "SI")
                        radsi.Checked = true;
                    else
                        radno.Checked = true;

                    idEmp = Lect.GetInt32(5);
                }
                Cone.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string prof = "NO";
            if (radsi.Checked == true)
            {
                prof = "SI";
            }

            string cont = "C";
            if (radP.Checked == true)
            {
                cont = "P";
            }

            DateTime fecha = DateTime.Parse(fecha1.Value.ToString("yyyy-MM-dd"));

            int typer = tipo.SelectedIndex + 1;

            if (string.IsNullOrWhiteSpace(nombre.Text) == false)
            {
                string cadenasql = @"UPDATE Empleado
                                     SET Nombre='" + nombre.Text + "',FechaIngreso='" + fecha + "',TipoEmpleado=" + typer + ",TipoContrato='" + cont + "',TieneProfilactica='" + prof + "' WHERE  IDEmpleado ="+idEmp+"";
                                    
                Mantenimiento.actualizar(cadenasql);

                this.Close();

            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }


        }
    }
}
