using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomSummaryDistinctCountExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            pivotGridControl1.CustomSummary += PivotGridControl1_CustomSummary;
            pivotGridControl1.BestFit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();
        }

        private void PivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            string name = e.DataField.FieldName;

            if (e.DataField.SummaryType == DevExpress.Data.PivotGrid.PivotSummaryType.Custom)
            {
                IList list = e.CreateDrillDownDataSource();
                Hashtable ht = new Hashtable();
                for (int i = 0; i < list.Count; i++)
                {
                    PivotDrillDownDataRow row = list[i] as PivotDrillDownDataRow;
                    object v = row[name];
                    if (v != null && v != DBNull.Value)
                        ht[v] = null;
                }
                e.CustomValue = ht.Count;
            }
        }
    }
}
