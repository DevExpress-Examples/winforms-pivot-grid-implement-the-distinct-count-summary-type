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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo10 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dataSourceColumnBinding1 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding2 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim dataSourceColumnBinding3 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Dim expressionDataBinding1 As New DevExpress.XtraPivotGrid.ExpressionDataBinding()
			Dim dataSourceColumnBinding4 As New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.field1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.field = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.field2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.fieldQuantityDistinctCount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.field1, Me.field, Me.field2, Me.fieldQuantity1, Me.pivotGridField1, Me.pivotGridField2})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
			Me.pivotGridControl1.Size = New System.Drawing.Size(775, 447)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.FileName = "\Data\SalesPerson.xlsx"
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "CategoryName"
			fieldInfo1.OriginalName = Nothing
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Country"
			fieldInfo2.OriginalName = Nothing
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "ProductName"
			fieldInfo3.OriginalName = Nothing
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "Sales Person"
			fieldInfo4.OriginalName = Nothing
			fieldInfo4.Type = GetType(String)
			fieldInfo5.Name = "OrderDate"
			fieldInfo5.OriginalName = Nothing
			fieldInfo5.Type = GetType(Date)
			fieldInfo6.Name = "OrderID"
			fieldInfo6.OriginalName = Nothing
			fieldInfo6.Type = GetType(Double)
			fieldInfo7.Name = "Quantity"
			fieldInfo7.OriginalName = Nothing
			fieldInfo7.Type = GetType(Double)
			fieldInfo8.Name = "Discount"
			fieldInfo8.OriginalName = Nothing
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "Extended Price"
			fieldInfo9.OriginalName = Nothing
			fieldInfo9.Type = GetType(Double)
			fieldInfo10.Name = "UnitPrice"
			fieldInfo10.OriginalName = Nothing
			fieldInfo10.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetIndex = Nothing
			excelWorksheetSettings1.WorksheetName = "Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.excelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' field1
			' 
			Me.field1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.field1.AreaIndex = 1
			Me.field1.Caption = "Product Name"
			dataSourceColumnBinding1.ColumnName = "ProductName"
			Me.field1.DataBinding = dataSourceColumnBinding1
			Me.field1.Name = "field1"
			' 
			' field
			' 
			Me.field.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.field.AreaIndex = 0
			Me.field.Caption = "Category Name"
			dataSourceColumnBinding2.ColumnName = "CategoryName"
			Me.field.DataBinding = dataSourceColumnBinding2
			Me.field.Name = "field"
			' 
			' field2
			' 
			Me.field2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.field2.AreaIndex = 0
			Me.field2.Caption = "OrderDate"
			dataSourceColumnBinding3.ColumnName = "OrderDate"
			dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.field2.DataBinding = dataSourceColumnBinding3
			Me.field2.Name = "field2"
			Me.field2.UnboundFieldName = "fieldOrderDate1"
			' 
			' fieldQuantity1
			' 
			Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity1.AreaIndex = 0
			Me.fieldQuantity1.Caption = "Quantity"
			Me.fieldQuantity1.FieldName = "Quantity"
			Me.fieldQuantity1.Name = "fieldQuantity1"
			' 
			' fieldQuantityDistinctCount
			' 
			Me.fieldQuantityDistinctCount.Name = "fieldQuantityDistinctCount"
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField1.AreaIndex = 1
			Me.pivotGridField1.Caption = "Order Distinct Count"
			expressionDataBinding1.Expression = "DistinctCount([OrderID])"
			Me.pivotGridField1.DataBinding = expressionDataBinding1
			Me.pivotGridField1.Name = "pivotGridField1"
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.AreaIndex = 0
			dataSourceColumnBinding4.ColumnName = "OrderID"
			Me.pivotGridField2.DataBinding = dataSourceColumnBinding4
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(775, 447)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Custom Summary Distinct Count"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.salesPersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private salesPersonBindingSource As System.Windows.Forms.BindingSource
		Private field1 As DevExpress.XtraPivotGrid.PivotGridField
		Private field As DevExpress.XtraPivotGrid.PivotGridField
		Private field2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantityDistinctCount As DevExpress.XtraPivotGrid.PivotGridField
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

