using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDgvToXtraReport
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            dataGridView1.DataSource = GetData();
            dataGridView1.Columns["Id"].HeaderText = "م";
            dataGridView1.Columns["Name"].HeaderText = "اسم الصنف";
            dataGridView1.Columns["Quantity"].HeaderText = "الكمية";
            dataGridView1.Columns["UnitName"].HeaderText = "الوحدة";
            dataGridView1.Columns["Price"].HeaderText = "سعر البيع";
            dataGridView1.Columns["Store"].HeaderText = "المخزن";
            dataGridView1.Columns["ProductDate"].HeaderText = "تاريخ الإنتاج";
            dataGridView1.Columns["ExpireDate"].HeaderText = "تاريخ الإنتهاء";
            dataGridView1.Columns["Bracode"].HeaderText = "الباركود";
            dataGridView1.Columns["Company"].HeaderText = "الشركة";
        }

        public DataTable GetData()
        {            
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Id");
            tbl.Columns.Add("Name");
            tbl.Columns.Add("Quantity");
            tbl.Columns.Add("UnitName");
            tbl.Columns.Add("Price");
            tbl.Columns.Add("Store");
            tbl.Columns.Add("ProductDate");
            tbl.Columns.Add("ExpireDate");
            tbl.Columns.Add("Bracode");
            tbl.Columns.Add("Company");
            for (int i = 1; i <= 10; i++)
            {
                var row = tbl.NewRow();
                row["Id"] = i;
                row["Name"] = "Item "+ i;
                row["Quantity"] = i;
                row["UnitName"] = "UnitName " + i;
                row["Price"] = 100* i;
                row["Store"] = "Store " + i;
                row["ProductDate"] = "01-01-2019";
                row["ExpireDate"] = "01-01-2019";
                row["Bracode"] = i+"000000000" + i;
                row["Company"] = "Company " + i;
                tbl.Rows.Add(row);
            }
            return tbl;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            this.dataGridView1.PrintDataReport();
        }
    }
}
