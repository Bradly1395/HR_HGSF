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
    public partial class Convenio : MetroFramework.Forms.MetroForm
    {
        private FirstCustomControl frm1;
        public Convenio(FirstCustomControl frst)
        {
            InitializeComponent();
            frm1 = frst;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            date3.Format = DateTimePickerFormat.Custom;
            date3.CustomFormat = "hh:mm:tt";
            date3.ShowUpDown = true;

            date4.Format = DateTimePickerFormat.Custom;
            date4.CustomFormat = "hh:mm:tt";
            date4.ShowUpDown = true;

            especialista.Checked = true;
            guardia.Checked = true;
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
            string tipo = "";
            string compromiso = "";
            string compromiso2 = "";
            DateTime x1 = fecha1.Value.Date + date3.Value.TimeOfDay;
            DateTime x2 = fecha2.Value.Date + date4.Value.TimeOfDay;

            if (especialista.Checked == true)
                tipo = especialista.Text;
            if (odonto.Checked == true)
                tipo = odonto.Text;
            if (general.Checked == true)
                tipo = general.Text;
            if (ss.Checked == true)
                tipo = ss.Text;
            if (micro.Checked == true)
                tipo = micro.Text;

            if (guardia.Checked == true)
                compromiso = guardia.Text;
            if (jornada.Checked == true)
                compromiso = jornada.Text;

            if (pago.Checked == true)
                compromiso2 = pago.Text;
            if (tiempo.Checked == true)
                compromiso2 = tiempo.Text;


            if (x1 > x2)
            {
                MessageBox.Show("Fecha Invalida");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(servicio.Text) == false && string.IsNullOrWhiteSpace(companero.Text) == false && string.IsNullOrWhiteSpace(servicio2.Text) == false && string.IsNullOrWhiteSpace(motivo.Text) == false)
                {
                    int permPago = Mantenimiento.returnInt("select count(*) from Convenio where IDEmpleado = " + frm1.xd + " and CompromisoPago = 'PAGO MONETARIO'");

                    if (permPago >= 5 && (pago.Checked == true))
                    {
                        DialogResult dialogResult = MessageBox.Show("Este empleado ya tiene 5 convenios pagados o mas.¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            string cadenasql = @"INSERT INTO Convenio([IDEmpleado],[TipoMedico],[ServicioSolicitante],[Compromiso]
                                        ,[FechaInicio],[FechaFinal],[Companero],[ServicioCompanero],[CompromisoPago]
                                        ,[motivo])VALUES
                                        ( " + frm1.xd + " ,'" + tipo + "','" + servicio.Text + "','" + compromiso + "','" + x1.ToString("yyyy-MM-dd HH:mm") + "','" + x2.ToString("yyyy-MM-dd HH:mm") + "','" + companero.Text + "','" + servicio2.Text + "','" + compromiso2 + "','" + motivo.Text + "')";
                            Mantenimiento.insertar(cadenasql);
                            frm1.updater();
                            this.Close();
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        string cadenasql = @"INSERT INTO Convenio([IDEmpleado],[TipoMedico],[ServicioSolicitante],[Compromiso]
                                        ,[FechaInicio],[FechaFinal],[Companero],[ServicioCompanero],[CompromisoPago]
                                        ,[motivo])VALUES
                                        ( " + frm1.xd + " ,'" + tipo + "','" + servicio.Text + "','" + compromiso + "','" + x1.ToString("yyyy-MM-dd HH:mm") + "','" + x2.ToString("yyyy-MM-dd HH:mm") + "','" + companero.Text + "','" + servicio2.Text + "','" + compromiso2 + "','" + motivo.Text + "')";
                        Mantenimiento.insertar(cadenasql);
                        frm1.updater();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("No se permiten espacios en blanco");
                }
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
