using RecursoHumano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        int type = 1;
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();
            type = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            mySecondCustmControl1.BringToFront();
            type = 2;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (VerificarConexion()==false)
            {
                MessageBox.Show("Conexion a SQL invalida");
            }

        }

        private static bool VerificarConexion()
        {
            using (SqlConnection connection = Conexion.generarConexion())
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            thirdcustomcontrol1.BringToFront();
            type = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            passDB x = new passDB();
            x.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reporte rer = new Reporte(type);
            rer.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgregarEmpleado emp = new AgregarEmpleado();
            emp.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelectorEdit sel = new SelectorEdit();
            sel.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea reiniciar la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                this.Close();
            }

        }
    }
}
