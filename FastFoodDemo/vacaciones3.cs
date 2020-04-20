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
    public partial class vacaciones3 : MetroFramework.Forms.MetroForm
    {
        
        private thirdcustomcontrol frm1;
        public vacaciones3(thirdcustomcontrol frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        public int counter;
        public int diasV;

        private void vacaciones_Load(object sender, EventArgs e)
        {
            counter = Mantenimiento.returnInt("select DATEDIFF(YEAR, FechaIngreso, getdate()) from Empleado where IDEmpleado = " + frm1.xd + "");
            ord.Checked = true;

            if (Mantenimiento.lookerSt("select TieneProfilactica from Empleado where IDEmpleado =" + frm1.xd + "") == "NO")
            {
                prof.Enabled = false;
            }

            if (counter <= 1)
            {
                dias.Text = "12 DIAS";
                diasV = 12;
            }
            if (counter == 2)
            {
                dias.Text = "15 DIAS";
                diasV = 15;
            }
            if (counter == 3)
            {
                dias.Text = "18 DIAS";
                diasV = 18;
            }
            if (counter == 4)
            {
                dias.Text = "22 DIAS";
                diasV = 22;
            }
            if (counter == 5)
            {
                dias.Text = "26 DIAS";
                diasV = 26;
            }
            if (counter >= 6)
            {
                dias.Text = "30 DIAS";
                diasV = 30;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string just = "Profilactica";
            if (ord.Checked == true)
            {
                just = "Ordinaria";
            }

            DateTime x1 = DateTime.Parse(fecha1.Value.ToString("yyyy-MM-dd"));
            DateTime x2 = DateTime.Parse(fecha2.Value.ToString("yyyy-MM-dd"));

            double bd = Mantenimiento.GetBusinessDays(x1, x2);

            if (x1 > x2)
            {
                MessageBox.Show("Fecha Invalida");
            }
            else
            {
                if (bd <= diasV)// vacaciones warning
                {
                    string cadenasql = @"INSERT INTO [Vacaciones]([Inicio],[Final],[TipoVacacion],[IDEmpleado])
                                     VALUES('" + fecha1.Value.ToString("yyyy-MM-dd") + "','" + fecha2.Value.ToString("yyyy-MM-dd") + "','" + just + "'," + frm1.xd + ")";
                    Mantenimiento.insertar(cadenasql);

                    frm1.updater();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Se excedieron los dias disponibles");
                }
            }
        }
    }
}
