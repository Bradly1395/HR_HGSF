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
    public partial class ConvenioEnf : MetroFramework.Forms.MetroForm
    {
        private MySecondCustmControl frm1;
        public ConvenioEnf(MySecondCustmControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            A.Checked = true;
            pago.Checked = true;
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
            string turno = "";
            string compromiso = "";

            if (A.Checked == true)
                turno = A.Text;
            if (B.Checked == true)
                turno = B.Text;
            if (C.Checked == true)
                turno = C.Text;

            if (pago.Checked == true)
                compromiso = pago.Text;
            if (tiempo.Checked == true)
                compromiso = tiempo.Text;

            if (string.IsNullOrWhiteSpace(servicio.Text) == false && string.IsNullOrWhiteSpace(companero.Text) == false && string.IsNullOrWhiteSpace(motivo.Text) == false)
            {
                string cadenasql = @"INSERT INTO Convenio([IDEmpleado],[ServicioSolicitante],[Compromiso]
                                        ,[FechaInicio],[Companero],Turno,[motivo],[TipoMedico])VALUES
                                        ( " + frm1.xd + " ,'" + servicio.Text + "','" + compromiso + "','" + fecha1.Value.ToString("yyyy-MM-dd") + "','" + companero.Text + "','" + turno + "','" + motivo.Text + "','ENFERMERIA')";
                Mantenimiento.insertar(cadenasql);
                frm1.updater();
                this.Close();

            }
            else
            {
                MessageBox.Show("No se permiten espacios en blanco");
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
