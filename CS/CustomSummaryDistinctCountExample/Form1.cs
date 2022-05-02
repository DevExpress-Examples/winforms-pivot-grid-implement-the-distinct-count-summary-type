﻿using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using System;
using System.Collections;

namespace CustomSummaryDistinctCountExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(new DistinctCountFunction());
            InitializeComponent();
            pivotGridControl1.BestFit();
            excelDataSource1.Fill();
       }

        private void AddCustomSummaryField()
        {
            pivotGridControl1.Fields.Add(new PivotGridField()
            {
                Area = PivotArea.DataArea,
                AreaIndex = 1,
                Caption = "Count Distinct ",
                FieldName = "Quantity",
                Name = "fieldQuantityDistinctCount",
                SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void PivotGridControl1_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
        {
            string name = e.DataField.FieldName;

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
