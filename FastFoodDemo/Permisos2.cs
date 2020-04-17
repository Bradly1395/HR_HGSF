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
    public partial class permiso2 : MetroFramework.Forms.MetroForm
    {
        private MySecondCustmControl frm1;
        public permiso2(MySecondCustmControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
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

            
        }
    }
}
