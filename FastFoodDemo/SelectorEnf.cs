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
    public partial class SelectorEnf : MetroFramework.Forms.MetroForm
    {
        private MySecondCustmControl frm1;
        public SelectorEnf(MySecondCustmControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void SelectorEnf_Load(object sender, EventArgs e)
        {
            Mantenimiento man = new Mantenimiento();
            string query = "SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 2 order by Nombre";
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
            
            frm1.enfCmb.Text = gridSel.CurrentRow.Cells[0].Value.ToString();

            this.Close();
        }
    }
}
