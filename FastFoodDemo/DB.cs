using FastFoodDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursoHumano
{
    public partial class DB : MetroFramework.Forms.MetroForm
    {
        public DB()
        {
            InitializeComponent();
        }

        private void DB_Load(object sender, EventArgs e)
        {
            bd.Text = RecursoHumano.Properties.Settings.Default.DataSource;
            cat.Text = RecursoHumano.Properties.Settings.Default.Catalog;
            pass.Text = RecursoHumano.Properties.Settings.Default.PassBase;
            user.Text = RecursoHumano.Properties.Settings.Default.UserBase;
        }

        private void cox_CheckedChanged(object sender, EventArgs e)
        {
            if (cox.Checked == true)
            {
                user.Enabled = true;
                pass.Enabled = true;
            }
            else
            {
                user.Enabled = false;
                pass.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect c = new connect();
            c.SetConection(bd.Text, cat.Text, user.Text, pass.Text, cox.Checked);
            MessageBox.Show(c.cadenaconexion);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
