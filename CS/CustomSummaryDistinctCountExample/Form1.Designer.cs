namespace CustomSummaryDistinctCountExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.nwindDataSet = new CustomSummaryDistinctCountExample.nwindDataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new CustomSummaryDistinctCountExample.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.fieldOrderID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFirstName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLastName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantityDistinctCount = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.salesPersonBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderID1,
            this.fieldCountry1,
            this.fieldFirstName1,
            this.fieldLastName1,
            this.fieldProductName1,
            this.fieldCategoryName1,
            this.fieldOrderDate1,
            this.fieldUnitPrice1,
            this.fieldQuantity1,
            this.fieldDiscount1,
            this.fieldExtendedPrice1,
            this.fieldSalesPerson1,
            this.fieldQuantityDistinctCount});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(767, 447);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.nwindDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // fieldOrderID1
            // 
            this.fieldOrderID1.AreaIndex = 2;
            this.fieldOrderID1.Caption = "Order ID";
            this.fieldOrderID1.FieldName = "OrderID";
            this.fieldOrderID1.Name = "fieldOrderID1";
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.AreaIndex = 0;
            this.fieldCountry1.Caption = "Country";
            this.fieldCountry1.FieldName = "Country";
            this.fieldCountry1.Name = "fieldCountry1";
            // 
            // fieldFirstName1
            // 
            this.fieldFirstName1.AreaIndex = 3;
            this.fieldFirstName1.Caption = "First Name";
            this.fieldFirstName1.FieldName = "FirstName";
            this.fieldFirstName1.Name = "fieldFirstName1";
            // 
            // fieldLastName1
            // 
            this.fieldLastName1.AreaIndex = 4;
            this.fieldLastName1.Caption = "Last Name";
            this.fieldLastName1.FieldName = "LastName";
            this.fieldLastName1.Name = "fieldLastName1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldCategoryName1
            // 
            this.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName1.AreaIndex = 0;
            this.fieldCategoryName1.Caption = "Category Name";
            this.fieldCategoryName1.FieldName = "CategoryName";
            this.fieldCategoryName1.Name = "fieldCategoryName1";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 0;
            this.fieldOrderDate1.Caption = "Order Date";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 5;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity1.AreaIndex = 0;
            this.fieldQuantity1.Caption = "Quantity";
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            // 
            // fieldDiscount1
            // 
            this.fieldDiscount1.AreaIndex = 6;
            this.fieldDiscount1.Caption = "Discount";
            this.fieldDiscount1.FieldName = "Discount";
            this.fieldDiscount1.Name = "fieldDiscount1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.AreaIndex = 7;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.AreaIndex = 1;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldQuantityDistinctCount
            // 
            this.fieldQuantityDistinctCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantityDistinctCount.AreaIndex = 1;
            this.fieldQuantityDistinctCount.Caption = "Count Distinct";
            this.fieldQuantityDistinctCount.FieldName = "Quantity";
            this.fieldQuantityDistinctCount.Name = "fieldQuantityDistinctCount";
            this.fieldQuantityDistinctCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 447);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Custom Summary Distinct Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFirstName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLastName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesPerson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantityDistinctCount;
    }
}

