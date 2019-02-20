Namespace CustomSummaryDistinctCountExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.nwindDataSet = New CustomSummaryDistinctCountExample.nwindDataSet()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.salesPersonTableAdapter = New CustomSummaryDistinctCountExample.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.fieldOrderID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldFirstName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldLastName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantityDistinctCount = New DevExpress.XtraPivotGrid.PivotGridField()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldOrderID1, Me.fieldCountry1, Me.fieldFirstName1, Me.fieldLastName1, Me.fieldProductName1, Me.fieldCategoryName1, Me.fieldOrderDate1, Me.fieldUnitPrice1, Me.fieldQuantity1, Me.fieldDiscount1, Me.fieldExtendedPrice1, Me.fieldSalesPerson1, Me.fieldQuantityDistinctCount})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(767, 447)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' salesPersonBindingSource
			' 
			Me.salesPersonBindingSource.DataMember = "SalesPerson"
			Me.salesPersonBindingSource.DataSource = Me.nwindDataSet
			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' fieldOrderID1
			' 
			Me.fieldOrderID1.AreaIndex = 2
			Me.fieldOrderID1.Caption = "Order ID"
			Me.fieldOrderID1.FieldName = "OrderID"
			Me.fieldOrderID1.Name = "fieldOrderID1"
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.Caption = "Country"
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			' 
			' fieldFirstName1
			' 
			Me.fieldFirstName1.AreaIndex = 3
			Me.fieldFirstName1.Caption = "First Name"
			Me.fieldFirstName1.FieldName = "FirstName"
			Me.fieldFirstName1.Name = "fieldFirstName1"
			' 
			' fieldLastName1
			' 
			Me.fieldLastName1.AreaIndex = 4
			Me.fieldLastName1.Caption = "Last Name"
			Me.fieldLastName1.FieldName = "LastName"
			Me.fieldLastName1.Name = "fieldLastName1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate1.AreaIndex = 0
			Me.fieldOrderDate1.Caption = "Order Date"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.AreaIndex = 5
			Me.fieldUnitPrice1.Caption = "Unit Price"
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			' 
			' fieldQuantity1
			' 
			Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity1.AreaIndex = 0
			Me.fieldQuantity1.Caption = "Quantity"
			Me.fieldQuantity1.FieldName = "Quantity"
			Me.fieldQuantity1.Name = "fieldQuantity1"
			' 
			' fieldDiscount1
			' 
			Me.fieldDiscount1.AreaIndex = 6
			Me.fieldDiscount1.Caption = "Discount"
			Me.fieldDiscount1.FieldName = "Discount"
			Me.fieldDiscount1.Name = "fieldDiscount1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.AreaIndex = 7
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.AreaIndex = 1
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' fieldQuantityDistinctCount
			' 
			Me.fieldQuantityDistinctCount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantityDistinctCount.AreaIndex = 1
			Me.fieldQuantityDistinctCount.Caption = "Count Distinct"
			Me.fieldQuantityDistinctCount.FieldName = "Quantity"
			Me.fieldQuantityDistinctCount.Name = "fieldQuantityDistinctCount"
			Me.fieldQuantityDistinctCount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(767, 447)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Custom Summary Distinct Count"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private fieldOrderID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldFirstName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldLastName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantityDistinctCount As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

