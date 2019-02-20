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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo21 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo22 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo23 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo24 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo25 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo26 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo27 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo28 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo29 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo30 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings3 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions3 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings3);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
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
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.excelDataSource1;
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
            this.pivotGridControl1.Size = new System.Drawing.Size(775, 447);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "C:\\Data\\SalesPerson.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo21.Name = "CategoryName";
            fieldInfo21.Type = typeof(string);
            fieldInfo22.Name = "Country";
            fieldInfo22.Type = typeof(string);
            fieldInfo23.Name = "ProductName";
            fieldInfo23.Type = typeof(string);
            fieldInfo24.Name = "Sales Person";
            fieldInfo24.Type = typeof(string);
            fieldInfo25.Name = "OrderDate";
            fieldInfo25.Type = typeof(System.DateTime);
            fieldInfo26.Name = "OrderID";
            fieldInfo26.Type = typeof(double);
            fieldInfo27.Name = "Quantity";
            fieldInfo27.Type = typeof(double);
            fieldInfo28.Name = "Discount";
            fieldInfo28.Type = typeof(double);
            fieldInfo29.Name = "Extended Price";
            fieldInfo29.Type = typeof(double);
            fieldInfo30.Name = "UnitPrice";
            fieldInfo30.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo21,
            fieldInfo22,
            fieldInfo23,
            fieldInfo24,
            fieldInfo25,
            fieldInfo26,
            fieldInfo27,
            fieldInfo28,
            fieldInfo29,
            fieldInfo30});
            excelWorksheetSettings3.CellRange = null;
            excelWorksheetSettings3.WorksheetName = "Data";
            excelSourceOptions3.ImportSettings = excelWorksheetSettings3;
            this.excelDataSource1.SourceOptions = excelSourceOptions3;
            // 
            // fieldOrderID1
            // 
            this.fieldOrderID1.AreaIndex = 0;
            this.fieldOrderID1.Caption = "Order ID";
            this.fieldOrderID1.FieldName = "OrderID";
            this.fieldOrderID1.Name = "fieldOrderID1";
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.AreaIndex = 1;
            this.fieldCountry1.Caption = "Country";
            this.fieldCountry1.FieldName = "Country";
            this.fieldCountry1.Name = "fieldCountry1";
            // 
            // fieldFirstName1
            // 
            this.fieldFirstName1.AreaIndex = 2;
            this.fieldFirstName1.Caption = "First Name";
            this.fieldFirstName1.FieldName = "FirstName";
            this.fieldFirstName1.Name = "fieldFirstName1";
            // 
            // fieldLastName1
            // 
            this.fieldLastName1.AreaIndex = 3;
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
            this.fieldOrderDate1.Caption = "OrderDate";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 4;
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
            this.fieldDiscount1.AreaIndex = 5;
            this.fieldDiscount1.Caption = "Discount";
            this.fieldDiscount1.FieldName = "Discount";
            this.fieldDiscount1.Name = "fieldDiscount1";
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.AreaIndex = 6;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "Extended Price";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            // 
            // fieldSalesPerson1
            // 
            this.fieldSalesPerson1.AreaIndex = 7;
            this.fieldSalesPerson1.Caption = "Sales Person";
            this.fieldSalesPerson1.FieldName = "Sales Person";
            this.fieldSalesPerson1.Name = "fieldSalesPerson1";
            // 
            // fieldQuantityDistinctCount
            // 
            this.fieldQuantityDistinctCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantityDistinctCount.AreaIndex = 1;
            this.fieldQuantityDistinctCount.Caption = "Count Distinct ";
            this.fieldQuantityDistinctCount.FieldName = "Quantity";
            this.fieldQuantityDistinctCount.Name = "fieldQuantityDistinctCount";
            this.fieldQuantityDistinctCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 447);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Custom Summary Distinct Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
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
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

