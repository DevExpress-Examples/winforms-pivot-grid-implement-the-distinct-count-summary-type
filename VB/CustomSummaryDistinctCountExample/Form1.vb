﻿Imports DevExpress.XtraEditors
Imports DevExpress.XtraPivotGrid
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomSummaryDistinctCountExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler pivotGridControl1.CustomSummary, AddressOf PivotGridControl1_CustomSummary
			pivotGridControl1.BestFit()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
		End Sub

		Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs)
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim name_Renamed As String = e.DataField.FieldName

			If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
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
			End If
		End Sub
	End Class
End Namespace