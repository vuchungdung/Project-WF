using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChamCong.CommonService
{
    public class ExportExcel
    {
        public void Export(DataGridView g, string duongDan, string tenTap)
        {
            Microsoft.Office.Interop.Excel.Application obj = new Microsoft.Office.Interop.Excel.Application();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 13.5;
            obj.Columns.HorizontalAlignment = HorizontalAlignment.Center;
            obj.Columns.VerticalAlignment = HorizontalAlignment.Center;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
