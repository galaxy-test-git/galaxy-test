namespace Airport.Module.Controllers
{
    partial class PilotReportShow
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
            this.PlainReport = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PlainReport
            // 
            this.PlainReport.Caption = "Отчет";
            this.PlainReport.ConfirmationMessage = null;
            this.PlainReport.Id = "PlainReport";
            this.PlainReport.ImageName = "BO_Report";
            this.PlainReport.ToolTip = null;
            this.PlainReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PlainReport_Execute);
            // 
            // PilotReportShow
            // 
            this.Actions.Add(this.PlainReport);
            this.TargetObjectType = typeof(Airport.Module.BusinessObjects.Structure.Pilot);
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PlainReport;
    }
}
