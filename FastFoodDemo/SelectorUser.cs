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
    public partial class SelectorUser : MetroFramework.Forms.MetroForm
    {
        private thirdcustomcontrol frm1;
        public SelectorUser(thirdcustomcontrol frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void SelectorUser_Load(object sender, EventArgs e)
        {
            Mantenimiento man = new Mantenimiento();
            string query = "SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 3 order by Nombre";
            man.cargarDGgeneral(gridSel, query);

            DataGridViewColumn column = gridSel.Columns[0];
            column.Width = 175;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(gridSel.CurrentRow.Cells[0].Value.ToString());
            
            frm1.userCmb.Text = gridSel.CurrentRow.Cells[0].Value.ToString();

            this.Close();
        }
    }
}
