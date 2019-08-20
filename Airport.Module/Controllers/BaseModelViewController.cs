using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win.SystemModule;
using Airport.Module.Mappers;
using Airport.Plugins.Service;

namespace Airport.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class BaseModelViewController : WinModificationsController
    {
        public BaseModelViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        private bool CheckInPlugin()
        {
            var newData = new BaseMapper().GetData(View.CurrentObject);
            var plugin = new PluginService();
            var isChecks = plugin.Check(newData);

            if(!isChecks)
                throw new UserFriendlyException("Данные не прошли дополнительную проверку и не были сохранены");

            return true;
        }
        protected override void Save(SimpleActionExecuteEventArgs args)
        {
            if (CheckInPlugin())
                base.Save(args);
        }

        protected override void SaveAndClose(SimpleActionExecuteEventArgs args)
        {
            if (CheckInPlugin())
                base.SaveAndClose(args);
        }

        protected override void SaveAndNew(SingleChoiceActionExecuteEventArgs args)
        {
            if (CheckInPlugin())
                base.SaveAndNew(args);
        }
    }
}
