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
    }
}
