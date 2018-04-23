using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WindowsApplication4
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompanyName,
            this.fieldOrderYear,
            this.fieldOrderQuarter,
            this.fieldProductAmount});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(648, 478);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.FieldName = "CompanyName";
            this.fieldCompanyName.Name = "fieldCompanyName";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.FieldName = "OrderYear";
            this.fieldOrderYear.Name = "fieldOrderYear";
            // 
            // fieldOrderQuarter
            // 
            this.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderQuarter.AreaIndex = 1;
            this.fieldOrderQuarter.FieldName = "OrderQuarter";
            this.fieldOrderQuarter.Name = "fieldOrderQuarter";
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.CellFormat.FormatString = "d";
            this.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductAmount.FieldName = "ProductAmount";
            this.fieldProductAmount.Name = "fieldProductAmount";
            this.fieldProductAmount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.fieldProductAmount.TotalCellFormat.FormatString = "d";
            this.fieldProductAmount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductAmount.TotalValueFormat.FormatString = "d";
            this.fieldProductAmount.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductAmount.ValueFormat.FormatString = "d";
            this.fieldProductAmount.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(648, 478);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

                private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            Random r = new Random();
            tbl.Columns.Add("CompanyName", typeof(string));
            tbl.Columns.Add("OrderQuarter", typeof(int));
            tbl.Columns.Add("ProductAmount", typeof(int));
            tbl.Columns.Add("OrderYear", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("CompanyName{0}", r.Next(5)), r.Next(3), r.Next(10000), DateTime.Today.AddDays(r.Next(5)) });
            return tbl;
        }
        


        private void Form1_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = CreateTable(500);
        }

        private void pivotGridControl1_CustomSummary(object sender, DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs e) {
            string name = e.DataField.FieldName;

            if (e.DataField.SummaryType == DevExpress.Data.PivotGrid.PivotSummaryType.Custom) {
                IList list = e.CreateDrillDownDataSource();
                Hashtable ht = new Hashtable();
                for(int i = 0; i < list.Count; i++) {
                    DevExpress.XtraPivotGrid.PivotDrillDownDataRow row =  list[i] as DevExpress.XtraPivotGrid.PivotDrillDownDataRow;

                    object v = row[name];

                    if (v != null && v != DBNull.Value)
                        ht[v] = null;
                }

                e.CustomValue = ht.Count;
            }
        }
	}
}
