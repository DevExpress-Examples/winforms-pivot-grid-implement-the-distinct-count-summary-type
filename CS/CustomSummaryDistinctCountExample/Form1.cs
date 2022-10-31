using DevExpress.XtraEditors;

namespace CustomSummaryDistinctCountExample
{
    public partial class Form1 : XtraForm {
        public Form1() {
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(new DistinctCountFunction());
            InitializeComponent();
            pivotGridControl1.BestFit();
            excelDataSource1.Fill();
       }
    }
}
