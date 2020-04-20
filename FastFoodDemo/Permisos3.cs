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
    public partial class permiso3 : MetroFramework.Forms.MetroForm
    {
        private thirdcustomcontrol frm1;
        public permiso3(thirdcustomcontrol frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radsi.Checked = true;
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
            string just = "NO";
            if (radsi.Checked == true)
            {
                just = "SI";
            }

            DateTime x1 = DateTime.Parse(fecha1.Value.ToString("yyyy-MM-dd"));
            DateTime x2 = DateTime.Parse(fecha2.Value.ToString("yyyy-MM-dd"));

            if (x1 > x2)
            {
                MessageBox.Show("Fecha Invalida");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(descripcion.Text) == false && string.IsNullOrWhiteSpace(departamento.Text) == false)
                {
                    string cadenasql = @"INSERT INTO [Permiso] ([Descripcion],[FechaInicio],[FechaFinal],[Justificado],[IDEmpleado],[Sala])
                                    VALUES('" + descripcion.Text + "', '" + fecha1.Value.ToString("yyyy-MM-dd") + "', '" + fecha2.Value.ToString("yyyy-MM-dd") + "', '" + just + "', " + frm1.xd + ", '" + departamento.Text + "')";
                    Mantenimiento.insertar(cadenasql);
                    frm1.updater();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se permiten espacios en blanco");
                }
            }

        }
    }
}
