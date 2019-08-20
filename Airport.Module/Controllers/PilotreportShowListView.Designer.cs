namespace Airport.Module.Controllers
{
    partial class PilotreportShowListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlainReportListView = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PlainReportListView
            // 
            this.PlainReportListView.Caption = "Очтет";
            this.PlainReportListView.ConfirmationMessage = null;
            this.PlainReportListView.Id = "PlainReportListView";
            this.PlainReportListView.ImageName = "BO_Report";
            this.PlainReportListView.ToolTip = null;
            this.PlainReportListView.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PlainReportListView_Execute);
            // 
            // PilotreportShowListView
            // 
            this.Actions.Add(this.PlainReportListView);
            this.TargetObjectType = typeof(Airport.Module.BusinessObjects.Structure.Pilot);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.ListView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PlainReportListView;
    }
}
