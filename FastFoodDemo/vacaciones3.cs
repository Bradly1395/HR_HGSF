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
            }
            if (counter == 2)
            {
                dias.Text = "15 DIAS";
            }
            if (counter == 3)
            {
                dias.Text = "18 DIAS";
            }
            if (counter == 4)
            {
                dias.Text = "22 DIAS";
            }
            if (counter == 5)
            {
                dias.Text = "26 DIAS";
            }
            if (counter >= 6)
            {
                dias.Text = "30 DIAS";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
