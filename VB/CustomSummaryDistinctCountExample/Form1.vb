﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections

Namespace CustomSummaryDistinctCountExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New DistinctCountFunction())
			InitializeComponent()
			pivotGridControl1.BestFit()
			excelDataSource1.Fill()
		End Sub

		Private Sub AddCustomSummaryField()
			pivotGridControl1.Fields.Add(New PivotGridField() With {
				.Area = PivotArea.DataArea,
				.AreaIndex = 1,
				.Caption = "Count Distinct ",
				.FieldName = "Quantity",
				.Name = "fieldQuantityDistinctCount",
				.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
			})
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
		End Sub

		Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs)
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim name_Renamed As String = e.DataField.FieldName

			Dim list As IList = e.CreateDrillDownDataSource()
			Dim ht As New Hashtable()
			For i As Integer = 0 To list.Count - 1
				Dim row As PivotDrillDownDataRow = TryCast(list(i), PivotDrillDownDataRow)
				Dim v As Object = row(name_Renamed)
				If v IsNot Nothing AndAlso v IsNot DBNull.Value Then
					ht(v) = Nothing
				End If
			Next i
			e.CustomValue = ht.Count
		End Sub
	End Class
End Namespace
