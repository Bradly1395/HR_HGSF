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
    public partial class passDB : MetroFramework.Forms.MetroForm
    {
        public passDB()
        {
            InitializeComponent();
        }

        private void passDB_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pass.Text == "kereneje")
                {
                    DB x = new DB();
                    x.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Clave Incorrecta");
                }
            }
        }
    }
}
