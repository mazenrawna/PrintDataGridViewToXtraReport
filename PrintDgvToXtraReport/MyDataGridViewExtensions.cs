using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDgvToXtraReport
{
    public static class MyDataGridViewExtensions
    {
        public static PrintableObject GetDataSource(this DataGridView dataGridView)
        {
            if (dataGridView.DataSource != null)
            {
                List<MyColumn> Cols = new List<MyColumn>();
                DataTable DataSource = (DataTable)dataGridView.DataSource;
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    if (col.Visible)
                    {
                        Cols.Add(new MyColumn
                        {
                            Name = col.Name,
                            HeaderText = col.HeaderText,
                            Width = col.Width
                        });
                    }
                }

                var model = new PrintableObject(Cols, DataSource);
                return model;
                /*var Rpt = new EmptyRep(model);
                var Tool = new ReportPrintTool(Rpt);
                Tool.ShowPreviewDialog();*/
            }
            else
            {
                return null;
            }
        }

        public static DevExpress.XtraReports.UI.XtraReport GetDataReport(this DataGridView dataGridView)
        {
            if (dataGridView.DataSource != null)
            {
                var model = GetDataSource(dataGridView);
                var Rpt = new DataGridViewReport(model);                
                return Rpt;                                
            }
            else
            {
                return null;
            }
        }

        public static void PrintDataReport(this DataGridView dataGridView)
        {
            if (dataGridView.DataSource != null)
            {               
                var Rpt = GetDataReport(dataGridView);
                var Tool = new ReportPrintTool(Rpt);
                Tool.ShowPreviewDialog();                
            }            
        }
    }
}
