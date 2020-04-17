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
    public partial class Incapacidad : MetroFramework.Forms.MetroForm
    {
        private FirstCustomControl frm1;
        public Incapacidad(FirstCustomControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Incapacidad_Load(object sender, EventArgs e)
        {
            radsi.Checked = true;
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
                if (string.IsNullOrWhiteSpace(diagnostico.Text) == false && string.IsNullOrWhiteSpace(medico.Text) == false)
                {
                    string cadenasql = @"INSERT INTO [Incapacidad]([IDEmpleado],[Medico],[Diagnostico],[NotificaJefe],[FechaInicio],[FechaFinal])
                                   VALUES (" + frm1.xd + ",'" + medico.Text + "','" + diagnostico.Text + "','" + just + "','" + fecha1.Value.ToString("yyyy-MM-dd") + "','" + fecha2.Value.ToString("yyyy-MM-dd") + "')";
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
