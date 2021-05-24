using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PrintDgvToXtraReport
{
    public partial class DataGridViewReport : DevExpress.XtraReports.UI.XtraReport
    {
        PrintableObject model;
        private System.ComponentModel.IContainer components = null;        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code        
        private void InitializeComponent()
        {
            int RepWidth = 0;
            foreach (var col in model.Cols)
                RepWidth += col.Width;            
            if(RepWidth > this.PageSize.Width)
                this.Landscape = true;

            this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.RightToLeftLayout = RightToLeftLayout.Yes;
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.HeaderxrTable = new DevExpress.XtraReports.UI.XRTable();
            this.HeaderxrTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.DetailxrTable = new DevExpress.XtraReports.UI.XRTable();
            this.DetailxrTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderxrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailxrTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.HeaderxrTable});
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.DetailxrTable});
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.HeightF = 23;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 30F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 30F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 0F;
            this.PageHeader.Name = "PageHeader";

            // 
            // HeaderxrTable
            // 
            this.HeaderxrTable.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HeaderxrTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.HeaderxrTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.HeaderxrTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.HeaderxrTable.Name = "HeaderxrTable";
            this.HeaderxrTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.HeaderxrTableRow});
            this.HeaderxrTable.SizeF = new System.Drawing.SizeF(this.PageSize.Width, 25F);
            this.HeaderxrTable.StylePriority.UseBackColor = false;
            this.HeaderxrTable.StylePriority.UseBorders = false;
            this.HeaderxrTable.StylePriority.UseFont = false;
            this.HeaderxrTable.StylePriority.UseTextAlignment = false;
            this.HeaderxrTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            // 
            // DetailxrTable
            //             
            this.DetailxrTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
            | DevExpress.XtraPrinting.BorderSide.Right)
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.DetailxrTable.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.DetailxrTable.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.DetailxrTable.Name = "DetailxrTable";
            this.DetailxrTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.DetailxrTableRow});
            this.DetailxrTable.SizeF = new System.Drawing.SizeF(this.PageSize.Width, 25F);
            this.DetailxrTable.StylePriority.UseBackColor = false;
            this.DetailxrTable.StylePriority.UseBorders = false;
            this.DetailxrTable.StylePriority.UseFont = false;
            this.DetailxrTable.StylePriority.UseTextAlignment = false;
            this.DetailxrTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

            // 
            // HeaderxrTableRow
            // 
            HeaderCells = new List<XRTableCell>();
            foreach (var item in this.model.Cols)
            {
                var cell = new DevExpress.XtraReports.UI.XRTableCell();
                cell.Name = item.Name;
                cell.Text = item.HeaderText;
                //cell.Weight = 0.37185071226322119D;
                cell.WidthF = item.Width;
                HeaderCells.Add(cell);
            }

            this.HeaderxrTableRow.Cells.AddRange(HeaderCells.ToArray());
            this.HeaderxrTableRow.Name = "HeaderxrTableRow";
            this.HeaderxrTableRow.Weight = 1D;
            
            // 
            // DetailxrTableRow
            // 
            DetailCells = new List<XRTableCell>();
            foreach (var item in this.model.Cols)
            {
                var cell = new DevExpress.XtraReports.UI.XRTableCell();
                cell.Name = item.Name;
                cell.Text = item.HeaderText;
                cell.DataBindings.Add("Text",model.DataSource,item.Name);
                //cell.Weight = 0.37185071226322119D;
                cell.WidthF = item.Width;
                DetailCells.Add(cell);
            }

            this.DetailxrTableRow.Cells.AddRange(DetailCells.ToArray());
            this.DetailxrTableRow.Name = "DetailxrTableRow";
            this.DetailxrTableRow.Weight = 1D;
            // 
            // EmptyRep
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader});
            this.Margins = new System.Drawing.Printing.Margins(28, 30, 30, 30);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderxrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailxrTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            
            this.DataSource = model.DataSource;
        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable HeaderxrTable;
        private DevExpress.XtraReports.UI.XRTable DetailxrTable;
        private DevExpress.XtraReports.UI.XRTableRow HeaderxrTableRow;
        private DevExpress.XtraReports.UI.XRTableRow DetailxrTableRow;        
        private List<DevExpress.XtraReports.UI.XRTableCell> HeaderCells;
        private List<DevExpress.XtraReports.UI.XRTableCell> DetailCells;
        public DataGridViewReport(PrintableObject model)
        {
            this.model = model;
            InitializeComponent();            
        }        
    }
}
