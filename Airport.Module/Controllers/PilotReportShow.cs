using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.Persistent.BaseImpl;
using Airport.Module.BusinessObjects.Structure;

namespace Airport.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PilotReportShow : ViewController
    {
        public PilotReportShow()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        private void PlainReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            IReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(CriteriaOperator.Parse("DisplayName = 'PilotsReport'"));
            string reportContainerHandle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);

            ReportsModuleV2 module = ReportsModuleV2.FindReportsModule(Application.Modules);
            if (module != null)
            {
                module.ReportsDataSourceHelper.BeforeShowPreview += ReportsDataSourceHelper_BeforeShowPreview;
                Frame.GetController<ReportServiceController>().ShowPreview(reportContainerHandle);
                module.ReportsDataSourceHelper.BeforeShowPreview -= ReportsDataSourceHelper_BeforeShowPreview;
            }
        }

        void ReportsDataSourceHelper_BeforeShowPreview(object sender, BeforeShowPreviewEventArgs e)
        {
            var currentViewObject = View.CurrentObject as Pilot;
            e.Report.Parameters["OidParam"].Value = currentViewObject.Oid;
        }

    }
}
