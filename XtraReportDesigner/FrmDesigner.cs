
namespace XtraReportDesigner
{
    public partial class FrmDesigner : DevExpress.XtraEditors.XtraForm
    {
        public FrmDesigner(string filePath)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(filePath))
                reportDesigner1.OpenReport(filePath);
        }
    }
}