using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class AgregarEmpleado : MetroFramework.Forms.MetroForm
    {
        
        public AgregarEmpleado()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radsi.Checked = true;
            radP.Checked = true;
            tipo.Items.Add("MEDICO");
            tipo.Items.Add("ENFERMERIA");
            tipo.Items.Add("GENERAL");

            tipo.SelectedIndex = 0;
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
                string cadenasql = @"INSERT INTO [Empleado] ([Nombre],[FechaIngreso],[TipoEmpleado],[TipoContrato],[TieneProfilactica])
                                    VALUES ('" + nombre.Text + "','" + fecha + "'," + typer+ ",'" + cont + "','" + prof + "')";
                Mantenimiento.insertar(cadenasql);
                //frm1.updater();
                this.Close();

            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }


        }
    }
}
