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
    public partial class Incapacidad3 : MetroFramework.Forms.MetroForm
    {
        private thirdcustomcontrol frm1;
        public Incapacidad3(thirdcustomcontrol frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Incapacidad_Load(object sender, EventArgs e)
        {
            
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
