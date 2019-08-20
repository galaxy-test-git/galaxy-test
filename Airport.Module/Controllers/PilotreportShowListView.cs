using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl;

namespace Airport.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PilotreportShowListView : ViewController
    {
        public PilotreportShowListView()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        private void PlainReportListView_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            IReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(CriteriaOperator.Parse("DisplayName = 'PilotsReport'"));
            var reportContainerHandle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);

            ReportsModuleV2 module = ReportsModuleV2.FindReportsModule(Application.Modules);
            if (module != null)
            {
                Frame.GetController<ReportServiceController>().ShowPreview(reportContainerHandle);
            }
        }
    }
}
