using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDgvToXtraReport
{
    public class PrintableObject
    {
        public List<ColumnInfo> Cols { get; set; }
        public DataTable DataSource { get; set; }
        public PrintableObject(List<ColumnInfo> Cols, DataTable DataSource)
        {
            this.Cols = Cols;
            this.DataSource = DataSource;
        }
    }
}
