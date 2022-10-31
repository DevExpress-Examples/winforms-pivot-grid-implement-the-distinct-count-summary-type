Imports DevExpress.XtraEditors

Namespace CustomSummaryDistinctCountExample
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New DistinctCountFunction())
			InitializeComponent()
			pivotGridControl1.BestFit()
			excelDataSource1.Fill()
		End Sub
	End Class
End Namespace
