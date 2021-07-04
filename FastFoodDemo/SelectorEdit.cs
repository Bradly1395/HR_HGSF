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
    public partial class SelectorEdit : MetroFramework.Forms.MetroForm
    {
        
        public SelectorEdit()
        {
            InitializeComponent();
            
        }

        private void Selector_Load(object sender, EventArgs e)
        {
            Mantenimiento man = new Mantenimiento();
            string query = "SELECT [Nombre] FROM [Empleado] where TipoEmpleado = 1 order by Nombre";
            man.cargarDGgeneral(gridSel, query);

            DataGridViewColumn column = gridSel.Columns[0];
            column.Width = 215;

            tipo.Items.Add("MEDICO");
            tipo.Items.Add("ENFERMERIA");
            tipo.Items.Add("GENERAL");

            tipo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarEmpleado edit = new EditarEmpleado();
            edit.nombre.Text = gridSel.CurrentRow.Cells[0].Value.ToString();
            this.Close();
            edit.ShowDialog();

        }

        private void tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = tipo.SelectedIndex + 1;

            Mantenimiento man = new Mantenimiento();
            string query = "SELECT [Nombre] FROM [Empleado] where TipoEmpleado = "+x+" order by Nombre";
            man.cargarDGgeneral(gridSel, query);
        }
    }
}
