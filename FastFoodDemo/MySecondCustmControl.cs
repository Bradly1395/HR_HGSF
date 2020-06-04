using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Data.SqlClient;

namespace FastFoodDemo
{
    public partial class MySecondCustmControl : UserControl
    {
        public DateTime f1;
        public DateTime f2;
        public DateTime pro1;
        public DateTime pro2;
        public DateTime datapro;
        public DateTime dateconv;

        public int xd;
        public MySecondCustmControl()
        {
            InitializeComponent();
            Mantenimiento man = new Mantenimiento();
            try
            {
                man.llenarEnf(enfCmb);
                enfCmb.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {

            }

        }

        private void radCalendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void MySecondCustmControl_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            if (Int32.Parse(permiso.Text) >= 3)
            {
                DialogResult dialogResult = MessageBox.Show("Este empleado ya tiene 3 permisos o mas.¿Desea continuar?", "Advertencia", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    permiso2 x = new permiso2(this);
                    x.nombre.Text = enfCmb.Text;
                    x.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                permiso2 x = new permiso2(this);
                x.nombre.Text = enfCmb.Text;
                x.Show();
            }

        }

        void radCalendar1_ElementRender(object sender, RenderElementEventArgs e)
        {
            if (radCalendar1.SpecialDays.Contains(e.Day, new MyComparer()))
            {
                e.Element.BackColor = Color.Gray;
            }
            else
            {
                e.Element.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
            }
        }

        class MyComparer : IEqualityComparer<RadCalendarDay>
        {
            public bool Equals(RadCalendarDay day1, RadCalendarDay day2)
            {
                if (DateTime.Compare(day1.Date.Date, day2.Date.Date) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int GetHashCode(RadCalendarDay day)
            {
                return day.GetHashCode();
            }
        }
        public void updater()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Convenios Start
            conveniosTXT.Text = "";

            xd = Mantenimiento.returnInt("SELECT [IDEmpleado] FROM [Empleado] where [Nombre] ='" + enfCmb.Text + "'");

            SqlDataReader Lect;

            using (SqlConnection Cone = Conexion.generarConexion())
            {
                Cone.Open();
                SqlCommand comando = new SqlCommand("SELECT top 10 FechaInicio FROM Convenio where IDEmpleado = " + xd + "and month(FechaInicio) = month(GETDATE()) order by FechaInicio DESC", Cone);

                Lect = comando.ExecuteReader();

                while (Lect.Read())
                {
                    dateconv = DateTime.Parse(Lect["FechaInicio"].ToString());
                    conveniosTXT.Text += dateconv.ToString("dd-MM-yyyy hh:mm tt") + "\n";
                }
                Cone.Close();
            }
            //ConveniosEnd

            //CalendarReset
            for (int i = radCalendar1.SpecialDays.Count - 1; i >= 0; i--)
            {
                radCalendar1.SpecialDays.Remove(radCalendar1.SpecialDays[i]);
            }


            //Counters
            permiso.Text = Mantenimiento.lookerSt("select count(IDpermiso) from Permiso where month(FechaInicio) = month(getdate()) and year(FechaInicio) = year(getdate()) and  IDEmpleado =" + xd + "");
            incapacidad.Text = Mantenimiento.lookerSt("select count(IDIncapacidad) from Incapacidad where month(FechaInicio) = month(getdate()) and year(FechaInicio) = year(getdate()) and  IDEmpleado =" + xd + "");

            //CalendarPainter
            Mantenimiento bol = new Mantenimiento();
            if (bol.Buscar("select * from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Ordinaria'") == false)
            {
                vac1.Text = "--/--/----";
                prof.Text = "--/--/----";
            }
            else
            {
                //Ordinaria START
                f1 = DateTime.Parse(Mantenimiento.lookerSt("select top 1 Inicio from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Ordinaria' order by IDVac desc"));
                f2 = DateTime.Parse(Mantenimiento.lookerSt("select top 1 Final from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Ordinaria' order by IDVac desc"));
                vac1.Text = f1.ToString("dd-MM-yyyy") + " - " + f2.ToString("dd-MM-yyyy");

                double xi = (f2 - f1).TotalDays;
                for (int i = 0; i <= xi; i++)
                {
                    DateTime date1 = f1;
                    DateTime data2 = date1.AddDays(0 + i);
                    Telerik.WinControls.UI.RadCalendarDay day = new Telerik.WinControls.UI.RadCalendarDay(data2);
                    radCalendar1.SpecialDays.Add(day);

                    radCalendar1.ElementRender += radCalendar1_ElementRender;
                }
                //Ordinaria END

                //Profilactica START

                if (Mantenimiento.lookerSt("select TieneProfilactica from Empleado where IDEmpleado =" + xd + "") == "SI")
                {
                    if (bol.Buscar("select * from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Profilactica'") == false)
                    {
                        //MessageBox.Show("No tiene vacaciones profilacticas asignadas");
                        prof.Text = "--/--/----";
                    }
                    else
                    {
                        pro1 = DateTime.Parse(Mantenimiento.lookerSt("select top 1 Inicio from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Profilactica' order by IDVac desc"));
                        pro2 = DateTime.Parse(Mantenimiento.lookerSt("select top 1 Final from Vacaciones where IDEmpleado =" + xd + " and TipoVacacion = 'Profilactica' order by IDVac desc"));
                        prof.Text = pro1.ToString("dd-MM-yyyy") + " - " + pro2.ToString("dd-MM-yyyy");
                    }

                }

                double xr = (pro2 - pro1).TotalDays;
                for (int i = 0; i <= xr; i++)
                {

                    DateTime date1 = pro1;
                    DateTime data2 = date1.AddDays(0 + i);
                    Telerik.WinControls.UI.RadCalendarDay day = new Telerik.WinControls.UI.RadCalendarDay(data2);
                    radCalendar1.SpecialDays.Add(day);

                    radCalendar1.ElementRender += radCalendar1_ElementRender;
                }

                //Profilactica END

                radCalendar1.FocusedDate = f1;
            }

            Cursor.Current = Cursors.Default;
        }

        private void enfCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            updater();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Incapacidad2 x = new Incapacidad2(this);
            x.nombre.Text = enfCmb.Text;
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vacaciones2 x = new vacaciones2(this);
            x.nombre.Text = enfCmb.Text;
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConvenioEnf x = new ConvenioEnf(this);
            x.nombre.Text = enfCmb.Text;
            x.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SelectorEnf x = new SelectorEnf(this);
            x.ShowDialog();
        }
    }
}
