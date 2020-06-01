using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FastFoodDemo
{
    public partial class Reporte : MetroFramework.Forms.MetroForm
    {
        int type;
        public Reporte(int type1)
        {
            InitializeComponent();
            type = type1;
        }

        private void Selector_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var startOfMonth = new DateTime(now.Year, now.Month, 1);
            var lastDayOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            fecha1.Value = startOfMonth;
            fecha2.Value = lastDayOfMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime x1 = DateTime.Parse(fecha1.Value.ToString("yyyy-MM-dd"));
            DateTime x2 = DateTime.Parse(fecha2.Value.ToString("yyyy-MM-dd"));
            Cursor.Current = Cursors.WaitCursor;

            Mantenimiento man = new Mantenimiento();
            string query = @"select a.Nombre, a.TipoContrato, a.FechaIngreso, b.Inicio, b.Final, b.TipoVacacion, 
                            datediff(day, b.Inicio, b.Final) as 'Dias Totales', c.Descripcion as TipoEmpleado
                            from Empleado as a
                            left join Vacaciones as b
                            on a.IDEmpleado = b.IDEmpleado
							inner join TipoEmpleado c
							on a.TipoEmpleado = c.IDTipo
                            where b.Inicio between '"+x1+"' and '"+x2+"'";
            man.cargarDGgeneral(gridAdmin, query);

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            Cursor.Current = Cursors.Default;
            this.Close();
        }

        private void copyAlltoClipboard()
        {
            gridAdmin.SelectAll();
            DataObject dataObj = gridAdmin.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void gridSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
