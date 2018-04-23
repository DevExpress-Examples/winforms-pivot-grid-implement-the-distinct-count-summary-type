Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace WindowsApplication4
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderQuarter As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCompanyName, Me.fieldOrderYear, Me.fieldOrderQuarter, Me.fieldProductAmount})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(648, 478)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomSummary += New DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(Me.pivotGridControl1_CustomSummary);
			' 
			' fieldCompanyName
			' 
			Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCompanyName.AreaIndex = 0
			Me.fieldCompanyName.FieldName = "CompanyName"
			Me.fieldCompanyName.Name = "fieldCompanyName"
			' 
			' fieldOrderYear
			' 
			Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderYear.AreaIndex = 0
			Me.fieldOrderYear.FieldName = "OrderYear"
			Me.fieldOrderYear.Name = "fieldOrderYear"
			' 
			' fieldOrderQuarter
			' 
			Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderQuarter.AreaIndex = 1
			Me.fieldOrderQuarter.FieldName = "OrderQuarter"
			Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
			' 
			' fieldProductAmount
			' 
			Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldProductAmount.AreaIndex = 0
			Me.fieldProductAmount.CellFormat.FormatString = "d"
			Me.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductAmount.FieldName = "ProductAmount"
			Me.fieldProductAmount.Name = "fieldProductAmount"
			Me.fieldProductAmount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
			Me.fieldProductAmount.TotalCellFormat.FormatString = "d"
			Me.fieldProductAmount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductAmount.TotalValueFormat.FormatString = "d"
			Me.fieldProductAmount.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.fieldProductAmount.ValueFormat.FormatString = "d"
			Me.fieldProductAmount.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(648, 478)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

				Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			Dim r As New Random()
			tbl.Columns.Add("CompanyName", GetType(String))
			tbl.Columns.Add("OrderQuarter", GetType(Integer))
			tbl.Columns.Add("ProductAmount", GetType(Integer))
			tbl.Columns.Add("OrderYear", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("CompanyName{0}", r.Next(5)), r.Next(3), r.Next(10000), DateTime.Today.AddDays(r.Next(5)) })
			Next i
			Return tbl
				End Function



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			pivotGridControl1.DataSource = CreateTable(500)
		End Sub

		Private Sub pivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles pivotGridControl1.CustomSummary
			Dim name As String = e.DataField.FieldName

			If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
				Dim list As IList = e.CreateDrillDownDataSource()
				Dim ht As New Hashtable()
				For i As Integer = 0 To list.Count - 1
					Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = TryCast(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

					Dim v As Object = row(name)

					If v IsNot Nothing AndAlso v IsNot DBNull.Value Then
						ht(v) = Nothing
					End If
				Next i

				e.CustomValue = ht.Count
			End If
		End Sub
	End Class
End Namespace
